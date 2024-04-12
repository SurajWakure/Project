using CarsProject.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace CarsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private ISalesReposetory _salesRepo;

        public SalesController(ISalesReposetory salesReposetory)
        {
            _salesRepo = salesReposetory;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Car>))]
        public IActionResult SalesReport(string name)
        {
            var cars = _salesRepo.sales(name);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(cars);
        }

    }
}
