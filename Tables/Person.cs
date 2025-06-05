using Database.SouthAfricanCensus.Inputs.CSVs;
using Database.SouthAfricanCensus.Enums;
using Database.SouthAfricanCensus.Models;

using System;
using System.IO;

namespace Database.SouthAfricanCensus.Tables
{
	[SQLite.Table("persons")]
    public class Person : _Table
	{
		[SQLite.Table("persons")]
		public class Individual : Person
		{
			public Individual() { }
			public Individual(Person person)
			{
				Pk = person.Pk;
			}

			[SQLite.AutoIncrement]
			[SQLite.NotNull]
			[SQLite.PrimaryKey]
			[SQLite.Unique]
			public new int Pk { get; set; }
		}

		public QuestionTypes? QuestionType;

		public double? F00_NR;
		public Personhood? Personhood { get; set; }
		public Education? Education { get; set; }
		public Employment? Employment { get; set; }
		public Children? Children { get; set; }

		public double? DERP_BIRTH_REGION;
		public double? DERP_PREVRESPROV;
		public double? DERP_USUALRESPROV;
		public double? DERP_EMPLOY_STATUS;
		public double? DERP_EMPLOY_STATUS_OFFICIAL;
		public double? DERP_EMPLOY_STATUS_EXPANDED;
		public double? DERP_INDUSTRY;
		public double? DERP_OCCUPATION;
		public double? OCCUP_LEV01;
		public double? OCCUP_LEV02;
		public double? OCCUP_LEV03;
		public double? OCCUP_LEV04;
		public double? DERP_Sector;
		public double? DERP_EDUCATIONAL_LEVEL;
		public double? DERP_BIRTHS_12MONTHS;

		public double? P_GEOTYPE;
		public double? P_PROVINCE;
		public double? P_DISTRICT;
		public double? P_MUNIC;
		public double? PERSON_10PER_WGT;

		private static Personhood FromCSVPersonhood(CSVRow2011Person csvrow2011person) 
		{
			return new Personhood
			{
				Age = csvrow2011person.F02_AGE,
				Sex = csvrow2011person.F03_SEX,
				DateOfBirth = new DateTime(csvrow2011person.P01_DAY, csvrow2011person.P01_MONTH, csvrow2011person.P01_YEAR),
				Languages = [csvrow2011person.P06A_LANGUAGE, csvrow2011person.P06B_LANGUAGE],

				P02_RELATION = csvrow2011person.P02_RELATION,
				MaritalStatus = csvrow2011person.P03_MARITAL_ST,
				P04_SPN = csvrow2011person.P04_SPN,
				PopulationGroup = csvrow2011person.P05_POP_GROUP,
				ProvinceOfBirth = csvrow2011person.P07_PROV_POB,
				CountryOfBirth = csvrow2011person.P08_COUNTRYOFBIRTH,
				P08A_YEARMOVED = csvrow2011person.P08A_YEARMOVED,
				Citizenship = csvrow2011person.P09_CITIZENSHIP,
				ResidenceUsual = csvrow2011person.P10_USUALRES,
				ResidenceUsualProvince = csvrow2011person.P10A_USUALRESPROV,
				ResidenceUsualMunicipality = csvrow2011person.P10B_USUALRESMUNIC,
				P11_SINCE2001 = csvrow2011person.P11_SINCE2001,
				P11A_RESMONTHMOVED = csvrow2011person.P11A_RESMONTHMOVED,
				P11A_RESYEARMOVED = csvrow2011person.P11A_RESYEARMOVED,
				ResidencePreviousProvince = csvrow2011person.P11B_PREVRESPROV,
				ResidencePreviousMunicipality = csvrow2011person.P11C_PREVRESMUNIC,
				Sight = csvrow2011person.P12A_SEEING,
				Hearing = csvrow2011person.P12B_HEARING,
				Communication = csvrow2011person.P12C_COMMUNICATION,
				Walking = csvrow2011person.P12D_WALKING,
				Memory = csvrow2011person.P12E_REMEMBERING,
				P12F_SELF_CARE = csvrow2011person.P12F_SELF_CARE,
				DeviceMedicalEyeglasses = csvrow2011person.P13A_DEVMEDEYEGLAS,
				DeviceMedicalHearingAid = csvrow2011person.P13B_DEVMEDHEARINGAID,
				DeviceMedicalWalkingStick = csvrow2011person.P13C_DEVMEWALKINGSTICK,
				DeviceMedicalWheelchair = csvrow2011person.P13D_DEVMEDWHEELCHAIR,
				DeviceMedicalChronic = csvrow2011person.P13E_DEVMEDCHRONIC,
				MotherIsAlive = csvrow2011person.P14_MOTHERALIVE,
				P14A_MOTHERPNR = csvrow2011person.P14A_MOTHERPNR,
				FatherIsAlive = csvrow2011person.P15_FATHERALIVE,
				P15A_FATHERPNR = csvrow2011person.P15A_FATHERPNR,
				Income = csvrow2011person.P16_INCOME,
			};
		}
		private static Education FromCSVEducation(CSVRow2011Person csvrow2011person) 
		{
			return new Education
			{
				Attended = csvrow2011person.P17_SCHOOLATTEND,
				Institution = csvrow2011person.P18_EDUINST,
				IsPrivate = csvrow2011person.P19_EDUPUBPRIV,
				IsPublic = csvrow2011person.P19_EDUPUBPRIV,
				Level = csvrow2011person.P20_EDULEVEL,
				Field = csvrow2011person.P21_EDUFIELD,
				Literacy = csvrow2011person.P22A_EDULITERACY,
				Literacy = csvrow2011person.P22B_EDULITERACY,
				Literacy = csvrow2011person.P22C_EDULITERACY,
				Literacy = csvrow2011person.P22D_EDULITERACY,
				Literacy = csvrow2011person.P22E_EDULITERACY,
				Literacy = csvrow2011person.P22F_EDULITERACY,
			};
		}
		private static Employment FromCSVEmployment(CSVRow2011Person csvrow2011person) 
		{
			return new Employment
			{
				EmploymentStatuses = [csvrow2011person.P23A_EMPLOYMENTSTATUS, csvrow2011person.P23B_EMPLOYMENTSTATUS, csvrow2011person.P23C_EMPLOYMENTSTATUS],
				P24_TEMPWORKABSENCE = csvrow2011person.P24_TEMPWORKABSENCE,
				P25_UNEMPLOYMENT = csvrow2011person.P25_UNEMPLOYMENT,
				P26_UNEMPLOYMENT = csvrow2011person.P26_UNEMPLOYMENT,
				P27_REASONSNOTWORKING = csvrow2011person.P27_REASONSNOTWORKING,
				P28_WORKAVAILABILITY = csvrow2011person.P28_WORKAVAILABILITY,
				Industries = csvrow2011person.P29A_INDUSTRY,
				Occupation = csvrow2011person.P30A_OCCUPATION,
				Sector = csvrow2011person.P31_SECTOR,
			};
		}
		private static Children FromCSVChildren(CSVRow2011Person csvrow2011person) 
		{
			return new Children
			{
				Any = csvrow2011person.P32_CHILDEVERBORN is not 0,
				FirstChildBirthAge = csvrow2011person.P33_AGEFIRSTBIRTH,
				NumberOf = csvrow2011person.P34_CHILDBORNTOT,
				NumberOfBoys = csvrow2011person.P34_CHILDBORNBOYS,
				NumberOfGirls = csvrow2011person.P34_CHILDBORNGIRLS,
				LastChildSex = csvrow2011person.P39_LASTCHILDSEX,
				LastChildIsAlive = csvrow2011person.P40_LASTCHILDALIVE,
				LastChildDateOfBirth = new DateTime(csvrow2011person.P38_LASTCHILDDAY, csvrow2011person.P38_LASTCHILDMO, csvrow2011person.P38_LASTCHILDYR),
				LastChildDateOfDeath = new DateTime(csvrow2011person.P41_DATEOFDEATHOFLASTCHILDDAZ, csvrow2011person.P41_DATEOFDEATHOFLASTCHILDMONTJ, csvrow2011person.P41_DATEOFDEATHOFLASTCHILDYEAT),
			};
		}

		public static Person FromCSV(CSVRow2011Person csvrow2011person)
		{
			return new Person
			{
				Personhood = FromCSVPersonhood(csvrow2011person),
				Education = FromCSVEducation(csvrow2011person),
				Employment = FromCSVEmployment(csvrow2011person),
				Children = FromCSVChildren(csvrow2011person),
			};
		}
	}

	public static partial class StreamWriterExtensions
	{
		public static void Log(this StreamWriter streamwriter, Person person)
		{
			streamwriter.Log(person as _Table);
		}
		public static void LogError(this StreamWriter streamwriter, Person person)
		{
			streamwriter.LogError(person as _Table);
		}
	}
}