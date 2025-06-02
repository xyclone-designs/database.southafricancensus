using System.IO;
using System.Linq;

namespace Database.SouthAfricanCensus.CSVs
{
	public class CSVRow2022F19 : CSVRow2022
	{
        public CSVRow2022F19(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{ 
				ProcessInt(LineSplit[00], logger, nameof(QID), out QID),
				ProcessInt(LineSplit[01], logger, nameof(DERH_HSIZE), out DERH_HSIZE),
				ProcessInt(LineSplit[02], logger, nameof(DERH_HHSEX), out DERH_HHSEX),
				ProcessInt(LineSplit[03], logger, nameof(DERH_HHPOP), out DERH_HHPOP),
				ProcessInt(LineSplit[04], logger, nameof(DERH_HHAGE), out DERH_HHAGE),
				ProcessInt(LineSplit[05], logger, nameof(H01_QUARTERS), out H01_QUARTERS),
				ProcessInt(LineSplit[06], logger, nameof(H02_MAINDWELLING), out H02_MAINDWELLING),
				ProcessInt(LineSplit[07], logger, nameof(H03_TENURE), out H03_TENURE),
				ProcessInt(LineSplit[08], logger, nameof(H04_RDP), out H04_RDP),
				ProcessInt(LineSplit[09], logger, nameof(H05_WATERPIPED), out H05_WATERPIPED),
				ProcessInt(LineSplit[10], logger, nameof(H06_WATERSOURCE), out H06_WATERSOURCE),
				ProcessInt(LineSplit[11], logger, nameof(H07A_WATERSUPPLY), out H07A_WATERSUPPLY),
				ProcessInt(LineSplit[12], logger, nameof(H08_TOILET), out H08_TOILET),
				ProcessInt(LineSplit[13], logger, nameof(H09_ENERGY_COOKING), out H09_ENERGY_COOKING),
				ProcessInt(LineSplit[14], logger, nameof(H10_ENERGY_LIGHTING), out H10_ENERGY_LIGHTING),
				ProcessInt(LineSplit[15], logger, nameof(H11_REFUSE), out H11_REFUSE),
				ProcessInt(LineSplit[16], logger, nameof(H12_REFRIGERATOR), out H12_REFRIGERATOR),
				ProcessInt(LineSplit[17], logger, nameof(H12_ELECTRIC_GAS_STOVE), out H12_ELECTRIC_GAS_STOVE),
				ProcessInt(LineSplit[18], logger, nameof(H12_VACUUM_CLEANER), out H12_VACUUM_CLEANER),
				ProcessInt(LineSplit[19], logger, nameof(H12_WASHINGM), out H12_WASHINGM),
				ProcessInt(LineSplit[20], logger, nameof(H12_COMPUTER), out H12_COMPUTER),
				ProcessInt(LineSplit[21], logger, nameof(H12_SATELLITE), out H12_SATELLITE),
				ProcessInt(LineSplit[22], logger, nameof(H12_DVD_PLAYER), out H12_DVD_PLAYER),
				ProcessInt(LineSplit[23], logger, nameof(H12_MOTOR_CAR), out H12_MOTOR_CAR),
				ProcessInt(LineSplit[24], logger, nameof(H12_TELEVISION), out H12_TELEVISION),
				ProcessInt(LineSplit[25], logger, nameof(H12_RADIO), out H12_RADIO),
				ProcessInt(LineSplit[26], logger, nameof(H12_LANDLINE), out H12_LANDLINE),
				ProcessInt(LineSplit[27], logger, nameof(H12_CELLPHONE), out H12_CELLPHONE),
				ProcessInt(LineSplit[28], logger, nameof(H13_INTERNET_ACCESS), out H13_INTERNET_ACCESS),
				ProcessInt(LineSplit[29], logger, nameof(A4_ADULT_HUNGER), out A4_ADULT_HUNGER),
				ProcessInt(LineSplit[30], logger, nameof(A5_CHILD_HUNGER), out A5_CHILD_HUNGER),
				ProcessDouble(LineSplit[31], logger, nameof(HH_WGT), out HH_WGT)

			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public uint? QID;
		public uint? DERH_HSIZE;
		public uint? DERH_HHSEX;
		public uint? DERH_HHPOP;
		public uint? DERH_HHAGE;
		public uint? H01_QUARTERS;
		public uint? H02_MAINDWELLING;
		public uint? H03_TENURE;
		public uint? H04_RDP;
		public uint? H05_WATERPIPED;
		public uint? H06_WATERSOURCE;
		public uint? H07A_WATERSUPPLY;
		public uint? H08_TOILET;
		public uint? H09_ENERGY_COOKING;
		public uint? H10_ENERGY_LIGHTING;
		public uint? H11_REFUSE;
		public uint? H12_REFRIGERATOR;
		public uint? H12_ELECTRIC_GAS_STOVE;
		public uint? H12_VACUUM_CLEANER;
		public uint? H12_WASHINGM;
		public uint? H12_COMPUTER;
		public uint? H12_SATELLITE;
		public uint? H12_DVD_PLAYER;
		public uint? H12_MOTOR_CAR;
		public uint? H12_TELEVISION;
		public uint? H12_RADIO;
		public uint? H12_LANDLINE;
		public uint? H12_CELLPHONE;
		public uint? H13_INTERNET_ACCESS;
		public uint? A4_ADULT_HUNGER;
		public uint? A5_CHILD_HUNGER;
		public double? HH_WGT;
	}
}