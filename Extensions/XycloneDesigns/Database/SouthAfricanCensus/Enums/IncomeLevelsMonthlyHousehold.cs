using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class IncomeLevelsMonthlyHouseholdsExtensions
	{
		public static bool FromInt(this IncomeLevelsMonthlyHousehold _, int value, Years? year, out IncomeLevelsMonthlyHousehold? incomelevelsmonthlyhousehold, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(99, Years._1996) => NotAvailables.DummyHouseholds,
				(98, Years._1996) => NotAvailables.InstitutionOrHostel,

				_ => new NotAvailables?(),
			};

			incomelevelsmonthlyhousehold = (value, year) switch
			{
				(1, Years._1996) => IncomeLevelsMonthlyHousehold.None,
				(2, Years._1996) => IncomeLevelsMonthlyHousehold.R1_R2400,
				(3, Years._1996) => IncomeLevelsMonthlyHousehold.R2401_R6000,
				(4, Years._1996) => IncomeLevelsMonthlyHousehold.R6001_R12000,
				(5, Years._1996) => IncomeLevelsMonthlyHousehold.R12001_R18000,
				(6, Years._1996) => IncomeLevelsMonthlyHousehold.R18001_R30000,
				(7, Years._1996) => IncomeLevelsMonthlyHousehold.R30001_R42000,
				(8, Years._1996) => IncomeLevelsMonthlyHousehold.R42001_R54000,
				(9, Years._1996) => IncomeLevelsMonthlyHousehold.R54001_R72000,
				(10, Years._1996) => IncomeLevelsMonthlyHousehold.R72001_R96000,
				(11, Years._1996) => IncomeLevelsMonthlyHousehold.R96001_R132000,
				(12, Years._1996) => IncomeLevelsMonthlyHousehold.R132001_R192000,
				(13, Years._1996) => IncomeLevelsMonthlyHousehold.R192001_R360000,
				(14, Years._1996) => IncomeLevelsMonthlyHousehold.R360001_OrMore,
				
				(1, _) => IncomeLevelsMonthlyHousehold.None,
				(2, _) => IncomeLevelsMonthlyHousehold.R1_R2400,
				(3, _) => IncomeLevelsMonthlyHousehold.R2401_R6000,
				(4, _) => IncomeLevelsMonthlyHousehold.R6001_R12000,
				(5, _) => IncomeLevelsMonthlyHousehold.R12001_R18000,
				(6, _) => IncomeLevelsMonthlyHousehold.R18001_R30000,
				(7, _) => IncomeLevelsMonthlyHousehold.R30001_R42000,
				(8, _) => IncomeLevelsMonthlyHousehold.R42001_R54000,
				(9, _) => IncomeLevelsMonthlyHousehold.R54001_R72000,
				(10, _) => IncomeLevelsMonthlyHousehold.R72001_R96000,
				(11, _) => IncomeLevelsMonthlyHousehold.R96001_R132000,
				(12, _) => IncomeLevelsMonthlyHousehold.R132001_R192000,
				(13, _) => IncomeLevelsMonthlyHousehold.R192001_R360000,
				(14, _) => IncomeLevelsMonthlyHousehold.R360001_OrMore,

				_ => new IncomeLevelsMonthlyHousehold?()
			};

			return notavailable is not null || incomelevelsmonthlyhousehold is not null;
		}
	}
}