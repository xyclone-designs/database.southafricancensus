using System.IO;
using System.Linq;

using XycloneDesigns.Database.SouthAfricanCensus.Tables;

namespace Database.SouthAfricanCensus.Inputs.CSVs
{
	public class CSVRow2001Mortality : CSVRow2001
    {
		public CSVRow2001Mortality(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{
				ProcessInt(LineSplit[00], logger, nameof(SN), out SN),
				ProcessInt(LineSplit[01], logger, nameof(H31Mo), out H31Mo),
				ProcessInt(LineSplit[02], logger, nameof(H31Yr), out H31Yr),
				ProcessInt(LineSplit[03], logger, nameof(H31Sx), out H31Sx),
				ProcessInt(LineSplit[04], logger, nameof(H31Age), out H31Age),
				ProcessInt(LineSplit[05], logger, nameof(H31Acc), out H31Acc),
				ProcessInt(LineSplit[06], logger, nameof(H31Pr), out H31Pr),
				ProcessDouble(LineSplit[07], logger, nameof(MMwgt), out MMwgt),

			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public int? SN;
		public int? H31Mo;
		public int? H31Yr;
		public int? H31Sx;
		public int? H31Age;
		public int? H31Acc;
		public int? H31Pr;
		public double? MMwgt;

		public RecordsMortality AsRecord()
		{
			return new RecordsMortality { };
		}
	}
}