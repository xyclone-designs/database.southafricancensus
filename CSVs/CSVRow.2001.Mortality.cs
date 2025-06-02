using System.IO;
using System.Linq;

namespace Database.SouthAfricanCensus.CSVs
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

		public uint? SN;
		public uint? H31Mo;
		public uint? H31Yr;
		public uint? H31Sx;
		public uint? H31Age;
		public uint? H31Acc;
		public uint? H31Pr;
		public double? MMwgt;
	}
}