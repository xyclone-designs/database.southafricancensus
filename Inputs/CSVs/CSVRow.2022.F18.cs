using System.IO;
using System.Linq;

namespace Database.SouthAfricanCensus.Inputs.CSVs
{
	public class CSVRow2022F18 : CSVRow2022
    {
		public CSVRow2022F18(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{
				ProcessInt(LineSplit[00], logger, nameof(QID), out QID),
				ProcessInt(LineSplit[01], logger, nameof(Province), out Province),
				ProcessString(LineSplit[02], logger, nameof(District), out District),
				ProcessString(LineSplit[03], logger, nameof(Municipality), out Municipality),
				ProcessInt(LineSplit[04], logger, nameof(Geo_type), out Geo_type),

			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public uint? QID;
		public uint? Province;
		public string? District;
		public string? Municipality;
		public uint? Geo_type;
	}
}