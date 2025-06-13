using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class StatusStudyingsExtensions
	{
		public static bool FromInt(this StatusStudying _, int value, Years? year, out StatusStudying? statusstudying, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,
				(7, Years._1996) => NotAvailables.AgedLessThan05,
				(8, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			statusstudying = (value, year) switch
			{
				(1, Years._1996) => StatusStudying.FullTime,
				(2, Years._1996) => StatusStudying.PartTime,
				(3, Years._1996) => StatusStudying.No,

				(1, _) => StatusStudying.FullTime,
				(2, _) => StatusStudying.PartTime,
				(3, _) => StatusStudying.No,
				
				_ => new StatusStudying?()
			};

			return notavailable is not null || statusstudying is not null;
		}
	}
}