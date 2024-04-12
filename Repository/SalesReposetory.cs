using CarsProject.Interfaces;
using CarsProject.Models;
using PokemonReviewApp.Models;

namespace CarsProject.Repository
{
    public class SalesReposetory : ISalesReposetory
    {
        private ISalesReposetory _salesReposetory;

        public SalesReposetory(ISalesReposetory salesReposetory)
        {
            _salesReposetory=salesReposetory;
        }

        public ICollection<SalesReport> sales(string name)
        {

            var amount = _salesReposetory.SalesAmount(name);
            var renault = _salesReposetory.SalesCountRenault(name);
            var audi = _salesReposetory.SalesCountAudi(name);
            var jaguar = _salesReposetory.SalesCountJaguar(name);
            var landRover = _salesReposetory.SalesCountLandRover(name);

           int amountwithbonus = 0;

            if (renault)
            {
                amountwithbonus = 400;
                if (SalesReport.class2 == "A")
                {
                    decimal price = ClassOfCar.Price;
                    amountwithbonus = 5 / 100 * price;
                    amountwithbonus += amountwithbonus;
                }
                if (SalesReport.class2 == "B")
                {
                    decimal price = ClassOfCar.Price;
                    amountwithbonus = 3 / 100 * price;
                    amountwithbonus += amountwithbonus;
                }
                if (SalesReport.class2 == "C")
                {
                    decimal price = ClassOfCar.Price;
                    amountwithbonus = 2 / 100 * price;
                    amountwithbonus += amountwithbonus;
                }
            }

            if (audi)
            {
                amountwithbonus = 800;
                if (SalesReport.class2 == "A")
                {
                    decimal price = ClassOfCar.Price;
                    amountwithbonus = 8 / 100 * price;
                    amountwithbonus += amountwithbonus;
                }
                if (SalesReport.class2 == "B")
                {
                    decimal price = ClassOfCar.Price;
                    amountwithbonus = 6 / 100 * price;
                    amountwithbonus += amountwithbonus;
                }
                if (SalesReport.class2 == "C")
                {
                    decimal price = ClassOfCar.Price;
                    amountwithbonus = 4 / 100 * price;
                    amountwithbonus += amountwithbonus;
                }
            }

            if (landRover)
            {
                amountwithbonus = 800;
                if (SalesReport.class2 == "A")
                {
                    decimal price = ClassOfCar.Price;
                    amountwithbonus = 7 / 100 * price;
                    amountwithbonus += amountwithbonus;
                }
                if (SalesReport.class2 == "B")
                {
                    decimal price = ClassOfCar.Price;
                    amountwithbonus = 5 / 100 * price;
                    amountwithbonus += amountwithbonus;
                }
                if (SalesReport.class2 == "C")
                {
                    decimal price = ClassOfCar.Price;
                    amountwithbonus = 4 / 100 * price;
                    amountwithbonus += amountwithbonus;
                }
            }
            if (Jaguar)
            {
                amountwithbonus = 800;
                if (SalesReport.class2 == "A")
                {
                    decimal price = ClassOfCar.Price;
                    amountwithbonus = 6 / 100 * price;
                    amountwithbonus += amountwithbonus;
                }
                if (SalesReport.class2 == "B")
                {
                    decimal price = ClassOfCar.Price;
                    amountwithbonus = 5 / 100 * price;
                    amountwithbonus += amountwithbonus;
                }
                if (SalesReport.class2 == "C")
                {
                    decimal price = ClassOfCar.Price;
                    amountwithbonus = 3 / 100 * price;
                    amountwithbonus += amountwithbonus;
                }
            }


            return _salesReposetory.sales(name);
        }

        public int SalesAmount(string name)
        {
            // return _salesReposetory..(p => p.)
            return _salesReposetory.SalesReport.(prop => prop.saleaman(name));
        }

        public int SalesCountAudi(string name)
        {
            return _salesReposetory.SalesReport.(prop => prop.AudiSold(name));
        }

        public int SalesCountJaguar(string name)
        {
            return _salesReposetory.SalesReport.(prop => prop.JaguarSold(name));
        }

        public int SalesCountLandRover(string name)
        {
            return _salesReposetory.SalesReport.(prop => prop.LandRoverSold(name));
        }

        public int SalesCountRenault(string name)
        {
            return _salesReposetory.SalesReport.(prop => prop.RenaultSold(name));
        }
    }
}
