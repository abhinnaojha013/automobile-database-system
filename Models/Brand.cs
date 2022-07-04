using System.ComponentModel.DataAnnotations;

namespace automobile_database_system.Models
{
    public class Brand
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string BrandName { get; set; }
    }
}
