using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.Dto
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}