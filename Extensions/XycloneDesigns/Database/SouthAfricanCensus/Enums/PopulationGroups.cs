using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class PopulationGroupssExtensions
	{
		public static bool FromInt(this PopulationGroups _, int value, Years? year, out PopulationGroups? populationgroups, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(9, Years._1996) => NotAvailables.Unspecified,

				_ => new NotAvailables?(),
			};

			populationgroups = (value, year) switch
			{
				(1, Years._1996) => PopulationGroups.AfricanBlack,
				(2, Years._1996) => PopulationGroups.Coloured,
				(3, Years._1996) => PopulationGroups.IndianAsian,
				(4, Years._1996) => PopulationGroups.White,

				(1, _) => PopulationGroups.AfricanBlack,
				(2, _) => PopulationGroups.Coloured,
				(3, _) => PopulationGroups.IndianAsian,
				(4, _) => PopulationGroups.White,

				_ => new PopulationGroups?()
			};

			return notavailable is not null || populationgroups is not null;
		}
	}
}