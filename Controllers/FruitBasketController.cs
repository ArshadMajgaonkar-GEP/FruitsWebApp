using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitBasketController : ControllerBase
    {
        static List<string> fruitBasket = new List<string> { "Apple", "Banana", "Cherry" };

        private readonly IGuidService _guidService;

        public FruitBasketController(IGuidService guidService)
        {
            _guidService = guidService;
        }

        [HttpGet("GetFruits")]
        public IActionResult GetFruitBasket()
        {
            return Ok(fruitBasket);
        }

        [HttpPost("AddToBasket")]
        public IActionResult AddFruit([FromBody] string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                fruitBasket.Add(name);
                return Ok(fruitBasket);
            }
            else
            {
                return BadRequest("Fruit name cannot be empty.");
            }
        }

        [HttpGet("GetGUID")]
        public ActionResult<string> getGUID()
        {
            return _guidService.GetSpecialGuidFromWeb();
        }
    }
}
