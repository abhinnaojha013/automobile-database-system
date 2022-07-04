using System.ComponentModel.DataAnnotations;

namespace automobile_database_system.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Type { get; set; }

    }
}
