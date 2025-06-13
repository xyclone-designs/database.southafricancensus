using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class TypeDwellingsExtensions
	{
		public static bool FromInt(this TypeDwelling _, int value, Years? year, out TypeDwelling? typedwelling, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(99, Years._1996) => NotAvailables.DummyHouseholds,
				(98, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			typedwelling = (value, year) switch
			{
				(01, Years._1996) => TypeDwelling.HouseOrBrickStructureOnSeparateStand,
				(02, Years._1996) => TypeDwelling.TraditionalDwelling,
				(03, Years._1996) => TypeDwelling.FlatInBlockOfFlats,
				(04, Years._1996) => TypeDwelling.TownClusterSemiDetachedHouse,
				(05, Years._1996) => TypeDwelling.UnitInRetirementVillage,
				(06, Years._1996) => TypeDwelling.HouseFlatRoomInBackyard,
				(07, Years._1996) => TypeDwelling.InformalDwellingShackInBackyard,
				(08, Years._1996) => TypeDwelling.InformalDwellingShackElsewhere,
				(09, Years._1996) => TypeDwelling.RoomFlatletOnSharedProperty,
				(10, Years._1996) => TypeDwelling.CaravanTent,
				(11, Years._1996) => TypeDwelling.NoneHomeless,
				(12, Years._1996) => TypeDwelling.Other,

				(01, _) => TypeDwelling.HouseOrBrickStructureOnSeparateStand,
				(02, _) => TypeDwelling.TraditionalDwelling,
				(03, _) => TypeDwelling.FlatInBlockOfFlats,
				(04, _) => TypeDwelling.TownClusterSemiDetachedHouse,
				(05, _) => TypeDwelling.UnitInRetirementVillage,
				(06, _) => TypeDwelling.HouseFlatRoomInBackyard,
				(07, _) => TypeDwelling.InformalDwellingShackInBackyard,
				(08, _) => TypeDwelling.InformalDwellingShackElsewhere,
				(09, _) => TypeDwelling.RoomFlatletOnSharedProperty,
				(10, _) => TypeDwelling.CaravanTent,
				(11, _) => TypeDwelling.NoneHomeless,
				(12, _) => TypeDwelling.Other,

				_ => new TypeDwelling?()
			};

			return notavailable is not null || typedwelling is not null;
		}
	}
}