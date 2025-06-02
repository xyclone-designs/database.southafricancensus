using System.IO;
using System.Linq;

namespace Database.SouthAfricanCensus.CSVs
{
	public class CSVRow2011Agriculture : CSVRow2011
	{
        public CSVRow2011Agriculture(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{
				ProcessDouble(LineSplit[00], logger, nameof(SN), out SN),
				ProcessDouble(LineSplit[01], logger, nameof(H01_QUARTERS), out H01_QUARTERS),
				ProcessDouble(LineSplit[02], logger, nameof(H02_MAINDWELLING), out H02_MAINDWELLING),
				ProcessDouble(LineSplit[03], logger, nameof(H02_OTHERDWELLING), out H02_OTHERDWELLING),
				ProcessDouble(LineSplit[04], logger, nameof(H02A_ROOF), out H02A_ROOF),
				ProcessDouble(LineSplit[05], logger, nameof(H02A_WALL), out H02A_WALL),
				ProcessDouble(LineSplit[06], logger, nameof(H03_DININGROOMS), out H03_DININGROOMS),
				ProcessDouble(LineSplit[07], logger, nameof(H03_LIVINGROOMS), out H03_LIVINGROOMS),
				ProcessDouble(LineSplit[08], logger, nameof(H03_DINING_LIVING), out H03_DINING_LIVING),
				ProcessDouble(LineSplit[29], logger, nameof(H03_BEDROOMS), out H03_BEDROOMS),
				ProcessDouble(LineSplit[20], logger, nameof(H03_STUDYROOMS), out H03_STUDYROOMS),
				ProcessDouble(LineSplit[21], logger, nameof(H03_MULTIPLE_USE), out H03_MULTIPLE_USE),
				ProcessDouble(LineSplit[22], logger, nameof(H03_OTHERROOMS), out H03_OTHERROOMS),
				ProcessDouble(LineSplit[23], logger, nameof(H03_TOTROOMS), out H03_TOTROOMS),
				ProcessDouble(LineSplit[24], logger, nameof(H04_TENURE), out H04_TENURE),
				ProcessDouble(LineSplit[26], logger, nameof(H07_WATERPIPED), out H07_WATERPIPED),
				ProcessDouble(LineSplit[27], logger, nameof(H08_WATERSOURCE), out H08_WATERSOURCE),
				ProcessDouble(LineSplit[28], logger, nameof(H09_WATERSUPPLY), out H09_WATERSUPPLY),
				ProcessDouble(LineSplit[29], logger, nameof(H09A_WATERSUPPLY), out H09A_WATERSUPPLY),
				ProcessDouble(LineSplit[30], logger, nameof(H09B_ALT_WATERSOURCE), out H09B_ALT_WATERSOURCE),
				ProcessDouble(LineSplit[31], logger, nameof(H10_TOILET), out H10_TOILET),
				ProcessDouble(LineSplit[32], logger, nameof(H11_ENERGY_COOKING), out H11_ENERGY_COOKING),
				ProcessDouble(LineSplit[33], logger, nameof(H11_ENERGY_HEATING), out H11_ENERGY_HEATING),
				ProcessDouble(LineSplit[34], logger, nameof(H11_ENERGY_LIGHTING), out H11_ENERGY_LIGHTING),
				ProcessDouble(LineSplit[35], logger, nameof(H12_REFUSE), out H12_REFUSE),
				ProcessDouble(LineSplit[36], logger, nameof(H13_REFRIDGERATOR), out H13_REFRIDGERATOR),
				ProcessDouble(LineSplit[37], logger, nameof(H13_STOVE), out H13_STOVE),
				ProcessDouble(LineSplit[38], logger, nameof(H13_VACUUM), out H13_VACUUM),
				ProcessDouble(LineSplit[39], logger, nameof(H13_WASHINGM), out H13_WASHINGM),
				ProcessDouble(LineSplit[40], logger, nameof(H13_COMPUTER), out H13_COMPUTER),
				ProcessDouble(LineSplit[41], logger, nameof(H13_SATELLITE), out H13_SATELLITE),
				ProcessDouble(LineSplit[42], logger, nameof(H13_DVD_PLAYER), out H13_DVD_PLAYER),
				ProcessDouble(LineSplit[43], logger, nameof(H13_MOTORCAR), out H13_MOTORCAR),
				ProcessDouble(LineSplit[44], logger, nameof(H13_TV), out H13_TV),
				ProcessDouble(LineSplit[45], logger, nameof(H13_RADIO), out H13_RADIO),
				ProcessDouble(LineSplit[46], logger, nameof(H13_LANDLINE), out H13_LANDLINE),
				ProcessDouble(LineSplit[47], logger, nameof(H13_CELLPHONE), out H13_CELLPHONE),
				ProcessDouble(LineSplit[48], logger, nameof(H13_POSTBOX), out H13_POSTBOX),
				ProcessDouble(LineSplit[49], logger, nameof(H13_RESIDENTIAL_MAIL), out H13_RESIDENTIAL_MAIL),
				ProcessDouble(LineSplit[50], logger, nameof(H13A_INTERNET), out H13A_INTERNET),
				ProcessDouble(LineSplit[51], logger, nameof(H14_1LIVESTOCK), out H14_1LIVESTOCK),
				ProcessDouble(LineSplit[52], logger, nameof(H14_2POULTRY), out H14_2POULTRY),
				ProcessDouble(LineSplit[53], logger, nameof(H14_3VEGETABLE), out H14_3VEGETABLE),
				ProcessDouble(LineSplit[54], logger, nameof(H14_4OTHERCROPS), out H14_4OTHERCROPS),
				ProcessDouble(LineSplit[55], logger, nameof(H14_5FODDERGRAZING), out H14_5FODDERGRAZING),
				ProcessDouble(LineSplit[56], logger, nameof(H14_6OTHER), out H14_6OTHER),
				ProcessDouble(LineSplit[57], logger, nameof(H14_0NONE), out H14_0NONE),
				ProcessDouble(LineSplit[58], logger, nameof(H14A1_CATTLE), out H14A1_CATTLE),
				ProcessDouble(LineSplit[59], logger, nameof(H14A2_SHEEP), out H14A2_SHEEP),
				ProcessDouble(LineSplit[60], logger, nameof(H14A3_GOATS), out H14A3_GOATS),
				ProcessDouble(LineSplit[61], logger, nameof(H14A4_PIGS), out H14A4_PIGS),
				ProcessDouble(LineSplit[62], logger, nameof(H14A5_OTHERS), out H14A5_OTHERS),
				ProcessDouble(LineSplit[63], logger, nameof(H14B1_FARMLAND), out H14B1_FARMLAND),
				ProcessDouble(LineSplit[64], logger, nameof(H14B2_BACKYARD_SCHOOL), out H14B2_BACKYARD_SCHOOL),
				ProcessDouble(LineSplit[65], logger, nameof(H14B3_COMMUNAL_TRIBALLAND), out H14B3_COMMUNAL_TRIBALLAND),
				ProcessDouble(LineSplit[66], logger, nameof(H14B4_OTHER), out H14B4_OTHER),
				ProcessDouble(LineSplit[67], logger, nameof(HM00_DEATHS), out HM00_DEATHS),
				ProcessDouble(LineSplit[68], logger, nameof(HM00A_DEATHSNO), out HM00A_DEATHSNO),
				ProcessDouble(LineSplit[69], logger, nameof(DERH_HHAGE), out DERH_HHAGE),
				ProcessDouble(LineSplit[60], logger, nameof(DERH_HHPOP), out DERH_HHPOP),
				ProcessDouble(LineSplit[61], logger, nameof(DERH_HHSEX), out DERH_HHSEX),
				ProcessDouble(LineSplit[60], logger, nameof(DERH_HINCOME), out DERH_HINCOME),
				ProcessDouble(LineSplit[61], logger, nameof(DERH_HH_EMPLOY_STATUS), out DERH_HH_EMPLOY_STATUS),
				ProcessDouble(LineSplit[62], logger, nameof(DERH_HSIZE), out DERH_HSIZE),
				ProcessDouble(LineSplit[63], logger, nameof(DERH_XPOP), out DERH_XPOP),
				ProcessDouble(LineSplit[64], logger, nameof(DERH_INCOME_CLASS), out DERH_INCOME_CLASS),
				ProcessDouble(LineSplit[65], logger, nameof(H_GEOTYPE), out H_GEOTYPE),
				ProcessDouble(LineSplit[66], logger, nameof(H_PROVINCE), out H_PROVINCE),
				ProcessDouble(LineSplit[67], logger, nameof(H_DISTRICT), out H_DISTRICT),
				ProcessDouble(LineSplit[60], logger, nameof(H_MUNIC), out H_MUNIC),
				ProcessDouble(LineSplit[69], logger, nameof(AGRICULTURE_10PERCENT_WEIGHT), out AGRICULTURE_10PERCENT_WEIGHT),


			}.Any(_ => _ == false)) logger.WriteLine();
		}
		
		public double? SN;
		public double? H01_QUARTERS;
		public double? H02_MAINDWELLING;
		public double? H02_OTHERDWELLING;
		public double? H02A_ROOF;
		public double? H02A_WALL;
		public double? H03_DININGROOMS;
		public double? H03_LIVINGROOMS;
		public double? H03_DINING_LIVING;
		public double? H03_BEDROOMS;
		public double? H03_STUDYROOMS;
		public double? H03_MULTIPLE_USE;
		public double? H03_OTHERROOMS;
		public double? H03_TOTROOMS;
		public double? H04_TENURE;
		public double? H07_WATERPIPED;
		public double? H08_WATERSOURCE;
		public double? H09_WATERSUPPLY;
		public double? H09A_WATERSUPPLY;
		public double? H09B_ALT_WATERSOURCE;
		public double? H10_TOILET;
		public double? H11_ENERGY_COOKING;
		public double? H11_ENERGY_HEATING;
		public double? H11_ENERGY_LIGHTING;
		public double? H12_REFUSE;
		public double? H13_REFRIDGERATOR;
		public double? H13_STOVE;
		public double? H13_VACUUM;
		public double? H13_WASHINGM;
		public double? H13_COMPUTER;
		public double? H13_SATELLITE;
		public double? H13_DVD_PLAYER;
		public double? H13_MOTORCAR;
		public double? H13_TV;
		public double? H13_RADIO;
		public double? H13_LANDLINE;
		public double? H13_CELLPHONE;
		public double? H13_POSTBOX;
		public double? H13_RESIDENTIAL_MAIL;
		public double? H13A_INTERNET;
		public double? H14_1LIVESTOCK;
		public double? H14_2POULTRY;
		public double? H14_3VEGETABLE;
		public double? H14_4OTHERCROPS;
		public double? H14_5FODDERGRAZING;
		public double? H14_6OTHER;
		public double? H14_0NONE;
		public double? H14A1_CATTLE;
		public double? H14A2_SHEEP;
		public double? H14A3_GOATS;
		public double? H14A4_PIGS;
		public double? H14A5_OTHERS;
		public double? H14B1_FARMLAND;
		public double? H14B2_BACKYARD_SCHOOL;
		public double? H14B3_COMMUNAL_TRIBALLAND;
		public double? H14B4_OTHER;
		public double? HM00_DEATHS;
		public double? HM00A_DEATHSNO;
		public double? DERH_HHAGE;
		public double? DERH_HHPOP;
		public double? DERH_HHSEX;
		public double? DERH_HINCOME;
		public double? DERH_HH_EMPLOY_STATUS;
		public double? DERH_HSIZE;
		public double? DERH_XPOP;
		public double? DERH_INCOME_CLASS;
		public double? H_GEOTYPE;
		public double? H_PROVINCE;
		public double? H_DISTRICT;
		public double? H_MUNIC;
		public double? AGRICULTURE_10PERCENT_WEIGHT;
	}
}