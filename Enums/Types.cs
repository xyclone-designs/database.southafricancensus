using System;

namespace Database.SouthAfricanCensus.Enums
{
	public enum Types
	{
		Agriculture,
		Household,
		Mortality,
		Person,

		F18,
		F19,
		F21,
	}

	public static class TypesExtensions
	{
		public static Types FromFilename(this Types _, string filename)
		{
			if (true switch
			{
				true when filename.Contains("Agriculture") => Types.Agriculture,
				true when filename.Contains("Household") => Types.Household,
				true when filename.Contains("Mortality") => Types.Mortality,
				true when filename.Contains("Person") => Types.Person,

				true when filename.Contains("F18") => Types.F18,
				true when filename.Contains("F19") => Types.F19,
				true when filename.Contains("F21") => Types.F21,

				_ => new Types?()

			} is Types type) return type;

			throw new ArgumentException(string.Format("Type not found from '{0}'", filename));
		}
	}
}