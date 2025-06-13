using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class CitizenshipStatussExtensions
	{
		public static bool FromInt(this CitizenshipStatus _, int value, Years? year, out CitizenshipStatus? citizenshipstatus, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,
				(8, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			citizenshipstatus = (value, year) switch
			{
				(1, Years._1996) => CitizenshipStatus.SouthAfricaOnly,
				(2, Years._1996) => CitizenshipStatus.SouthAfricaAndAnotherCountry,
				(3, Years._1996) => CitizenshipStatus.AnotherCountryOnly,

				(1, _) => CitizenshipStatus.SouthAfricaOnly,
				(2, _) => CitizenshipStatus.SouthAfricaAndAnotherCountry,
				(3, _) => CitizenshipStatus.AnotherCountryOnly,

				_ => new CitizenshipStatus?()
			};

			return notavailable is not null || citizenshipstatus is not null;
		}
	}
}