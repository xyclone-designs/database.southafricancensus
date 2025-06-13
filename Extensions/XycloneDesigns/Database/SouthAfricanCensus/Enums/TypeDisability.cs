using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class TypeDisabilitysExtensions
	{
		public static bool FromInt(this TypeDisability _, int value, Years? year, out TypeDisability? typedisability, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,
				(8, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			typedisability = (value, year) switch
			{
				(1, Years._1996) => TypeDisability.Sight,
				(2, Years._1996) => TypeDisability.Hearing,
				(3, Years._1996) => TypeDisability.Physical,
				(4, Years._1996) => TypeDisability.Mental,
				(5, Years._1996) => TypeDisability.Multiple,
				(6, Years._1996) => TypeDisability.TypeOfDisabilityNotSpecified,
				(7, Years._1996) => TypeDisability.NoDisability,

				(1, _) => TypeDisability.Sight,
				(2, _) => TypeDisability.Hearing,
				(3, _) => TypeDisability.Physical,
				(4, _) => TypeDisability.Mental,
				(5, _) => TypeDisability.Multiple,
				(6, _) => TypeDisability.TypeOfDisabilityNotSpecified,
				(7, _) => TypeDisability.NoDisability,

				_ => new TypeDisability?()
			};

			return notavailable is not null || typedisability is not null;
		}
	}
}