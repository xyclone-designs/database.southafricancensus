using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class TypeQuestionnaireHouseholdssExtensions
	{
		public static bool From(this TypeQuestionnaireHouseholds _, string value, Years? year, out TypeQuestionnaireHouseholds? typequestionnairehouseholds, out NotAvailables? notavailable)
		{
			notavailable = null;

			typequestionnairehouseholds = (value, year) switch
			{
				("H", Years._1996) => TypeQuestionnaireHouseholds.Household,
				("I", Years._1996) => TypeQuestionnaireHouseholds.Hostel,
				("S", Years._1996) => TypeQuestionnaireHouseholds.Institution,
				("D", Years._1996) => TypeQuestionnaireHouseholds.DummyRecords,

				("H", _) => TypeQuestionnaireHouseholds.Household,
				("I", _) => TypeQuestionnaireHouseholds.Hostel,
				("S", _) => TypeQuestionnaireHouseholds.Institution,
				("D", _) => TypeQuestionnaireHouseholds.DummyRecords,

				_ => new TypeQuestionnaireHouseholds?()
			};

			return notavailable is not null || typequestionnairehouseholds is not null;
		}
	}
}