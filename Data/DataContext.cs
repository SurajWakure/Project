using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;
using System.Data;

namespace PokemonReviewApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        
        public DbSet<Car> cars { get; set; }

       
    }
}


                                                      