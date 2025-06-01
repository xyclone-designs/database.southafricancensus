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
				ProcessInt(LineSplit[00], logger, nameof(SN), out SN),
				ProcessInt(LineSplit[01], logger, nameof(H01_QUARTERS), out H01_QUARTERS),
				ProcessInt(LineSplit[02], logger, nameof(H02_MAINDWELLING), out H02_MAINDWELLING),
				ProcessInt(LineSplit[03], logger, nameof(H02_OTHERDWELLING), out H02_OTHERDWELLING),
				ProcessInt(LineSplit[04], logger, nameof(H02A_ROOF), out H02A_ROOF),
				ProcessInt(LineSplit[05], logger, nameof(H02A_WALL), out H02A_WALL),
				ProcessInt(LineSplit[06], logger, nameof(H03_DININGROOMS), out H03_DININGROOMS),
				ProcessInt(LineSplit[07], logger, nameof(H03_LIVINGROOMS), out H03_LIVINGROOMS),
				ProcessInt(LineSplit[08], logger, nameof(H03_DINING_LIVING), out H03_DINING_LIVING),
				ProcessInt(LineSplit[29], logger, nameof(H03_BEDROOMS), out H03_BEDROOMS),
				ProcessInt(LineSplit[20], logger, nameof(H03_STUDYROOMS), out H03_STUDYROOMS),
				ProcessInt(LineSplit[21], logger, nameof(H03_MULTIPLE_USE), out H03_MULTIPLE_USE),
				ProcessInt(LineSplit[22], logger, nameof(H03_OTHERROOMS), out H03_OTHERROOMS),
				ProcessInt(LineSplit[23], logger, nameof(H03_TOTROOMS), out H03_TOTROOMS),
				ProcessInt(LineSplit[24], logger, nameof(H04_TENURE), out H04_TENURE),
				ProcessInt(LineSplit[26], logger, nameof(H07_WATERPIPED), out H07_WATERPIPED),
				ProcessInt(LineSplit[27], logger, nameof(H08_WATERSOURCE), out H08_WATERSOURCE),
				ProcessInt(LineSplit[28], logger, nameof(H09_WATERSUPPLY), out H09_WATERSUPPLY),
				ProcessInt(LineSplit[29], logger, nameof(H09A_WATERSUPPLY), out H09A_WATERSUPPLY),
				ProcessInt(LineSplit[30], logger, nameof(H09B_ALT_WATERSOURCE), out H09B_ALT_WATERSOURCE),
				ProcessInt(LineSplit[31], logger, nameof(H10_TOILET), out H10_TOILET),
				ProcessInt(LineSplit[32], logger, nameof(H11_ENERGY_COOKING), out H11_ENERGY_COOKING),
				ProcessInt(LineSplit[33], logger, nameof(H11_ENERGY_HEATING), out H11_ENERGY_HEATING),
				ProcessInt(LineSplit[34], logger, nameof(H11_ENERGY_LIGHTING), out H11_ENERGY_LIGHTING),
				ProcessInt(LineSplit[35], logger, nameof(H12_REFUSE), out H12_REFUSE),
				ProcessInt(LineSplit[36], logger, nameof(H13_REFRIDGERATOR), out H13_REFRIDGERATOR),
				ProcessInt(LineSplit[37], logger, nameof(H13_STOVE), out H13_STOVE),
				ProcessInt(LineSplit[38], logger, nameof(H13_VACUUM), out H13_VACUUM),
				ProcessInt(LineSplit[39], logger, nameof(H13_WASHINGM), out H13_WASHINGM),
				ProcessInt(LineSplit[40], logger, nameof(H13_COMPUTER), out H13_COMPUTER),
				ProcessInt(LineSplit[41], logger, nameof(H13_SATELLITE), out H13_SATELLITE),
				ProcessInt(LineSplit[42], logger, nameof(H13_DVD_PLAYER), out H13_DVD_PLAYER),
				ProcessInt(LineSplit[43], logger, nameof(H13_MOTORCAR), out H13_MOTORCAR),
				ProcessInt(LineSplit[44], logger, nameof(H13_TV), out H13_TV),
				ProcessInt(LineSplit[45], logger, nameof(H13_RADIO), out H13_RADIO),
				ProcessInt(LineSplit[46], logger, nameof(H13_LANDLINE), out H13_LANDLINE),
				ProcessInt(LineSplit[47], logger, nameof(H13_CELLPHONE), out H13_CELLPHONE),
				ProcessInt(LineSplit[48], logger, nameof(H13_POSTBOX), out H13_POSTBOX),
				ProcessInt(LineSplit[49], logger, nameof(H13_RESIDENTIAL_MAIL), out H13_RESIDENTIAL_MAIL),
				ProcessInt(LineSplit[50], logger, nameof(H13A_INTERNET), out H13A_INTERNET),
				ProcessInt(LineSplit[51], logger, nameof(H14_1LIVESTOCK), out H14_1LIVESTOCK),
				ProcessInt(LineSplit[52], logger, nameof(H14_2POULTRY), out H14_2POULTRY),
				ProcessInt(LineSplit[53], logger, nameof(H14_3VEGETABLE), out H14_3VEGETABLE),
				ProcessInt(LineSplit[54], logger, nameof(H14_4OTHERCROPS), out H14_4OTHERCROPS),
				ProcessInt(LineSplit[55], logger, nameof(H14_5FODDERGRAZING), out H14_5FODDERGRAZING),
				ProcessInt(LineSplit[56], logger, nameof(H14_6OTHER), out H14_6OTHER),
				ProcessInt(LineSplit[57], logger, nameof(H14_0NONE), out H14_0NONE),
				ProcessInt(LineSplit[58], logger, nameof(H14A1_CATTLE), out H14A1_CATTLE),
				ProcessInt(LineSplit[59], logger, nameof(H14A2_SHEEP), out H14A2_SHEEP),
				ProcessInt(LineSplit[60], logger, nameof(H14A3_GOATS), out H14A3_GOATS),
				ProcessInt(LineSplit[61], logger, nameof(H14A4_PIGS), out H14A4_PIGS),
				ProcessInt(LineSplit[62], logger, nameof(H14A5_OTHERS), out H14A5_OTHERS),
				ProcessInt(LineSplit[63], logger, nameof(H14B1_FARMLAND), out H14B1_FARMLAND),
				ProcessInt(LineSplit[64], logger, nameof(H14B2_BACKYARD_SCHOOL), out H14B2_BACKYARD_SCHOOL),
				ProcessInt(LineSplit[65], logger, nameof(H14B3_COMMUNAL_TRIBALLAND), out H14B3_COMMUNAL_TRIBALLAND),
				ProcessInt(LineSplit[66], logger, nameof(H14B4_OTHER), out H14B4_OTHER),
				ProcessInt(LineSplit[67], logger, nameof(HM00_DEATHS), out HM00_DEATHS),
				ProcessInt(LineSplit[68], logger, nameof(HM00A_DEATHSNO), out HM00A_DEATHSNO),
				ProcessInt(LineSplit[69], logger, nameof(DERH_HHAGE), out DERH_HHAGE),
				ProcessInt(LineSplit[60], logger, nameof(DERH_HHPOP), out DERH_HHPOP),
				ProcessInt(LineSplit[61], logger, nameof(DERH_HHSEX), out DERH_HHSEX),
				ProcessInt(LineSplit[60], logger, nameof(DERH_HINCOME), out DERH_HINCOME),
				ProcessInt(LineSplit[61], logger, nameof(DERH_HH_EMPLOY_STATUS), out DERH_HH_EMPLOY_STATUS),
				ProcessInt(LineSplit[62], logger, nameof(DERH_HSIZE), out DERH_HSIZE),
				ProcessInt(LineSplit[63], logger, nameof(DERH_XPOP), out DERH_XPOP),
				ProcessInt(LineSplit[64], logger, nameof(DERH_INCOME_CLASS), out DERH_INCOME_CLASS),
				ProcessInt(LineSplit[65], logger, nameof(H_GEOTYPE), out H_GEOTYPE),
				ProcessInt(LineSplit[66], logger, nameof(H_PROVINCE), out H_PROVINCE),
				ProcessInt(LineSplit[67], logger, nameof(H_DISTRICT), out H_DISTRICT),
				ProcessInt(LineSplit[60], logger, nameof(H_MUNIC), out H_MUNIC),
				ProcessInt(LineSplit[69], logger, nameof(AGRICULTURE_10PERCENT_WEIGHT), out AGRICULTURE_10PERCENT_WEIGHT),


			}.Any(_ => _ == false)) logger.WriteLine();
		}
		
		
		
		
		
		
		public int? SN;
		public int? H01_QUARTERS;
		public int? H02_MAINDWELLING;
		public int? H02_OTHERDWELLING;
		public int? H02A_ROOF;
		public int? H02A_WALL;
		public int? H03_DININGROOMS;
		public int? H03_LIVINGROOMS;
		public int? H03_DINING_LIVING;
		public int? H03_BEDROOMS;
		public int? H03_STUDYROOMS;
		public int? H03_MULTIPLE_USE;
		public int? H03_OTHERROOMS;
		public int? H03_TOTROOMS;
		public int? H04_TENURE;
		public int? H07_WATERPIPED;
		public int? H08_WATERSOURCE;
		public int? H09_WATERSUPPLY;
		public int? H09A_WATERSUPPLY;
		public int? H09B_ALT_WATERSOURCE;
		public int? H10_TOILET;
		public int? H11_ENERGY_COOKING;
		public int? H11_ENERGY_HEATING;
		public int? H11_ENERGY_LIGHTING;
		public int? H12_REFUSE;
		public int? H13_REFRIDGERATOR;
		public int? H13_STOVE;
		public int? H13_VACUUM;
		public int? H13_WASHINGM;
		public int? H13_COMPUTER;
		public int? H13_SATELLITE;
		public int? H13_DVD_PLAYER;
		public int? H13_MOTORCAR;
		public int? H13_TV;
		public int? H13_RADIO;
		public int? H13_LANDLINE;
		public int? H13_CELLPHONE;
		public int? H13_POSTBOX;
		public int? H13_RESIDENTIAL_MAIL;
		public int? H13A_INTERNET;
		public int? H14_1LIVESTOCK;
		public int? H14_2POULTRY;
		public int? H14_3VEGETABLE;
		public int? H14_4OTHERCROPS;
		public int? H14_5FODDERGRAZING;
		public int? H14_6OTHER;
		public int? H14_0NONE;
		public int? H14A1_CATTLE;
		public int? H14A2_SHEEP;
		public int? H14A3_GOATS;
		public int? H14A4_PIGS;
		public int? H14A5_OTHERS;
		public int? H14B1_FARMLAND;
		public int? H14B2_BACKYARD_SCHOOL;
		public int? H14B3_COMMUNAL_TRIBALLAND;
		public int? H14B4_OTHER;
		public int? HM00_DEATHS;
		public int? HM00A_DEATHSNO;
		public int? DERH_HHAGE;
		public int? DERH_HHPOP;
		public int? DERH_HHSEX;
		public int? DERH_HINCOME;
		public int? DERH_HH_EMPLOY_STATUS;
		public int? DERH_HSIZE;
		public int? DERH_XPOP;
		public int? DERH_INCOME_CLASS;
		public int? H_GEOTYPE;
		public int? H_PROVINCE;
		public int? H_DISTRICT;
		public int? H_MUNIC;
		public int? AGRICULTURE_10PERCENT_WEIGHT;
	}
}