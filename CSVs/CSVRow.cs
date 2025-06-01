
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

        public CSVRow Process(StreamWriter logger) 
        {
            return this;
        }

        public int? ProcessInt(string? value, StreamWriter logger, string? loggerkey) 
        {
            int? processed = int.TryParse(value, out int _processed) ? _processed : new int?();

            if (processed is null)
            {
				if (loggerkey is null) logger.Write(" {0} ", value);
				else logger.Write("{0}: {1} ", loggerkey, value);
			}

			return processed;
		}
        public decimal? ProcessDecimal(string? value, StreamWriter logger, string? loggerkey) 
        {
			decimal? processed = decimal.TryParse(value, out decimal _processed) ? _processed : new decimal?();

			if (processed is null)
			{
				if (loggerkey is null) logger.Write(" {0} ", value);
				else logger.Write("{0}: {1} ", loggerkey, value);
			}

			return processed;
        }
        public string? ProcessString(string? value, StreamWriter logger, string? loggerkey)
        {
			return value;
		}
	}
}