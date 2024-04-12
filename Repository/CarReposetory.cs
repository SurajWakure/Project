using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class CarReposetory:ICarReposetory
    {
        private DataContext _context;

        public CarReposetory(DataContext context)
        {
                _context=context;
        }

        public bool CarExists(int id)
        {
            return _context.cars.Any(c => c.Id == id);
        }

        public Car GetByModelName(string modelName)
        {
            return _context.cars.Where(e => e.ModelName == modelName).FirstOrDefault();

        }

        public Car GetCarByModelCode(string modelCode)
        {
            return _context.cars.Where(e => e.ModelCode == modelCode).FirstOrDefault();

        }

        public ICollection<Car> GetCars()
        {
            return _context.cars
            .OrderByDescending(c => c.DateOfManufacturing)
            .ThenBy(c => c.SortOrder)
            .ToList();

        }

        public Car GetCarsById(int id)
        {
            return _context.cars.Where(c => c.Id == id).FirstOrDefault();

        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;

        }

        //see if any car is existed in the database

    }
}
