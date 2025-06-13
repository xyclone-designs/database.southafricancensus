using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class SexesExtensions
	{
		public static bool FromInt(this Sexes _, int value, Years? year, out Sexes? sexes, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,
				(8, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			sexes = (value, year) switch
			{
				(1, _) => Sexes.Male,
				(2, _) => Sexes.Female,

				_ => new Sexes?()
			};

			return notavailable is not null || sexes is not null;
		}
	}
}