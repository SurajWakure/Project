using System.ComponentModel.DataAnnotations;

namespace PokemonReviewApp.Models
{
    public class ClassOfCar
    {
        public int Id { get; set; }
        public string class1 { get; set; }

        [Required(ErrorMessage = "Image URL is required.")]
        [Url(ErrorMessage = "Invalid URL format.")]
        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Features { get; set; }

    }
}
