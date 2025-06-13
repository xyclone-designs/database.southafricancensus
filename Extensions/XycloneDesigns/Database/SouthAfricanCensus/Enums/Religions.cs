using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class ReligionssExtensions
	{
		public static bool FromInt(this Religions _, int value, Years? year, out Religions? religions, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(99, Years._1996) => NotAvailables.Unspecified,
				(98, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			religions = (value, year) switch
			{
				(01, Years._1996) => Religions.DutchReformedChurches,
				(02, Years._1996) => Religions.ReformedChurches,
				(03, Years._1996) => Religions.NederduitsHervormdeKerk,
				(04, Years._1996) => Religions.AnglicanChurch,
				(05, Years._1996) => Religions.ChurchOfEnglandInSA,
				(06, Years._1996) => Religions.InternationalFellowshipOfChristianChurches,
				(07, Years._1996) => Religions.MethodistChurchOfSA,
				(08, Years._1996) => Religions.PresbyterianChurches,
				(09, Years._1996) => Religions.UnitedCongregationalChurchOfSA,
				(10, Years._1996) => Religions.LutheranChurchOfSouthernAfrica,
				(11, Years._1996) => Religions.RomanCatholicChurch,
				(12, Years._1996) => Religions.ApostolicFaithMissionOfSA,
				(13, Years._1996) => Religions.OtherApostolicChurches,
				(14, Years._1996) => Religions.BaptistChurchesOfSouthernAfrica,
				(15, Years._1996) => Religions.PinksterProtestanteKerk,
				(16, Years._1996) => Religions.AfrikaanseProtestanteKerk,
				(17, Years._1996) => Religions.FullGospelChurchOfGodInSouthernAfrica,
				(18, Years._1996) => Religions.GreekOrthodox,
				(19, Years._1996) => Religions.ChurchOfChristOfLatterDaySaints,
				(20, Years._1996) => Religions.OtherPentecostalChurches,
				(21, Years._1996) => Religions.SalvationArmyUnitedChurch,
				(22, Years._1996) => Religions.SeventhDayAdventistChurch,
				(23, Years._1996) => Religions.NewApostolicChurch,
				(24, Years._1996) => Religions.AssembliesOfGodOfSA,
				(25, Years._1996) => Religions.StEngenasZionChristianChurch,
				(26, Years._1996) => Religions.ZionChristianChurch,
				(27, Years._1996) => Religions.BandlaLamaNazaretha,
				(28, Years._1996) => Religions.AfricanMethodistEpiscopalChurch,
				(29, Years._1996) => Religions.StJohnsApostolicChurch,
				(30, Years._1996) => Religions.InternationalPentecostChurch,
				(31, Years._1996) => Religions.OtherAfricanIndependentChurches,
				(32, Years._1996) => Religions.OtherChristianChurches,
				(33, Years._1996) => Religions.AfricanTraditionalBelief,
				(34, Years._1996) => Religions.Judaism,
				(35, Years._1996) => Religions.Buddhism,
				(36, Years._1996) => Religions.Taoist,
				(37, Years._1996) => Religions.Confucian,
				(38, Years._1996) => Religions.Hinduism,
				(39, Years._1996) => Religions.Islam,
				(40, Years._1996) => Religions.Bahais,
				(41, Years._1996) => Religions.NewAge,
				(42, Years._1996) => Religions.JehovahsWitnesses,
				(43, Years._1996) => Religions.OtherNonChristianReligions,
				(44, Years._1996) => Religions.OtherMethodistChurches,
				(45, Years._1996) => Religions.OtherPresbyterianChurches,
				(46, Years._1996) => Religions.OtherCongregationalChurches,
				(47, Years._1996) => Religions.OtherLutheranChurches,
				(48, Years._1996) => Religions.OtherCatholicChurches,
				(49, Years._1996) => Religions.OtherBaptistChurches,
				(50, Years._1996) => Religions.OtherPentecostalChurches,
				(51, Years._1996) => Religions.OtherOrthodoxChurches,
				(52, Years._1996) => Religions.OtherSeventhDayAdventistChurches,
				(53, Years._1996) => Religions.OtherAfricanApostolicChurches,
				(54, Years._1996) => Religions.OtherAssemblies,
				(55, Years._1996) => Religions.OtherZionistChurches,
				(57, Years._1996) => Religions.ChristianScientist,
				(58, Years._1996) => Religions.ChristianCentres,
				(59, Years._1996) => Religions.EthiopianTypeChurches,
				(60, Years._1996) => Religions.EthnicChurches,
				(61, Years._1996) => Religions.OtherEvangelicalChurches,
				(62, Years._1996) => Religions.OtherCharismaticChurches,
				(63, Years._1996) => Religions.NoReligion,
				(64, Years._1996) => Religions.Refused,
				(65, Years._1996) => Religions.Other,

				_ => new Religions?()
			};

			return notavailable is not null || religions is not null;
		}
	}
}