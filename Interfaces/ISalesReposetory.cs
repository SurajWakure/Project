using CarsProject.Models;

namespace CarsProject.Interfaces
{
    public interface ISalesReposetory
    {
        abstract ICollection<SalesReport> sales(string name);
        abstract int SalesAmount(string name);
        abstract int SalesCountAudi(string name);
        abstract int SalesCountJaguar(string name);
        abstract int SalesCountLandRover(string name);
        abstract int SalesCountRenault(string name);
    }
}
