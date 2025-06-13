using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class UsualResidencesExtensions
	{
		public static bool FromInt(this UsualResidence _, int value, Years? year, out UsualResidence? usualresidence, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,
				(8, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			usualresidence = (value, year) switch
			{
				(1, Years._1996) => UsualResidence.UsualResident,
				(2, Years._1996) => UsualResidence.Visitor,
				(3, Years._1996) => UsualResidence.NoUsualAddress,

				(1, _) => UsualResidence.UsualResident,
				(2, _) => UsualResidence.Visitor,
				(3, _) => UsualResidence.NoUsualAddress,

				_ => new UsualResidence?()
			};

			return notavailable is not null || usualresidence is not null;
		}
	}
}