using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class LanguagesExtensions
	{
		public static bool FromInt(this Languages _, int value, Years? year, out Languages? languages, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(97, Years._1996) => NotAvailables.SpeaksOnlyOneLanguage,
				(99, Years._1996) => NotAvailables.Unspecified,
				(98, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			languages = (value, year) switch
			{
				(01, Years._1996) => Languages.IsiNdebele,
				(02, Years._1996) => Languages.IsiXhosa,
				(03, Years._1996) => Languages.IsiZulu,
				(04, Years._1996) => Languages.Sepedi,
				(05, Years._1996) => Languages.Sesotho,
				(06, Years._1996) => Languages.Setswana,
				(07, Years._1996) => Languages.Siswati,
				(08, Years._1996) => Languages.Tshivenda,
				(09, Years._1996) => Languages.Xitsonga,
				(10, Years._1996) => Languages.Afrikaans,
				(11, Years._1996) => Languages.English,
				(12, Years._1996) => Languages.Dutch,
				(13, Years._1996) => Languages.German,
				(14, Years._1996) => Languages.Greek,
				(15, Years._1996) => Languages.Italian,
				(16, Years._1996) => Languages.Portuguese,
				(17, Years._1996) => Languages.French,
				(18, Years._1996) => Languages.Tamil,
				(19, Years._1996) => Languages.Hindi,
				(20, Years._1996) => Languages.Telegu,
				(21, Years._1996) => Languages.Gujarati,
				(22, Years._1996) => Languages.Urdu,
				(23, Years._1996) => Languages.Chinese,
				(24, Years._1996) => Languages.Swahili,
				(25, Years._1996) => Languages.Shona,
				(26, Years._1996) => Languages.Arabic,
				(00, Years._1996) => Languages.Other,

				(01, _) => Languages.IsiNdebele,
				(02, _) => Languages.IsiXhosa,
				(03, _) => Languages.IsiZulu,
				(04, _) => Languages.Sepedi,
				(05, _) => Languages.Sesotho,
				(06, _) => Languages.Setswana,
				(07, _) => Languages.Siswati,
				(08, _) => Languages.Tshivenda,
				(09, _) => Languages.Xitsonga,
				(10, _) => Languages.Afrikaans,
				(11, _) => Languages.English,
				(12, _) => Languages.Dutch,
				(13, _) => Languages.German,
				(14, _) => Languages.Greek,
				(15, _) => Languages.Italian,
				(16, _) => Languages.Portuguese,
				(17, _) => Languages.French,
				(18, _) => Languages.Tamil,
				(19, _) => Languages.Hindi,
				(20, _) => Languages.Telegu,
				(21, _) => Languages.Gujarati,
				(22, _) => Languages.Urdu,
				(23, _) => Languages.Chinese,
				(24, _) => Languages.Swahili,
				(25, _) => Languages.Shona,
				(26, _) => Languages.Arabic,
				(00, _) => Languages.Other,

				_ => new Languages?()
			};

			return notavailable is not null || languages is not null;
		}
	}
}