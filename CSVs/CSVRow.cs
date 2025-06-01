using System.IO;

namespace Database.SouthAfricanCensus.CSVs
{
    public abstract class CSVRow
    {
        public CSVRow(string line)
        {
            Line = line;
			LineSplit = line.Split(',');
		}

        public string Line { get; set; }
        public int LineNumber { get; set; }
        public string[] LineSplit { get; set; }

        public static bool ProcessInt(string? value, StreamWriter logger, string? loggerkey, out int? processed) 
        {
            processed = int.TryParse(value, out int _processed) ? _processed : new int?();

            if (processed is null)
            {
				if (loggerkey is null) logger.Write(" {0} ", value);
				else logger.Write("{0}: {1} ", loggerkey, value);
			}

			return processed is not null;
		}
        public static bool ProcessDouble(string? value, StreamWriter logger, string? loggerkey, out double? processed) 
        {
			processed = double.TryParse(value?.Replace('.', ','), out double _processed) ? _processed : new double?();

			if (processed is null)
			{
				if (loggerkey is null) logger.Write(" {0} ", value);
				else logger.Write("{0}: {1} ", loggerkey, value);
			}

			return processed is not null;
        }
        public static bool ProcessDecimal(string? value, StreamWriter logger, string? loggerkey, out decimal? processed) 
        {
			processed = decimal.TryParse(value?.Replace('.', ','), out decimal _processed) ? _processed : new decimal?();

			if (processed is null)
			{
				if (loggerkey is null) logger.Write(" {0} ", value);
				else logger.Write("{0}: {1} ", loggerkey, value);
			}

			return processed is not null;
        }
        public static bool ProcessString(string? value, StreamWriter logger, string? loggerkey, out string? processed)
        {
			processed = value;

			if (value is null)
			{
				if (loggerkey is null) logger.Write(" {0} ", value);
				else logger.Write("{0}: {1} ", loggerkey, value);

			}

			return value is not null;
		}
	}
}