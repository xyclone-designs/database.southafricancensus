using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class SourceOfWatersExtensions
	{
		public static bool FromInt(this SourceOfWater _, int value, Years? year, out SourceOfWater? sourceofwater, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.DummyHouseholds,

				_ => new NotAvailables?(),
			};

			sourceofwater = (value, year) switch
			{
				(1, Years._1996) => SourceOfWater.PipedWaterInDwelling,
				(2, Years._1996) => SourceOfWater.PipedWaterOnSite,
				(3, Years._1996) => SourceOfWater.PublicTap,
				(4, Years._1996) => SourceOfWater.WaterCarrierTanker,
				(5, Years._1996) => SourceOfWater.BoreholeRainWaterTankWell,
				(6, Years._1996) => SourceOfWater.DamRiverStreamSpring,
				(7, Years._1996) => SourceOfWater.Other,

				(1, _) => SourceOfWater.PipedWaterInDwelling,
				(2, _) => SourceOfWater.PipedWaterOnSite,
				(3, _) => SourceOfWater.PublicTap,
				(4, _) => SourceOfWater.WaterCarrierTanker,
				(5, _) => SourceOfWater.BoreholeRainWaterTankWell,
				(6, _) => SourceOfWater.DamRiverStreamSpring,
				(7, _) => SourceOfWater.Other,

				_ => new SourceOfWater?()
			};

			return notavailable is not null || sourceofwater is not null;
		}
	}
}