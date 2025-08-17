using System.ComponentModel.DataAnnotations;

namespace Application.DTO
{
    public class CreateProductDto
    {
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
