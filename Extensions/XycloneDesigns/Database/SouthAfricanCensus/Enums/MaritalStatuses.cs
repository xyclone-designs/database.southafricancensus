using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class MaritalStatusessExtensions
	{
		public static bool FromInt(this MaritalStatuses _, int value, Years? year, out MaritalStatuses? maritalstatuses, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,
				(8, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			maritalstatuses = (value, year) switch
			{
				(1, Years._1996) => MaritalStatuses.NeverMarried,
				(2, Years._1996) => MaritalStatuses.MarriedCivilReligious,
				(3, Years._1996) => MaritalStatuses.MarriedTraditional,
				(4, Years._1996) => MaritalStatuses.LivingTogether,
				(5, Years._1996) => MaritalStatuses.Widowed,
				(6, Years._1996) => MaritalStatuses.DivorcedSeparated,

				(1, _) => MaritalStatuses.NeverMarried,
				(2, _) => MaritalStatuses.MarriedCivilReligious,
				(3, _) => MaritalStatuses.MarriedTraditional,
				(4, _) => MaritalStatuses.LivingTogether,
				(5, _) => MaritalStatuses.Widowed,
				(6, _) => MaritalStatuses.DivorcedSeparated,

				_ => new MaritalStatuses?()
			};

			return notavailable is not null || maritalstatuses is not null;
		}
	}
}