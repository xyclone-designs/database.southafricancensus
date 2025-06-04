using Database.SouthAfricanCensus.Enums;

using System;

namespace Database.SouthAfricanCensus.Models
{
	public class Personhood
	{
		public int? Age { get; set; }
		public Sexes? Sex { get; set; }
		public DateTime? DateOfBirth { get; set; }

		public double? P02_RELATION;
		public MaritalStatus? MaritalStatus { get; set; }
		public Languages[]? Languages { get; set; }
		public double? P04_SPN;
		public PopulationGroups? PopulationGroup { get; set; }
		public Countries? CountryOfBirth { get; set; }
		public Provinces? ProvinceOfBirth { get; set; }
		public double? P08A_YEARMOVED;
		public CitizenshipStatus? Citizenship { get; set; }

		public double? P11_SINCE2001;

		public DateTime? ResidenceChange { get; set; }
		public double? ResidencePrevious  { get; set; }
		public double? ResidencePreviousProvince { get; set; }
		public double? ResidencePreviousMunicipality { get; set; }

		public double? ResidenceUsual { get; set; }
		public double? ResidenceUsualProvince { get; set; }
		public double? ResidenceUsualMunicipality { get; set; }

		public Sight? Sight { get; set; }
		public Hearing? Hearing { get; set; }
		public Communication? Communication { get; set; }
		public Walking? Walking { get; set; }
		public Memory? Memory { get; set; }

		public double? P12F_SELF_CARE;
		public bool? DeviceMedicalEyeglasses { get; set; }
		public bool? DeviceMedicalHearingAid { get; set; }
		public bool? DeviceMedicalWalkingStick { get; set; }
		public bool? DeviceMedicalWheelchair { get; set; }
		public bool? DeviceMedicalChronic { get; set; }
		public bool? MotherIsAlive { get; set; }

		public double? P14A_MOTHERPNR;
		public bool? FatherIsAlive { get; set; }

		public double? P15A_FATHERPNR;
		public double? Income { get; set; }
	}
}