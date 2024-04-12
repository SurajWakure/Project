using PokemonReviewApp.Models;

namespace CarsProject.Models
{
    public class SalesReport
    {
        public int id { get; set; }
        public SalesMan salesMan { get; set; }
        public ClassOfCar class2 { get; set; }
        public int AudiSold { get; set; }
        public int JaguarSold { get; set; }
        public int LandRoverSold { get; set; }
        public int Renault { get; set; }
    }
}
