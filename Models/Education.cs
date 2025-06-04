
namespace Database.SouthAfricanCensus.Models
{
	public class Education 
	{
		public bool? Attended { get; set; }
		public string? Field { get; set; }
		public string? Institution { get; set; }
		public bool? IsPrivate { get; set; }
		public bool? IsPublic { get; set; }
		public string? Level { get; set; }
		public string? Literacy { get; set; }
	}
}