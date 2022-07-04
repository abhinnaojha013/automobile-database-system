using System.ComponentModel.DataAnnotations;

namespace automobile_database_system.Models
{
    public class Auto
    {
		[Key]
		[Required]
		public int Id {get; set;}

		[Required]
		public string Brand { get; set;}

		[Required]
		public string ModelName { get; set;}

		[Required]
		public int BuildYear { get; set;}

		[Required]
		public int VehicleType { get; set; }

		[Required]
		public string Category { get; set;}

		[Required]
		public float EngineSize { get; set;}

		public int DiscontinuedYear { get; set;}

		[Required]
		public float Price { get; set;}
	}
}
