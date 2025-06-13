using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class FacilitiesToiletsExtensions
	{
		public static bool FromInt(this FacilitiesToilet _, int? value, Years? year, out FacilitiesToilet? facilitiestoilet, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.DummyHouseholds,

				_ => new NotAvailables?(),
			};

			facilitiestoilet = (value, year) switch
			{
				(1, Years._1996) => FacilitiesToilet.FlushOrChemicalToilet,
				(2, Years._1996) => FacilitiesToilet.PitLatrine,
				(3, Years._1996) => FacilitiesToilet.BucketLatrine,
				(4, Years._1996) => FacilitiesToilet.NoneOfTheAbove,

				(1, _) => FacilitiesToilet.FlushOrChemicalToilet,
				(2, _) => FacilitiesToilet.PitLatrine,
				(3, _) => FacilitiesToilet.BucketLatrine,
				(4, _) => FacilitiesToilet.NoneOfTheAbove,

				_ => new FacilitiesToilet?()
			};

			return notavailable is not null || facilitiestoilet is not null;
		}
	}
}