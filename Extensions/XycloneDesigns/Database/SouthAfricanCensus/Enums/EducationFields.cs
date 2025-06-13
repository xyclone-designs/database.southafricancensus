using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class EducationFieldsExtensions
	{
		public static bool FromInt(this EducationFields _, int? value, Years? year, out EducationFields? educationfields, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(99, Years._1996) => NotAvailables.Unspecified,
				(96, Years._1996) => NotAvailables.None,
				(97, Years._1996) => NotAvailables.AgedLessThan15,

				_ => new NotAvailables?(),
			};

			educationfields = (value, year) switch
			{
				(01, Years._1996) => EducationFields.Arts,
				(02, Years._1996) => EducationFields.Science,
				(03, Years._1996) => EducationFields.Law,
				(04, Years._1996) => EducationFields.Theology,
				(05, Years._1996) => EducationFields.EconomicsAndManagement,
				(06, Years._1996) => EducationFields.Education,
				(07, Years._1996) => EducationFields.MedicalSciences,
				(08, Years._1996) => EducationFields.Engineering,
				(09, Years._1996) => EducationFields.AdministrationAndClerical,
				(10, Years._1996) => EducationFields.Protection,
				(11, Years._1996) => EducationFields.BuildingSciences,
				(12, Years._1996) => EducationFields.Technical,
				(13, Years._1996) => EducationFields.Computing,
				(14, Years._1996) => EducationFields.VeterinaryScience,
				(15, Years._1996) => EducationFields.Other,
				
				(01, _) => EducationFields.Arts,
				(02, _) => EducationFields.Science,
				(03, _) => EducationFields.Law,
				(04, _) => EducationFields.Theology,
				(05, _) => EducationFields.EconomicsAndManagement,
				(06, _) => EducationFields.Education,
				(07, _) => EducationFields.MedicalSciences,
				(08, _) => EducationFields.Engineering,
				(09, _) => EducationFields.AdministrationAndClerical,
				(10, _) => EducationFields.Protection,
				(11, _) => EducationFields.BuildingSciences,
				(12, _) => EducationFields.Technical,
				(13, _) => EducationFields.Computing,
				(14, _) => EducationFields.VeterinaryScience,
				(15, _) => EducationFields.Other,
				
				_ => new EducationFields?()
			};

			return notavailable is not null || educationfields is not null;
		}
	}
}