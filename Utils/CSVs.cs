
namespace Database.SouthAfricanCensus.CSVs
{
	public static partial class Utils
	{
		public static partial class CSVs
		{
			public static IEnumerable<TCSVRow> Rows<TCSVRow>(StreamWriter log, params Stream[] streams) where TCSVRow : CSVRow
			{
				foreach (Stream stream in streams)
				{
					using StreamReader streamReader = new(stream);

					log.WriteLine();
					streamReader.ReadLine();

					for (int linecurrent = 1; streamReader.ReadLine() is string line; linecurrent++)
					{
						TCSVRow? row = default;
						string[] columns = line.Split(',');

						try
						{
							row = true switch
							{
								true when typeof(TCSVRow) == typeof(CSVRow1996Household) => new CSVRow1996Household(line) { LineNumber = linecurrent } as TCSVRow,
								true when typeof(TCSVRow) == typeof(CSVRow1996Person) => new CSVRow1996Person(line) { LineNumber = linecurrent } as TCSVRow,

								true when typeof(TCSVRow) == typeof(CSVRow2001Household) => new CSVRow2001Household(line) { LineNumber = linecurrent } as TCSVRow,
								true when typeof(TCSVRow) == typeof(CSVRow2001Mortality) => new CSVRow2001Mortality(line) { LineNumber = linecurrent } as TCSVRow,
								true when typeof(TCSVRow) == typeof(CSVRow2001Person) => new CSVRow2001Person(line) { LineNumber = linecurrent } as TCSVRow,

								true when typeof(TCSVRow) == typeof(CSVRow2011Agriculture) => new CSVRow2011Agriculture(line) { LineNumber = linecurrent } as TCSVRow,
								true when typeof(TCSVRow) == typeof(CSVRow2011Household) => new CSVRow2011Household(line) { LineNumber = linecurrent } as TCSVRow,
								true when typeof(TCSVRow) == typeof(CSVRow2011Mortality) => new CSVRow2011Mortality(line) { LineNumber = linecurrent } as TCSVRow,
								true when typeof(TCSVRow) == typeof(CSVRow2011Person) => new CSVRow2011Person(line) { LineNumber = linecurrent } as TCSVRow,

								true when typeof(TCSVRow) == typeof(CSVRow2022F18) => new CSVRow2022F18(line) { LineNumber = linecurrent } as TCSVRow,
								true when typeof(TCSVRow) == typeof(CSVRow2022F19) => new CSVRow2022F19(line) { LineNumber = linecurrent } as TCSVRow,
								true when typeof(TCSVRow) == typeof(CSVRow2022F21) => new CSVRow2022F21(line) { LineNumber = linecurrent } as TCSVRow,

								_ => throw new Exception(),
							};
						}
						catch (Exception ex) { log.WriteLine("[{0}]: Error = '{1}'", linecurrent, ex.Message); }

						if (row is not null)
							yield return row;
					}
				}
			}
		}
	}
}
