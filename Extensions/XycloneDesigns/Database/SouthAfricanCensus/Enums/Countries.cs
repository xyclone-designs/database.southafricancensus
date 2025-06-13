using System;

using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class CountriessExtensions
	{
		public static bool FromInt(this Countries _, int value, Years? year, out Countries? countries, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(99, Years._1996) => NotAvailables.No,
				(98, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			countries = (value, year) switch
			{
				(01, Years._1996) => Countries.SouthAfrica,
				(02, Years._1996) => Countries.Namibia,
				(03, Years._1996) => Countries.Swaziland,
				(04, Years._1996) => Countries.Botswana,
				(05, Years._1996) => Countries.Lesotho,
				(06, Years._1996) => Countries.Angola,
				(07, Years._1996) => Countries.Congo,
				(08, Years._1996) => Countries.Zaire,
				(09, Years._1996) => Countries.Kenya,
				(10, Years._1996) => Countries.Malawi,
				(11, Years._1996) => Countries.Mauritius,
				(12, Years._1996) => Countries.Mozambique,
				(13, Years._1996) => Countries.Reunion,
				(14, Years._1996) => Countries.Seychelles,
				(15, Years._1996) => Countries.Tanzania,
				(17, Years._1996) => Countries.Zambia,
				(18, Years._1996) => Countries.Zimbabwe,
				(19, Years._1996) => Countries.Madeira,
				(20, Years._1996) => Countries.Argentina,
				(21, Years._1996) => Countries.Algeria,
				(22, Years._1996) => Countries.Egypt,
				(23, Years._1996) => Countries.RestofAfrica,
				(24, Years._1996) => Countries.UnitedStatesOfAmerica,
				(25, Years._1996) => Countries.Canada,
				(26, Years._1996) => Countries.Mexico,
				(27, Years._1996) => Countries.Cuba,
				(29, Years._1996) => Countries.Brazil,
				(30, Years._1996) => Countries.Chile,
				(31, Years._1996) => Countries.Colombia,
				(32, Years._1996) => Countries.RestOfAmericas,
				(33, Years._1996) => Countries.Cyprus,
				(34, Years._1996) => Countries.Israel,
				(35, Years._1996) => Countries.Turkey,
				(36, Years._1996) => Countries.India,
				(37, Years._1996) => Countries.Pakistan,
				(39, Years._1996) => Countries.Philippines,
				(40, Years._1996) => Countries.Singapore,
				(41, Years._1996) => Countries.Thailand,
				(42, Years._1996) => Countries.China,
				(43, Years._1996) => Countries.HongKong,
				(44, Years._1996) => Countries.Japan,
				(47, Years._1996) => Countries.Taiwan,
				(48, Years._1996) => Countries.RestOfAsia,
				(49, Years._1996) => Countries.Denmark,
				(50, Years._1996) => Countries.Finland,
				(54, Years._1996) => Countries.EnglandScotlandWales,
				(55, Years._1996) => Countries.Austria,
				(56, Years._1996) => Countries.Belgium,
				(57, Years._1996) => Countries.France,
				(58, Years._1996) => Countries.Germany,
				(59, Years._1996) => Countries.Netherlands,
				(60, Years._1996) => Countries.Switzerland,
				(62, Years._1996) => Countries.Hungary,
				(63, Years._1996) => Countries.Poland,
				(64, Years._1996) => Countries.RussianFederation,
				(67, Years._1996) => Countries.Greece,
				(68, Years._1996) => Countries.Italy,
				(69, Years._1996) => Countries.Portugal,
				(70, Years._1996) => Countries.Spain,
				(71, Years._1996) => Countries.Yugoslavia,
				(72, Years._1996) => Countries.RestOfEurope,
				(73, Years._1996) => Countries.AustraliaNewZealand,
				(75, Years._1996) => Countries.RestofOceania,
				(00, Years._1996) => Countries.Other,

				_ => new Countries?()
			};

			return notavailable is not null || countries is not null;
		}
		public static string AsString(this Countries province)
		{
			return province switch
			{
				Countries.SouthAfrica => "South Africa",
				Countries.Namibia => "Namibia",
				Countries.Swaziland => "Swaziland",
				Countries.Botswana => "Botswana",
				Countries.Lesotho => "Lesotho",
				Countries.Angola => "Angola",
				Countries.Congo => "Congo",
				Countries.Zaire => "Zaire",
				Countries.Kenya => "Kenya",
				Countries.Malawi => "Malawi",
				Countries.Mauritius => "Mauritius",
				Countries.Mozambique => "Mozambique",
				Countries.Reunion => "Reunion",
				Countries.Seychelles => "Seychelles",
				Countries.Tanzania => "Tanzania",
				Countries.Zambia => "Zambia",
				Countries.Zimbabwe => "Zimbabwe",
				Countries.Madeira => "Madeira",
				Countries.Argentina => "Argentina",
				Countries.Algeria => "Algeria",
				Countries.Egypt => "Egypt",
				Countries.RestofAfrica => "Rest Of Africa",
				Countries.UnitedStatesOfAmerica => "UnitedS tates Of America",
				Countries.Canada => "Canada",
				Countries.Mexico => "Mexico",
				Countries.Cuba => "Cuba",
				Countries.Brazil => "Brazil",
				Countries.Chile => "Chile",
				Countries.Colombia => "Colombia",
				Countries.RestOfAmericas => "Rest Of Americas",
				Countries.Cyprus => "Cyprus",
				Countries.Israel => "Israel",
				Countries.Turkey => "Turkey",
				Countries.India => "India",
				Countries.Pakistan => "Pakistan",
				Countries.Philippines => "Philippines",
				Countries.Singapore => "Singapore",
				Countries.Thailand => "Thailand",
				Countries.China => "China",
				Countries.HongKong => "Hong Kong",
				Countries.Japan => "Japan",
				Countries.Taiwan => "Taiwan",
				Countries.RestOfAsia => "Rest Of Asia",
				Countries.Denmark => "Denmark",
				Countries.Finland => "Finland",
				Countries.EnglandScotlandWales => "England, Scotland & Wales",
				Countries.Austria => "Austria",
				Countries.Belgium => "Belgium",
				Countries.France => "France",
				Countries.Germany => "Germany",
				Countries.Netherlands => "Netherlands",
				Countries.Switzerland => "Switzerland",
				Countries.Hungary => "Hungary",
				Countries.Poland => "Poland",
				Countries.RussianFederation => "Russian Federation",
				Countries.Greece => "Greece",
				Countries.Italy => "Italy",
				Countries.Portugal => "Portugal",
				Countries.Spain => "Spain",
				Countries.Yugoslavia => "Yugoslavia",
				Countries.RestOfEurope => "Rest of Europe",
				Countries.AustraliaNewZealand => "Australia and New Zealand",
				Countries.RestofOceania => "Rest of Oceania",
				Countries.Other => "Other",

				_ => throw new ArgumentException(string.Format("Country for value '{0}' not found", province))
			};
		}
	}
}