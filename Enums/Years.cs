
namespace Database.SouthAfricanCensus.Enums
{
	public enum Years
	{
		_1996,
		_2001,
		_2011,
		_2022,
	}

	public static class YearsExtensions
	{
		public static Years FromFilename(this Years _, string filename)
		{
			if (true switch
			{
				true when filename.Contains("1996") => Years._1996,
				true when filename.Contains("2001") => Years._2001,
				true when filename.Contains("2011") => Years._2011,
				true when filename.Contains("2022") => Years._2022,

				_ => new Years?()

			} is Years roundone) return roundone;

			throw new ArgumentException(string.Format("Round not found from '{0}'", filename));
		}

		public static int ToInt(this Years round)
		{
			return round switch
			{
				Years._1996 => 1996,
				Years._2001 => 2001,
				Years._2011 => 2011,
				Years._2022 => 2022,

				_ => throw new ArgumentException(string.Format("Round '{0}' not found", round))
			};
		}
		public static string AsString(this Years round)
		{
			return round switch
			{
				Years._1996 => "1996",
				Years._2001 => "2001",
				Years._2011 => "2011",
				Years._2022 => "2022",

				_ => throw new ArgumentException(string.Format("Round '{0}' not found", round))
			};
		}
		public static Years AsRound(this string round)
		{
			return round switch
			{
				"1996" => Years._1996,
				"2001" => Years._2001,
				"2011" => Years._2011,
				"2022" => Years._2022,

				_ => throw new ArgumentException(string.Format("Round '{0}' not found", round))
			};
		}
	}
}