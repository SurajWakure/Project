using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICarReposetory
    {
        abstract bool CarExists(int id);
        abstract Car GetCarsById(int id);
        abstract Car GetCarByModelCode(string modelCode);
        abstract Car GetByModelName(string modelName);
        abstract ICollection<Car> GetCars();
        abstract bool Save();
    }
}
