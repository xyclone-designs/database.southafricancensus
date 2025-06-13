using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class RelationssExtensions
	{
		public static bool FromInt(this Relations _, int value, Years? year, out Relations? relations, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(99, Years._1996) => NotAvailables.Unspecified,
				(98, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			relations = (value, year) switch
			{
				(1, Years._1996) => Relations.HeadOfHousehold,
				(2, Years._1996) => Relations.HusbandWifePartner,
				(3, Years._1996) => Relations.SonDaughter,
				(4, Years._1996) => Relations.BrotherSister,
				(5, Years._1996) => Relations.FatherMother,
				(6, Years._1996) => Relations.Grandparent,
				(7, Years._1996) => Relations.Grandchild,
				(8, Years._1996) => Relations.OtherRelative,
				(9, Years._1996) => Relations.NonRelatedPerson,

				(1, _) => Relations.HeadOfHousehold,
				(2, _) => Relations.HusbandWifePartner,
				(3, _) => Relations.SonDaughter,
				(4, _) => Relations.BrotherSister,
				(5, _) => Relations.FatherMother,
				(6, _) => Relations.Grandparent,
				(7, _) => Relations.Grandchild,
				(8, _) => Relations.OtherRelative,
				(9, _) => Relations.NonRelatedPerson,

				_ => new Relations?()
			};

			return notavailable is not null || relations is not null;
		}
	}
}