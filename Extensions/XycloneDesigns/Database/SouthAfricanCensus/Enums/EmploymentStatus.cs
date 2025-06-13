using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class EmploymentStatusessExtensions
	{
		public static bool FromInt(this EmploymentStatuses _, int value, Years? year, out EmploymentStatuses? employmentstatuses, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(99, Years._1996) => NotAvailables.DummyHouseholds,
				(98, Years._1996) => NotAvailables.InstitutionOrHostel,

				_ => new NotAvailables?(),
			};

			employmentstatuses = (value, year) switch
			{
				(01, Years._1996) => EmploymentStatuses.Employed,
				(02, Years._1996) => EmploymentStatuses.UnemployedLookingForWork,
				(03, Years._1996) => EmploymentStatuses.NotWorkingNotLookingForWork,
				(04, Years._1996) => EmploymentStatuses.NotWorkingHousewifeHomeMaker,
				(06, Years._1996) => EmploymentStatuses.NotWorkingScholarFullTimeStudent,
				(07, Years._1996) => EmploymentStatuses.NotWorkingPensionerRetiredPerson,
				(08, Years._1996) => EmploymentStatuses.NotWorkingDisabledPerson,
				(09, Years._1996) => EmploymentStatuses.NotWorkingNotWishingToWork,
				(10, Years._1996) => EmploymentStatuses.NotWorkingNoneOfTheAbove,

				(01, _) => EmploymentStatuses.Employed,
				(02, _) => EmploymentStatuses.UnemployedLookingForWork,
				(03, _) => EmploymentStatuses.NotWorkingNotLookingForWork,
				(04, _) => EmploymentStatuses.NotWorkingHousewifeHomeMaker,
				(06, _) => EmploymentStatuses.NotWorkingScholarFullTimeStudent,
				(07, _) => EmploymentStatuses.NotWorkingPensionerRetiredPerson,
				(08, _) => EmploymentStatuses.NotWorkingDisabledPerson,
				(09, _) => EmploymentStatuses.NotWorkingNotWishingToWork,
				(10, _) => EmploymentStatuses.NotWorkingNoneOfTheAbove,

				_ => new EmploymentStatuses?()
			};

			return notavailable is not null || employmentstatuses is not null;
		}
	}
}