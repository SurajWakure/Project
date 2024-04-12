using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Models
{
    public class Car
    {
        
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        public string ModelName { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Model Code must be upto 10 characters long.")]
        public string ModelCode { get; set; }
        [Required]
        public string Description { get; set; }
        
        [Required]
        public DateTime DateOfManufacturing { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int SortOrder { get; set; }

        public ICollection<ClassOfCar> CarClass { get; set; }

    }
}
