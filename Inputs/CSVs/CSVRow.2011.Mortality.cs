using System.IO;
using System.Linq;
using XycloneDesigns.Database.SouthAfricanCensus.Tables;

namespace Database.SouthAfricanCensus.Inputs.CSVs
{
	public class CSVRow2011Mortality : CSVRow2011
	{
		public CSVRow2011Mortality(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{
				ProcessLong(LineSplit[00], logger, nameof(SN), out SN),
				ProcessInt(LineSplit[01], logger, nameof(M02_MONTH), out M02_MONTH),
				ProcessInt(LineSplit[02], logger, nameof(M02_YEAR), out M02_YEAR),
				ProcessInt(LineSplit[03], logger, nameof(M03_SEX), out M03_SEX),
				ProcessInt(LineSplit[04], logger, nameof(M04_AGE), out M04_AGE),
				ProcessInt(LineSplit[05], logger, nameof(M05_CAUSE), out M05_CAUSE),
				ProcessDouble(LineSplit[06], logger, nameof(M_MX_POP_GROUP), out M_MX_POP_GROUP),
				ProcessInt(LineSplit[07], logger, nameof(M_GEOTYPE), out M_GEOTYPE),
				ProcessInt(LineSplit[08], logger, nameof(M_PROVINCE), out M_PROVINCE),
				ProcessInt(LineSplit[09], logger, nameof(M_DISTRICT), out M_DISTRICT),
				ProcessInt(LineSplit[10], logger, nameof(M_MUNIC), out M_MUNIC),
				ProcessDouble(LineSplit[11], logger, nameof(MORTALITY_10PERCENT_WEIGHT), out MORTALITY_10PERCENT_WEIGHT),
				
			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public long? SN;
		public int? M02_MONTH;
		public int? M02_YEAR;
		public int? M03_SEX;
		public int? M04_AGE;
		public int? M05_CAUSE;
		public double? M_MX_POP_GROUP;
		public int? M_GEOTYPE;
		public int? M_PROVINCE;
		public int? M_DISTRICT;
		public int? M_MUNIC;
		public double? MORTALITY_10PERCENT_WEIGHT;

		public RecordsMortality AsRecord()
		{
			return new RecordsMortality { };
		}
	}
}