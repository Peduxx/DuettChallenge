using DuettChallenge.Business.Dtos;
using DuettChallenge.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitController : ControllerBase
    {
        private readonly IFruitsService _fruitService;

        public FruitController(IFruitsService fruitService)
        {
            _fruitService = fruitService;
        }

        [HttpPost]
        [Route("[action]")]
        public ActionResult Create([FromBody] FruitDto fruitDto)
        {
            var result = _fruitService.Create(fruitDto);

            return StatusCode(200, result);
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            var allFruits = _fruitService.GetAll();

            return StatusCode(200, allFruits);
        }
    }
}
