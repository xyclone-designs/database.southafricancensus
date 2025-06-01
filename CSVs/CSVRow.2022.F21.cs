using System.IO;
using System.Linq;

namespace Database.SouthAfricanCensus.CSVs
{
	public class CSVRow2022F21 : CSVRow2022
    {
		public CSVRow2022F21(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{
				ProcessInt(LineSplit[00], logger, nameof(QID), out QID),
				ProcessInt(LineSplit[01], logger, nameof(PID), out PID),
				ProcessInt(LineSplit[02], logger, nameof(P02_SEX), out P02_SEX),
				ProcessInt(LineSplit[03], logger, nameof(P03_YEAR), out P03_YEAR),
				ProcessInt(LineSplit[04], logger, nameof(P03_MONTH), out P03_MONTH),
				ProcessInt(LineSplit[05], logger, nameof(AGE_GROUP), out AGE_GROUP),
				ProcessInt(LineSplit[06], logger, nameof(P04_AGE), out P04_AGE),
				ProcessInt(LineSplit[07], logger, nameof(P05_RELATION), out P05_RELATION),
				ProcessInt(LineSplit[08], logger, nameof(P06_MARITAL_ST), out P06_MARITAL_ST),
				ProcessInt(LineSplit[09], logger, nameof(P07A_POP_GROUP), out P07A_POP_GROUP),
				ProcessInt(LineSplit[10], logger, nameof(P08_LANGUAGE), out P08_LANGUAGE),
				ProcessInt(LineSplit[11], logger, nameof(P09_RELIGIOUS_AFFILIATION), out P09_RELIGIOUS_AFFILIATION),
				ProcessInt(LineSplit[12], logger, nameof(P10_CITIZENSHIP), out P10_CITIZENSHIP),
				ProcessInt(LineSplit[13], logger, nameof(P11_PROV_POB), out P11_PROV_POB),
				ProcessInt(LineSplit[14], logger, nameof(P12A_COUNTRYOFBIRTH), out P12A_COUNTRYOFBIRTH),
				ProcessInt(LineSplit[15], logger, nameof(DERP_BIRTH_REGION), out DERP_BIRTH_REGION),
				ProcessInt(LineSplit[16], logger, nameof(P12B_YEARMOVED), out P12B_YEARMOVED),
				ProcessInt(LineSplit[17], logger, nameof(P13A_USUALRES), out P13A_USUALRES),
				ProcessInt(LineSplit[18], logger, nameof(P14_SINCE2011), out P14_SINCE2011),
				ProcessInt(LineSplit[19], logger, nameof(P15A_RESMONTHMOVED), out P15A_RESMONTHMOVED),
				ProcessInt(LineSplit[20], logger, nameof(P15B_RESYEARMOVED), out P15B_RESYEARMOVED),
				ProcessInt(LineSplit[21], logger, nameof(DERP_PREVRESPROV), out DERP_PREVRESPROV),
				ProcessInt(LineSplit[22], logger, nameof(DERP_PREV_MUNIC), out DERP_PREV_MUNIC),
				ProcessInt(LineSplit[23], logger, nameof(DERP_USUALRESPROV), out DERP_USUALRESPROV),
				ProcessInt(LineSplit[24], logger, nameof(DERP_USUALRES_MUNIC), out DERP_USUALRES_MUNIC),
				ProcessInt(LineSplit[25], logger, nameof(P16_MAIN_REASON), out P16_MAIN_REASON),
				ProcessInt(LineSplit[26], logger, nameof(P17A_SEEING), out P17A_SEEING),
				ProcessInt(LineSplit[27], logger, nameof(P17B_HEARING), out P17B_HEARING),
				ProcessInt(LineSplit[28], logger, nameof(P17C_COMMUNICATION), out P17C_COMMUNICATION),
				ProcessInt(LineSplit[29], logger, nameof(P17D_WALKING), out P17D_WALKING),
				ProcessInt(LineSplit[30], logger, nameof(P17E_REMEMBERING), out P17E_REMEMBERING),
				ProcessInt(LineSplit[31], logger, nameof(P17F_SELF_CARE), out P17F_SELF_CARE),
				ProcessInt(LineSplit[32], logger, nameof(P17A_DEVMEDEYEGLAS), out P17A_DEVMEDEYEGLAS),
				ProcessInt(LineSplit[33], logger, nameof(P17B_DEVMEDHEARINGAID), out P17B_DEVMEDHEARINGAID),
				ProcessInt(LineSplit[34], logger, nameof(P17C_DEVMEWALKINGSTICK), out P17C_DEVMEWALKINGSTICK),
				ProcessInt(LineSplit[35], logger, nameof(P17E_PROSTHESIS), out P17E_PROSTHESIS),
				ProcessInt(LineSplit[36], logger, nameof(P17D_DEVMEDWHEELCHAIR), out P17D_DEVMEDWHEELCHAIR),
				ProcessInt(LineSplit[37], logger, nameof(P17F_DEVMED_OTHER), out P17F_DEVMED_OTHER),
				ProcessInt(LineSplit[38], logger, nameof(DISABILITY_STATUS), out DISABILITY_STATUS),
				ProcessInt(LineSplit[39], logger, nameof(P18A_MOTHERALIVE), out P18A_MOTHERALIVE),
				ProcessInt(LineSplit[40], logger, nameof(P18B_FATHERALIVE), out P18B_FATHERALIVE),
				ProcessInt(LineSplit[41], logger, nameof(P19_ECD_ATTENDANCE), out P19_ECD_ATTENDANCE),
				ProcessInt(LineSplit[42], logger, nameof(P20_EDUINST), out P20_EDUINST),
				ProcessInt(LineSplit[43], logger, nameof(P21_EDULEVEL), out P21_EDULEVEL),
				ProcessInt(LineSplit[44], logger, nameof(P22_EDUFIELD), out P22_EDUFIELD),
				ProcessInt(LineSplit[45], logger, nameof(PERS_WGT), out PERS_WGT),

			}.Any(_ => _ == false)) logger.WriteLine();
		}
		
		public int? QID;
		public int? PID;
		public int? P02_SEX;
		public int? P03_YEAR;
		public int? P03_MONTH;
		public int? AGE_GROUP;
		public int? P04_AGE;
		public int? P05_RELATION;
		public int? P06_MARITAL_ST;
		public int? P07A_POP_GROUP;
		public int? P08_LANGUAGE;
		public int? P09_RELIGIOUS_AFFILIATION;
		public int? P10_CITIZENSHIP;
		public int? P11_PROV_POB;
		public int? P12A_COUNTRYOFBIRTH;
		public int? DERP_BIRTH_REGION;
		public int? P12B_YEARMOVED;
		public int? P13A_USUALRES;
		public int? P14_SINCE2011;
		public int? P15A_RESMONTHMOVED;
		public int? P15B_RESYEARMOVED;
		public int? DERP_PREVRESPROV;
		public int? DERP_PREV_MUNIC;
		public int? DERP_USUALRESPROV;
		public int? DERP_USUALRES_MUNIC;
		public int? P16_MAIN_REASON;
		public int? P17A_SEEING;
		public int? P17B_HEARING;
		public int? P17C_COMMUNICATION;
		public int? P17D_WALKING;
		public int? P17E_REMEMBERING;
		public int? P17F_SELF_CARE;
		public int? P17A_DEVMEDEYEGLAS;
		public int? P17B_DEVMEDHEARINGAID;
		public int? P17C_DEVMEWALKINGSTICK;
		public int? P17E_PROSTHESIS;
		public int? P17D_DEVMEDWHEELCHAIR;
		public int? P17F_DEVMED_OTHER;
		public int? DISABILITY_STATUS;
		public int? P18A_MOTHERALIVE;
		public int? P18B_FATHERALIVE;
		public int? P19_ECD_ATTENDANCE;
		public int? P20_EDUINST;
		public int? P21_EDULEVEL;
		public int? P22_EDUFIELD;
		public int? PERS_WGT;
	}
}