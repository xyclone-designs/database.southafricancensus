using System.IO;
using System.Linq;
using XycloneDesigns.Database.SouthAfricanCensus.Tables;

namespace Database.SouthAfricanCensus.Inputs.CSVs
{
	public class CSVRow2011Household : CSVRow2011
	{
        public CSVRow2011Household(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{
				ProcessInt(LineSplit[00], logger, nameof(QN_TYPE), out QN_TYPE),
				ProcessLong(LineSplit[01], logger, nameof(SN), out SN),
				ProcessInt(LineSplit[02], logger, nameof(H01_QUARTERS), out H01_QUARTERS),
				ProcessInt(LineSplit[03], logger, nameof(H02_MAINDWELLING), out H02_MAINDWELLING),
				ProcessInt(LineSplit[04], logger, nameof(H02_OTHERDWELLING), out H02_OTHERDWELLING),
				ProcessInt(LineSplit[05], logger, nameof(H02A_ROOF), out H02A_ROOF),
				ProcessInt(LineSplit[06], logger, nameof(H02A_WALL), out H02A_WALL),
				ProcessInt(LineSplit[07], logger, nameof(H03_DININGROOMS), out H03_DININGROOMS),
				ProcessInt(LineSplit[08], logger, nameof(H03_LIVINGROOMS), out H03_LIVINGROOMS),
				ProcessInt(LineSplit[09], logger, nameof(H03_DINING_LIVING), out H03_DINING_LIVING),
				ProcessInt(LineSplit[10], logger, nameof(H03_BEDROOMS), out H03_BEDROOMS),
				ProcessInt(LineSplit[11], logger, nameof(H03_STUDYROOMS), out H03_STUDYROOMS),
				ProcessInt(LineSplit[12], logger, nameof(H03_MULTIPLE_USE), out H03_MULTIPLE_USE),
				ProcessInt(LineSplit[13], logger, nameof(H03_OTHERROOMS), out H03_OTHERROOMS),
				ProcessInt(LineSplit[14], logger, nameof(H03_TOTROOMS), out H03_TOTROOMS),
				ProcessInt(LineSplit[15], logger, nameof(H04_TENURE), out H04_TENURE),
				ProcessInt(LineSplit[16], logger, nameof(H07_WATERPIPED), out H07_WATERPIPED),
				ProcessInt(LineSplit[17], logger, nameof(H08_WATERSOURCE), out H08_WATERSOURCE),
				ProcessDouble(LineSplit[18], logger, nameof(H09_WATERSUPPLY), out H09_WATERSUPPLY),
				ProcessDouble(LineSplit[19], logger, nameof(H09A_WATERSUPPLY), out H09A_WATERSUPPLY),
				ProcessDouble(LineSplit[20], logger, nameof(H09B_ALT_WATERSOURCE), out H09B_ALT_WATERSOURCE),
				ProcessInt(LineSplit[21], logger, nameof(H10_TOILET), out H10_TOILET),
				ProcessInt(LineSplit[22], logger, nameof(H11_ENERGY_COOKING), out H11_ENERGY_COOKING),
				ProcessInt(LineSplit[23], logger, nameof(H11_ENERGY_HEATING), out H11_ENERGY_HEATING),
				ProcessInt(LineSplit[24], logger, nameof(H11_ENERGY_LIGHTING), out H11_ENERGY_LIGHTING),
				ProcessInt(LineSplit[25], logger, nameof(H12_REFUSE), out H12_REFUSE),
				ProcessInt(LineSplit[26], logger, nameof(H13_REFRIDGERATOR), out H13_REFRIDGERATOR),
				ProcessInt(LineSplit[27], logger, nameof(H13_STOVE), out H13_STOVE),
				ProcessInt(LineSplit[28], logger, nameof(H13_VACUUM), out H13_VACUUM),
				ProcessInt(LineSplit[29], logger, nameof(H13_WASHINGM), out H13_WASHINGM),
				ProcessInt(LineSplit[30], logger, nameof(H13_COMPUTER), out H13_COMPUTER),
				ProcessInt(LineSplit[31], logger, nameof(H13_SATELLITE), out H13_SATELLITE),
				ProcessInt(LineSplit[32], logger, nameof(H13_DVD_PLAYER), out H13_DVD_PLAYER),
				ProcessInt(LineSplit[33], logger, nameof(H13_MOTORCAR), out H13_MOTORCAR),
				ProcessInt(LineSplit[34], logger, nameof(H13_TV), out H13_TV),
				ProcessInt(LineSplit[35], logger, nameof(H13_RADIO), out H13_RADIO),
				ProcessInt(LineSplit[36], logger, nameof(H13_LANDLINE), out H13_LANDLINE),
				ProcessInt(LineSplit[37], logger, nameof(H13_CELLPHONE), out H13_CELLPHONE),
				ProcessInt(LineSplit[38], logger, nameof(H13_POSTBOX), out H13_POSTBOX),
				ProcessInt(LineSplit[39], logger, nameof(H13_RESIDENTIAL_MAIL), out H13_RESIDENTIAL_MAIL),
				ProcessInt(LineSplit[40], logger, nameof(H13A_INTERNET), out H13A_INTERNET),
				ProcessDouble(LineSplit[41], logger, nameof(HM00_DEATHS), out HM00_DEATHS),
				ProcessDouble(LineSplit[42], logger, nameof(HM00A_DEATHSNO), out HM00A_DEATHSNO),
				ProcessInt(LineSplit[43], logger, nameof(DERH_HHAGE), out DERH_HHAGE),
				ProcessInt(LineSplit[44], logger, nameof(DERH_HHPOP), out DERH_HHPOP),
				ProcessInt(LineSplit[45], logger, nameof(DERH_HHSEX), out DERH_HHSEX),
				ProcessInt(LineSplit[46], logger, nameof(DERH_HINCOME), out DERH_HINCOME),
				ProcessInt(LineSplit[47], logger, nameof(DERH_HH_EMPLOY_STATUS), out DERH_HH_EMPLOY_STATUS),
				ProcessInt(LineSplit[48], logger, nameof(DERH_HSIZE), out DERH_HSIZE),
				ProcessDouble(LineSplit[49], logger, nameof(DERH_XPOP), out DERH_XPOP),
				ProcessInt(LineSplit[50], logger, nameof(DERH_INCOME_CLASS), out DERH_INCOME_CLASS),
				ProcessInt(LineSplit[51], logger, nameof(H_GEOTYPE), out H_GEOTYPE),
				ProcessInt(LineSplit[52], logger, nameof(H_PROVINCE), out H_PROVINCE),
				ProcessInt(LineSplit[53], logger, nameof(H_DISTRICT), out H_DISTRICT),
				ProcessInt(LineSplit[54], logger, nameof(H_MUNIC), out H_MUNIC),
				ProcessDouble(LineSplit[55], logger, nameof(HHLD_10PERCENT_WGT), out HHLD_10PERCENT_WGT),

			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public uint? QN_TYPE;
		public long? SN;
		public uint? H01_QUARTERS;
		public uint? H02_MAINDWELLING;
		public uint? H02_OTHERDWELLING;
		public uint? H02A_ROOF;
		public uint? H02A_WALL;
		public uint? H03_DININGROOMS;
		public uint? H03_LIVINGROOMS;
		public uint? H03_DINING_LIVING;
		public uint? H03_BEDROOMS;
		public uint? H03_STUDYROOMS;
		public uint? H03_MULTIPLE_USE;
		public uint? H03_OTHERROOMS;
		public uint? H03_TOTROOMS;
		public uint? H04_TENURE;
		public uint? H07_WATERPIPED;
		public uint? H08_WATERSOURCE;
		public double? H09_WATERSUPPLY;
		public double? H09A_WATERSUPPLY;
		public double? H09B_ALT_WATERSOURCE;
		public uint? H10_TOILET;
		public uint? H11_ENERGY_COOKING;
		public uint? H11_ENERGY_HEATING;
		public uint? H11_ENERGY_LIGHTING;
		public uint? H12_REFUSE;
		public uint? H13_REFRIDGERATOR;
		public uint? H13_STOVE;
		public uint? H13_VACUUM;
		public uint? H13_WASHINGM;
		public uint? H13_COMPUTER;
		public uint? H13_SATELLITE;
		public uint? H13_DVD_PLAYER;
		public uint? H13_MOTORCAR;
		public uint? H13_TV;
		public uint? H13_RADIO;
		public uint? H13_LANDLINE;
		public uint? H13_CELLPHONE;
		public uint? H13_POSTBOX;
		public uint? H13_RESIDENTIAL_MAIL;
		public uint? H13A_INTERNET;
		public double? HM00_DEATHS;
		public double? HM00A_DEATHSNO;
		public uint? DERH_HHAGE;
		public uint? DERH_HHPOP;
		public uint? DERH_HHSEX;
		public uint? DERH_HINCOME;
		public uint? DERH_HH_EMPLOY_STATUS;
		public uint? DERH_HSIZE;
		public double? DERH_XPOP;
		public uint? DERH_INCOME_CLASS;
		public uint? H_GEOTYPE;
		public uint? H_PROVINCE;
		public uint? H_DISTRICT;
		public uint? H_MUNIC;
		public double? HHLD_10PERCENT_WGT;

		public RecordsHousehold AsRecord()
		{
			return new RecordsHousehold { };
		}
	}
}