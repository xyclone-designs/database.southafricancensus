using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class ImputationFlagsExtensions
	{
		public static bool FromInt(this ImputationFlags _, int value, Years? year, out ImputationFlags? imputationflags, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				_ => new NotAvailables?(),
			};

			imputationflags = (value, year) switch
			{
				(0, Years._2001) => ImputationFlags.NoImputation,
				(1, Years._2001) => ImputationFlags.LogicalImputationFromBlank,
				(2, Years._2001) => ImputationFlags.LogicalImputationNonBlank,
				(3, Years._2001) => ImputationFlags.HotDeckImputationFromBlank,
				(4, Years._2001) => ImputationFlags.HotDeckImputationNonBlank,

				(0, _) => ImputationFlags.NoImputation,
				(1, _) => ImputationFlags.LogicalImputationFromBlank,
				(2, _) => ImputationFlags.LogicalImputationNonBlank,
				(3, _) => ImputationFlags.HotDeckImputationFromBlank,
				(4, _) => ImputationFlags.HotDeckImputationNonBlank,

				_ => new ImputationFlags?()
			};

			return notavailable is not null || imputationflags is not null;
		}
	}
}