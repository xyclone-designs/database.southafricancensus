using Database.SouthAfricanCensus.Enums;

namespace Database.SouthAfricanCensus.Models
{
	public class Location
	{
		public string? District { get; set; }
		public GeoTypes? GeoType { get; set; }
		public string? Municipality { get; set; }
		public Countries? Country { get; set; }
		public Provinces? Province { get; set; }
	}
}