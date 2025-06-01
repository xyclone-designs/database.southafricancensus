using System.IO;
using System.Linq;

namespace Database.SouthAfricanCensus.CSVs
{
	public class CSVRow1996Household : CSVRow1996
    {
		public CSVRow1996Household(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{
				ProcessInt(LineSplit[00], logger, nameof(province), out province),
				ProcessInt(LineSplit[01], logger, nameof(district), out district),
				ProcessInt(LineSplit[02], logger, nameof(dccode), out dccode),
				ProcessInt(LineSplit[03], logger, nameof(newla), out newla),
				ProcessInt(LineSplit[04], logger, nameof(hhnumber), out hhnumber),
				ProcessString(LineSplit[05], logger, nameof(questype), out questype),
				ProcessInt(LineSplit[06], logger, nameof(urban), out urban),
				ProcessInt(LineSplit[07], logger, nameof(addmon2), out addmon2),
				ProcessInt(LineSplit[08], logger, nameof(payment2), out payment2),
				ProcessInt(LineSplit[09], logger, nameof(migrant), out migrant),
				ProcessInt(LineSplit[10], logger, nameof(hhmigran), out hhmigran),
				ProcessInt(LineSplit[11], logger, nameof(dwelling), out dwelling),
				ProcessInt(LineSplit[12], logger, nameof(rooms), out rooms),
				ProcessInt(LineSplit[13], logger, nameof(nsharedh), out nsharedh),
				ProcessInt(LineSplit[14], logger, nameof(owend), out owend),
				ProcessInt(LineSplit[15], logger, nameof(fuelcook), out fuelcook),
				ProcessInt(LineSplit[16], logger, nameof(fuelheat), out fuelheat),
				ProcessInt(LineSplit[17], logger, nameof(fuelligh), out fuelligh),
				ProcessInt(LineSplit[18], logger, nameof(water), out water),
				ProcessInt(LineSplit[19], logger, nameof(toilet), out toilet),
				ProcessInt(LineSplit[20], logger, nameof(refuse), out refuse),
				ProcessInt(LineSplit[21], logger, nameof(telephon), out telephon),
				ProcessInt(LineSplit[22], logger, nameof(hohrace), out hohrace),
				ProcessInt(LineSplit[23], logger, nameof(hohsex), out hohsex),
				ProcessInt(LineSplit[24], logger, nameof(hohage), out hohage),
				ProcessInt(LineSplit[25], logger, nameof(hoheduca), out hoheduca),
				ProcessInt(LineSplit[26], logger, nameof(hohocp1), out hohocp1),
				ProcessInt(LineSplit[27], logger, nameof(hohecona), out hohecona),
				ProcessInt(LineSplit[28], logger, nameof(hhsize), out hhsize),
				ProcessInt(LineSplit[29], logger, nameof(hinchh), out hinchh),
				ProcessInt(LineSplit[30], logger, nameof(hinchhra), out hinchhra),
				ProcessInt(LineSplit[31], logger, nameof(hinchhse), out hinchhse),
				ProcessInt(LineSplit[32], logger, nameof(hhinccat), out hhinccat),
				ProcessDouble(LineSplit[33], logger, nameof(peshhwei), out peshhwei),

			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public int? province;
		public int? district;
		public int? dccode;
		public int? newla;
		public int? hhnumber;
		public string? questype;
		public int? urban;
		public int? addmon2;
		public int? payment2;
		public int? migrant;
		public int? hhmigran;
		public int? dwelling;
		public int? rooms;
		public int? nsharedh;
		public int? owend;
		public int? fuelcook;
		public int? fuelheat;
		public int? fuelligh;
		public int? water;
		public int? toilet;
		public int? refuse;
		public int? telephon;
		public int? hohrace;
		public int? hohsex;
		public int? hohage;
		public int? hoheduca;
		public int? hohocp1;
		public int? hohecona;
		public int? hhsize;
		public int? hinchh;
		public int? hinchhra;
		public int? hinchhse;
		public int? hhinccat;
		public double? peshhwei;
	}
}