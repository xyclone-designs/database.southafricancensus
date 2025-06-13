using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class StatusWorksExtensions
	{
		public static bool FromInt(this StatusWork _, int value, Years? year, out StatusWork? statuswork, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,
				(7, Years._1996) => NotAvailables.AgedLessThan15OrNotEmployed,
				(8, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			statuswork = (value, year) switch
			{
				(1, Years._1996) => StatusWork.SelfEmployed,
				(2, Years._1996) => StatusWork.Employer,
				(3, Years._1996) => StatusWork.Employee,
				(4, Years._1996) => StatusWork.WorksInFamilyBusiness,
				
				(1, _) => StatusWork.SelfEmployed,
				(2, _) => StatusWork.Employer,
				(3, _) => StatusWork.Employee,
				(4, _) => StatusWork.WorksInFamilyBusiness,

				_ => new StatusWork?()
			};

			return notavailable is not null || statuswork is not null;
		}
	}
}