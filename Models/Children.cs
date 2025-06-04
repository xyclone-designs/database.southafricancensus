using System;

namespace Database.SouthAfricanCensus.Models
{
	public class Children 
	{
		public bool? Any { get; set; }
		public int? NumberOf { get; set; }
		public int? NumberOfBoys { get; set; }
		public int? NumberOfGirls { get; set; }
		public DateTime? FirstChildBirthAge { get; set; }
		public int? LastChildSex { get; set; }
		public int? LastChildIsAlive { get; set; }
		public DateTime? LastChildDateOfBirth { get; set; }
		public DateTime? LastChildDateOfDeath { get; set; }
	}
}