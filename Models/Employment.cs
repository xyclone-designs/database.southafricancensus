
using Database.SouthAfricanCensus.Enums;

namespace Database.SouthAfricanCensus.Models
{
	public class Employment
	{
		public EmploymentStatus[]? EmploymentStatuses { get; set; }

		public double? P24_TEMPWORKABSENCE;
		public double? P25_UNEMPLOYMENT;
		public double? P26_UNEMPLOYMENT;
		public double? P27_REASONSNOTWORKING;
		public double? P28_WORKAVAILABILITY;
		public string? Industries { get; set; }
		public string? Occupation { get; set; }
		public string? Sector { get; set; }
	}
}