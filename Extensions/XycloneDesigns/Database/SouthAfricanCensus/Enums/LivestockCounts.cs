using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class LivestockCountsExtensions
	{
		public static bool FromInt(this LivestockCounts _, int value, Years? year, out LivestockCounts? livestockcounts, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._2011) => NotAvailables.Unspecified,

				_ => new NotAvailables?(),
			};

			livestockcounts = (value, year) switch
			{
				(1, Years._2011) => LivestockCounts._000,
				(2, Years._2011) => LivestockCounts._001To010,
				(3, Years._2011) => LivestockCounts._010To100,
				(4, Years._2011) => LivestockCounts._100OrMore,

				(1, _) => LivestockCounts._000,
				(2, _) => LivestockCounts._001To010,
				(3, _) => LivestockCounts._010To100,
				(4, _) => LivestockCounts._100OrMore,

				_ => new LivestockCounts?()
			};

			return notavailable is not null || livestockcounts is not null;
		}
	}
}