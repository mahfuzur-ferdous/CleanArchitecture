using System.ComponentModel.DataAnnotations;

namespace Application.DTO
{
    public class UpdateProductDto
    {
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

}
