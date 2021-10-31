using Basket.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Basket.API.Entities;
using System.Net;
using Basket.API.GrpServices;
using System.Net.Http;

namespace Basket.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BasketController : ControllerBase
    {
        private IBasketRepository _repository;
        private readonly GrpServices.DiscountGrpcService _discountGrpcService;

        public BasketController(IBasketRepository repository, DiscountGrpcService discountGrpcService)
        {
            _repository = repository ?? throw new System.ArgumentNullException(nameof(repository));
            _discountGrpcService = discountGrpcService ?? throw new System.ArgumentNullException(nameof(discountGrpcService));
        }

        [HttpGet("{username}", Name = "GetBasket")]
        [ProducesResponseType(typeof(ShoppingCart),(int)HttpStatusCode.OK)]
        public async Task<ActionResult<ShoppingCart>> GetBasket(string username)
        {
            var basket = await _repository.GetBasket(username);
            return Ok(basket ?? new ShoppingCart(username));
        }

        [HttpPost]
        [ProducesResponseType(typeof(ShoppingCart), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<ShoppingCart>> UpdateBasket([FromBody] ShoppingCart basket)
        {
            // TODO : Communicate with DIscount.GRPC and
            // calculate latest prices of products into the shopping cart
            //consume Discount grpc
            HttpClient.DefaultProxy = new WebProxy();//quick fix, company proxy preventing http 2

            foreach (var item in basket.Items)
            {
                var coupon = await _discountGrpcService.GetDsiscount(item.ProductName);
                item.Price -= coupon.Amount;
            }

            return Ok(await _repository.UpdateBasket(basket));
        }

        [HttpDelete]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteBasket(string username)
        {
            await _repository.DeleteBasket(username);
            return Ok();
        }
    }
}
