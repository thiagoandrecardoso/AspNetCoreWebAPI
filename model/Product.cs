using System.ComponentModel.DataAnnotations;

namespace testef.model
{
    public class Product
    {
        [Key] public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(60, ErrorMessage = "This field must contain between 3 and 60 characters.")]
        [MinLength(3, ErrorMessage = "This field must contain between 3 and 60 characters.")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "Maximum 1024 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid Category")]
        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}