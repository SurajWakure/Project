using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using PokemonReviewApp.Repository;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private ICarReposetory _carsRepo;

        public CarsController(ICarReposetory carReposetory)
        {
            _carsRepo=carReposetory;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Car>))]
        public IActionResult GetCarsbyModelCode(string code)
        {
            var cars = _carsRepo.GetCarByModelCode(code);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(cars);
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Car>))]
        public IActionResult GetCarsbyModelName(string name)
        {
            var cars = _carsRepo.GetCarByModelCode(name);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(cars);
        }



    }
}
