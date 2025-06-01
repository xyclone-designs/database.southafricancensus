
namespace Database.SouthAfricanCensus.CSVs
{
	public class CSVRow1996Household : CSVRow1996
    {
		public CSVRow1996Household(string line) : base(line) { }

		public int? province { get; set; }
		public int? district { get; set; }
		public int? dccode { get; set; }
		public int? newla { get; set; }
		public int? hhnumber { get; set; }
		public string? questype { get; set; }
		public int? urban { get; set; }
		public int? addmon2 { get; set; }
		public int? payment2 { get; set; }
		public int? migrant { get; set; }
		public int? hhmigran { get; set; }
		public int? dwelling { get; set; }
		public int? rooms { get; set; }
		public int? nsharedh { get; set; }
		public int? owend { get; set; }
		public int? fuelcook { get; set; }
		public int? fuelheat { get; set; }
		public int? fuelligh { get; set; }
		public int? water { get; set; }
		public int? toilet { get; set; }
		public int? refuse { get; set; }
		public int? telephon { get; set; }
		public int? hohrace { get; set; }
		public int? hohsex { get; set; }
		public int? hohage { get; set; }
		public int? hoheduca { get; set; }
		public int? hohocp1 { get; set; }
		public int? hohecona { get; set; }
		public int? hhsize { get; set; }
		public int? hinchh { get; set; }
		public int? hinchhra { get; set; }
		public int? hinchhse { get; set; }
		public int? hhinccat { get; set; }
		public decimal? peshhwei { get; set; }

		public new CSVRow1996Household Process(StreamWriter logger)
		{
			province = ProcessInt(LineSplit[00], logger, "province");
			district = ProcessInt(LineSplit[01], logger, "district");
			dccode = ProcessInt(LineSplit[02], logger, "dccode");
			newla = ProcessInt(LineSplit[03], logger, "newla");
			hhnumber = ProcessInt(LineSplit[04], logger, "hhnumber");
			questype = ProcessString(LineSplit[05], logger, "questype");
			urban = ProcessInt(LineSplit[06], logger, "urban");
			addmon2 = ProcessInt(LineSplit[07], logger, "addmon2");
			payment2 = ProcessInt(LineSplit[08], logger, "payment2");
			migrant = ProcessInt(LineSplit[09], logger, "migrant");
			hhmigran = ProcessInt(LineSplit[10], logger, "hhmigran");
			dwelling = ProcessInt(LineSplit[11], logger, "dwelling");
			rooms = ProcessInt(LineSplit[12], logger, "rooms");
			nsharedh = ProcessInt(LineSplit[13], logger, "nsharedh");
			owend = ProcessInt(LineSplit[14], logger, "owend");
			fuelcook = ProcessInt(LineSplit[15], logger, "fuelcook");
			fuelheat = ProcessInt(LineSplit[16], logger, "fuelheat");
			fuelligh = ProcessInt(LineSplit[17], logger, "fuelligh");
			water = ProcessInt(LineSplit[18], logger, "water");
			toilet = ProcessInt(LineSplit[19], logger, "toilet");
			refuse = ProcessInt(LineSplit[20], logger, "refuse");
			telephon = ProcessInt(LineSplit[21], logger, "telephon");
			hohrace = ProcessInt(LineSplit[22], logger, "hohrace");
			hohsex = ProcessInt(LineSplit[23], logger, "hohsex");
			hohage = ProcessInt(LineSplit[24], logger, "hohage");
			hoheduca = ProcessInt(LineSplit[25], logger, "hoheduca");
			hohocp1 = ProcessInt(LineSplit[26], logger, "hohocp1");
			hohecona = ProcessInt(LineSplit[27], logger, "hohecona");
			hhsize = ProcessInt(LineSplit[28], logger, "hhsize");
			hinchh = ProcessInt(LineSplit[29], logger, "hinchh");
			hinchhra = ProcessInt(LineSplit[30], logger, "hinchhra");
			hinchhse = ProcessInt(LineSplit[31], logger, "hinchhse");
			hhinccat = ProcessInt(LineSplit[32], logger, "hhinccat");
			peshhwei = ProcessDecimal(LineSplit[33], logger, "peshhwei");

			return this;
		}

	}
}