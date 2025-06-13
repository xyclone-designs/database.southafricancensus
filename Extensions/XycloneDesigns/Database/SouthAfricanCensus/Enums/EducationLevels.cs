using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class EducationLevelsExtensions
	{
		public static bool FromInt(this EducationLevels _, int value, Years? year, out EducationLevels? educationlevels, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(99, Years._1996) => NotAvailables.Unspecified,
				(97, Years._1996) => NotAvailables.AgedLessThan05,

				_ => new NotAvailables?(),
			};

			educationlevels = (value, year) switch
			{
				(01, Years._1996) => EducationLevels.NoSchooling,
				(02, Years._1996) => EducationLevels.Grade00,
				(03, Years._1996) => EducationLevels.Grade01,
				(04, Years._1996) => EducationLevels.Grade02,
				(05, Years._1996) => EducationLevels.Grade03,
				(06, Years._1996) => EducationLevels.Grade04,
				(07, Years._1996) => EducationLevels.Grade05,
				(08, Years._1996) => EducationLevels.Grade06,
				(09, Years._1996) => EducationLevels.Grade07,
				(10, Years._1996) => EducationLevels.Grade08,
				(11, Years._1996) => EducationLevels.Grade09,
				(12, Years._1996) => EducationLevels.Grade10,
				(13, Years._1996) => EducationLevels.Grade11,
				(14, Years._1996) => EducationLevels.LessThanMatric,
				(15, Years._1996) => EducationLevels.MatricOnly,
				(16, Years._1996) => EducationLevels.MatricAndCertificate,
				(17, Years._1996) => EducationLevels.MatricAndDiploma,
				(18, Years._1996) => EducationLevels.MatricAndBachelors,
				(19, Years._1996) => EducationLevels.MatricAndBachelorsWithDiploma,
				(20, Years._1996) => EducationLevels.MatricAndBachelorsWithHonours,
				(21, Years._1996) => EducationLevels.MatricAndMasters,
				(22, Years._1996) => EducationLevels.MatricAndDoctors,
				(23, Years._1996) => EducationLevels.OtherQualifications,
				
				(01, _) => EducationLevels.NoSchooling,
				(02, _) => EducationLevels.Grade00,
				(03, _) => EducationLevels.Grade01,
				(04, _) => EducationLevels.Grade02,
				(05, _) => EducationLevels.Grade03,
				(06, _) => EducationLevels.Grade04,
				(07, _) => EducationLevels.Grade05,
				(08, _) => EducationLevels.Grade06,
				(09, _) => EducationLevels.Grade07,
				(10, _) => EducationLevels.Grade08,
				(11, _) => EducationLevels.Grade09,
				(12, _) => EducationLevels.Grade10,
				(13, _) => EducationLevels.Grade11,
				(14, _) => EducationLevels.LessThanMatric,
				(15, _) => EducationLevels.MatricOnly,
				(16, _) => EducationLevels.MatricAndCertificate,
				(17, _) => EducationLevels.MatricAndDiploma,
				(18, _) => EducationLevels.MatricAndBachelors,
				(19, _) => EducationLevels.MatricAndBachelorsWithDiploma,
				(20, _) => EducationLevels.MatricAndBachelorsWithHonours,
				(21, _) => EducationLevels.MatricAndMasters,
				(22, _) => EducationLevels.MatricAndDoctors,
				(23, _) => EducationLevels.OtherQualifications,

				_ => new EducationLevels?()
			};

			return notavailable is not null || educationlevels is not null;
		}
	}
}