using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class FacilitiesRefuseDisposalsExtensions
	{
		public static bool FromInt(this FacilitiesRefuseDisposal _, int value, Years? year, out FacilitiesRefuseDisposal? facilitiesrefusedisposal, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.DummyHouseholds,

				_ => new NotAvailables?(),
			};

			facilitiesrefusedisposal = (value, year) switch
			{
				(1, Years._1996) => FacilitiesRefuseDisposal.RemovedByLocalAuthorityAtLeastWeekly,
				(2, Years._1996) => FacilitiesRefuseDisposal.RemovedByLocalAuthorityLessOften,
				(3, Years._1996) => FacilitiesRefuseDisposal.CommunalRefuseDump,
				(4, Years._1996) => FacilitiesRefuseDisposal.OwnRefuseDump,
				(5, Years._1996) => FacilitiesRefuseDisposal.NoRubbishDisposal,
				(6, Years._1996) => FacilitiesRefuseDisposal.Other,

				(1, _) => FacilitiesRefuseDisposal.RemovedByLocalAuthorityAtLeastWeekly,
				(2, _) => FacilitiesRefuseDisposal.RemovedByLocalAuthorityLessOften,
				(3, _) => FacilitiesRefuseDisposal.CommunalRefuseDump,
				(4, _) => FacilitiesRefuseDisposal.OwnRefuseDump,
				(5, _) => FacilitiesRefuseDisposal.NoRubbishDisposal,
				(6, _) => FacilitiesRefuseDisposal.Other,
				
				_ => new FacilitiesRefuseDisposal?()
			};

			return notavailable is not null || facilitiesrefusedisposal is not null;
		}
	}
}