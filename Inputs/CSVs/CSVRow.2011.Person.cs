using System.IO;
using System.Linq;
using XycloneDesigns.Database.SouthAfricanCensus.Tables;

namespace Database.SouthAfricanCensus.Inputs.CSVs
{
	public class CSVRow2011Person : CSVRow2011
    {
		public CSVRow2011Person(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{
				ProcessDouble(LineSplit[00], logger, nameof(QN_TYPE),out QN_TYPE),
				ProcessLong(LineSplit[01], logger, nameof(SN),out SN),
				ProcessDouble(LineSplit[02], logger, nameof(F00_NR),out F00_NR),
				ProcessDouble(LineSplit[03], logger, nameof(F02_AGE),out F02_AGE),
				ProcessDouble(LineSplit[04], logger, nameof(F03_SEX),out F03_SEX),
				ProcessDouble(LineSplit[05], logger, nameof(P01_DAY),out P01_DAY),
				ProcessDouble(LineSplit[06], logger, nameof(P01_MONTH),out P01_MONTH),
				ProcessDouble(LineSplit[07], logger, nameof(P01_YEAR),out P01_YEAR),
				ProcessDouble(LineSplit[08], logger, nameof(P02_RELATION),out P02_RELATION),
				ProcessDouble(LineSplit[09], logger, nameof(P03_MARITAL_ST),out P03_MARITAL_ST),
				ProcessDouble(LineSplit[10], logger, nameof(P04_SPN),out P04_SPN),
				ProcessDouble(LineSplit[11], logger, nameof(P05_POP_GROUP),out P05_POP_GROUP),
				ProcessDouble(LineSplit[12], logger, nameof(P06A_LANGUAGE),out P06A_LANGUAGE),
				ProcessDouble(LineSplit[13], logger, nameof(P06B_LANGUAGE),out P06B_LANGUAGE),
				ProcessDouble(LineSplit[14], logger, nameof(P07_PROV_POB),out P07_PROV_POB),
				ProcessDouble(LineSplit[15], logger, nameof(P08_COUNTRYOFBIRTH),out P08_COUNTRYOFBIRTH),
				ProcessDouble(LineSplit[16], logger, nameof(P08A_YEARMOVED),out P08A_YEARMOVED),
				ProcessDouble(LineSplit[17], logger, nameof(P09_CITIZENSHIP),out P09_CITIZENSHIP),
				ProcessDouble(LineSplit[18], logger, nameof(P10_USUALRES),out P10_USUALRES),
				ProcessDouble(LineSplit[19], logger, nameof(P10A_USUALRESPROV),out P10A_USUALRESPROV),
				ProcessDouble(LineSplit[20], logger, nameof(P10B_USUALRESMUNIC),out P10B_USUALRESMUNIC),
				ProcessDouble(LineSplit[21], logger, nameof(P11_SINCE2001),out P11_SINCE2001),
				ProcessDouble(LineSplit[22], logger, nameof(P11A_RESMONTHMOVED),out P11A_RESMONTHMOVED),
				ProcessDouble(LineSplit[23], logger, nameof(P11A_RESYEARMOVED),out P11A_RESYEARMOVED),
				ProcessDouble(LineSplit[24], logger, nameof(P11B_PREVRESPROV),out P11B_PREVRESPROV),
				ProcessDouble(LineSplit[25], logger, nameof(P11C_PREVRESMUNIC),out P11C_PREVRESMUNIC),
				ProcessDouble(LineSplit[26], logger, nameof(P12A_SEEING),out P12A_SEEING),
				ProcessDouble(LineSplit[27], logger, nameof(P12B_HEARING),out P12B_HEARING),
				ProcessDouble(LineSplit[28], logger, nameof(P12C_COMMUNICATION),out P12C_COMMUNICATION),
				ProcessDouble(LineSplit[29], logger, nameof(P12D_WALKING),out P12D_WALKING),
				ProcessDouble(LineSplit[30], logger, nameof(P12E_REMEMBERING),out P12E_REMEMBERING),
				ProcessDouble(LineSplit[31], logger, nameof(P12F_SELF_CARE),out P12F_SELF_CARE),
				ProcessDouble(LineSplit[32], logger, nameof(P13A_DEVMEDEYEGLAS),out P13A_DEVMEDEYEGLAS),
				ProcessDouble(LineSplit[33], logger, nameof(P13B_DEVMEDHEARINGAID),out P13B_DEVMEDHEARINGAID),
				ProcessDouble(LineSplit[34], logger, nameof(P13C_DEVMEWALKINGSTICK),out P13C_DEVMEWALKINGSTICK),
				ProcessDouble(LineSplit[35], logger, nameof(P13D_DEVMEDWHEELCHAIR),out P13D_DEVMEDWHEELCHAIR),
				ProcessDouble(LineSplit[36], logger, nameof(P13E_DEVMEDCHRONIC),out P13E_DEVMEDCHRONIC),
				ProcessDouble(LineSplit[37], logger, nameof(P14_MOTHERALIVE),out P14_MOTHERALIVE),
				ProcessDouble(LineSplit[38], logger, nameof(P14A_MOTHERPNR),out P14A_MOTHERPNR),
				ProcessDouble(LineSplit[39], logger, nameof(P15_FATHERALIVE),out P15_FATHERALIVE),
				ProcessDouble(LineSplit[40], logger, nameof(P15A_FATHERPNR),out P15A_FATHERPNR),
				ProcessDouble(LineSplit[41], logger, nameof(P16_INCOME),out P16_INCOME),
				ProcessDouble(LineSplit[42], logger, nameof(P17_SCHOOLATTEND),out P17_SCHOOLATTEND),
				ProcessDouble(LineSplit[43], logger, nameof(P18_EDUINST),out P18_EDUINST),
				ProcessDouble(LineSplit[44], logger, nameof(P19_EDUPUBPRIV),out P19_EDUPUBPRIV),
				ProcessDouble(LineSplit[45], logger, nameof(P20_EDULEVEL),out P20_EDULEVEL),
				ProcessDouble(LineSplit[46], logger, nameof(P21_EDUFIELD),out P21_EDUFIELD),
				ProcessDouble(LineSplit[47], logger, nameof(P22A_EDULITERACY),out P22A_EDULITERACY),
				ProcessDouble(LineSplit[48], logger, nameof(P22B_EDULITERACY),out P22B_EDULITERACY),
				ProcessDouble(LineSplit[49], logger, nameof(P22C_EDULITERACY),out P22C_EDULITERACY),
				ProcessDouble(LineSplit[50], logger, nameof(P22D_EDULITERACY),out P22D_EDULITERACY),
				ProcessDouble(LineSplit[51], logger, nameof(P22E_EDULITERACY),out P22E_EDULITERACY),
				ProcessDouble(LineSplit[52], logger, nameof(P22F_EDULITERACY),out P22F_EDULITERACY),
				ProcessDouble(LineSplit[53], logger, nameof(P23A_EMPLOYMENTSTATUS),out P23A_EMPLOYMENTSTATUS),
				ProcessDouble(LineSplit[54], logger, nameof(P23B_EMPLOYMENTSTATUS),out P23B_EMPLOYMENTSTATUS),
				ProcessDouble(LineSplit[55], logger, nameof(P23C_EMPLOYMENTSTATUS),out P23C_EMPLOYMENTSTATUS),
				ProcessDouble(LineSplit[56], logger, nameof(P24_TEMPWORKABSENCE),out P24_TEMPWORKABSENCE),
				ProcessDouble(LineSplit[57], logger, nameof(P25_UNEMPLOYMENT),out P25_UNEMPLOYMENT),
				ProcessDouble(LineSplit[58], logger, nameof(P26_UNEMPLOYMENT),out P26_UNEMPLOYMENT),
				ProcessDouble(LineSplit[59], logger, nameof(P27_REASONSNOTWORKING),out P27_REASONSNOTWORKING),
				ProcessDouble(LineSplit[60], logger, nameof(P28_WORKAVAILABILITY),out P28_WORKAVAILABILITY),
				ProcessDouble(LineSplit[61], logger, nameof(P29A_INDUSTRY),out P29A_INDUSTRY),
				ProcessDouble(LineSplit[62], logger, nameof(P30A_OCCUPATION),out P30A_OCCUPATION),
				ProcessDouble(LineSplit[63], logger, nameof(P31_SECTOR),out P31_SECTOR),
				ProcessDouble(LineSplit[64], logger, nameof(P32_CHILDEVERBORN),out P32_CHILDEVERBORN),
				ProcessDouble(LineSplit[65], logger, nameof(P33_AGEFIRSTBIRTH),out P33_AGEFIRSTBIRTH),
				ProcessDouble(LineSplit[66], logger, nameof(P34_CHILDBORNBOYS),out P34_CHILDBORNBOYS),
				ProcessDouble(LineSplit[67], logger, nameof(P34_CHILDBORNGIRLS),out P34_CHILDBORNGIRLS),
				ProcessDouble(LineSplit[68], logger, nameof(P34_CHILDBORNTOT),out P34_CHILDBORNTOT),
				ProcessDouble(LineSplit[69], logger, nameof(P38_LASTCHILDDAY),out P38_LASTCHILDDAY),
				ProcessDouble(LineSplit[70], logger, nameof(P38_LASTCHILDMO),out P38_LASTCHILDMO),
				ProcessDouble(LineSplit[71], logger, nameof(P38_LASTCHILDYR),out P38_LASTCHILDYR),
				ProcessDouble(LineSplit[72], logger, nameof(P39_LASTCHILDSEX),out P39_LASTCHILDSEX),
				ProcessDouble(LineSplit[73], logger, nameof(P40_LASTCHILDALIVE),out P40_LASTCHILDALIVE),
				ProcessDouble(LineSplit[74], logger, nameof(P41_DATEOFDEATHOFLASTCHILDDAZ),out P41_DATEOFDEATHOFLASTCHILDDAZ),
				ProcessDouble(LineSplit[75], logger, nameof(P41_DATEOFDEATHOFLASTCHILDMONTJ),out P41_DATEOFDEATHOFLASTCHILDMONTJ),
				ProcessDouble(LineSplit[76], logger, nameof(P41_DATEOFDEATHOFLASTCHILDYEAT),out P41_DATEOFDEATHOFLASTCHILDYEAT),
				ProcessDouble(LineSplit[77], logger, nameof(DERP_BIRTH_REGION),out DERP_BIRTH_REGION),
				ProcessDouble(LineSplit[78], logger, nameof(DERP_PREVRESPROV),out DERP_PREVRESPROV),
				ProcessDouble(LineSplit[79], logger, nameof(DERP_USUALRESPROV),out DERP_USUALRESPROV),
				ProcessDouble(LineSplit[80], logger, nameof(DERP_EMPLOY_STATUS),out DERP_EMPLOY_STATUS),
				ProcessDouble(LineSplit[81], logger, nameof(DERP_EMPLOY_STATUS_OFFICIAL),out DERP_EMPLOY_STATUS_OFFICIAL),
				ProcessDouble(LineSplit[82], logger, nameof(DERP_EMPLOY_STATUS_EXPANDED),out DERP_EMPLOY_STATUS_EXPANDED),
				ProcessDouble(LineSplit[83], logger, nameof(DERP_INDUSTRY),out DERP_INDUSTRY),
				ProcessDouble(LineSplit[84], logger, nameof(DERP_OCCUPATION),out DERP_OCCUPATION),
				ProcessDouble(LineSplit[85], logger, nameof(OCCUP_LEV01),out OCCUP_LEV01),
				ProcessDouble(LineSplit[86], logger, nameof(OCCUP_LEV02),out OCCUP_LEV02),
				ProcessDouble(LineSplit[87], logger, nameof(OCCUP_LEV03),out OCCUP_LEV03),
				ProcessDouble(LineSplit[88], logger, nameof(OCCUP_LEV04),out OCCUP_LEV04),
				ProcessDouble(LineSplit[89], logger, nameof(DERP_Sector),out DERP_Sector),
				ProcessDouble(LineSplit[90], logger, nameof(DERP_EDUCATIONAL_LEVEL),out DERP_EDUCATIONAL_LEVEL),
				ProcessDouble(LineSplit[91], logger, nameof(DERP_BIRTHS_12MONTHS),out DERP_BIRTHS_12MONTHS),
				ProcessDouble(LineSplit[92], logger, nameof(P_GEOTYPE),out P_GEOTYPE),
				ProcessDouble(LineSplit[93], logger, nameof(P_PROVINCE),out P_PROVINCE),
				ProcessDouble(LineSplit[94], logger, nameof(P_DISTRICT),out P_DISTRICT),
				ProcessDouble(LineSplit[95], logger, nameof(P_MUNIC),out P_MUNIC),
				ProcessDouble(LineSplit[96], logger, nameof(PERSON_10PER_WGT),out PERSON_10PER_WGT),

			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public double? QN_TYPE;
		public long? SN;
		public double? F00_NR;
		public double? F02_AGE;
		public double? F03_SEX;
		public double? P01_DAY;
		public double? P01_MONTH;
		public double? P01_YEAR;
		public double? P02_RELATION;
		public double? P03_MARITAL_ST;
		public double? P04_SPN;
		public double? P05_POP_GROUP;
		public double? P06A_LANGUAGE;
		public double? P06B_LANGUAGE;
		public double? P07_PROV_POB;
		public double? P08_COUNTRYOFBIRTH;
		public double? P08A_YEARMOVED;
		public double? P09_CITIZENSHIP;
		public double? P10_USUALRES;
		public double? P10A_USUALRESPROV;
		public double? P10B_USUALRESMUNIC;
		public double? P11_SINCE2001;
		public double? P11A_RESMONTHMOVED;
		public double? P11A_RESYEARMOVED;
		public double? P11B_PREVRESPROV;
		public double? P11C_PREVRESMUNIC;
		public double? P12A_SEEING;
		public double? P12B_HEARING;
		public double? P12C_COMMUNICATION;
		public double? P12D_WALKING;
		public double? P12E_REMEMBERING;
		public double? P12F_SELF_CARE;
		public double? P13A_DEVMEDEYEGLAS;
		public double? P13B_DEVMEDHEARINGAID;
		public double? P13C_DEVMEWALKINGSTICK;
		public double? P13D_DEVMEDWHEELCHAIR;
		public double? P13E_DEVMEDCHRONIC;
		public double? P14_MOTHERALIVE;
		public double? P14A_MOTHERPNR;
		public double? P15_FATHERALIVE;
		public double? P15A_FATHERPNR;
		public double? P16_INCOME;
		public double? P17_SCHOOLATTEND;
		public double? P18_EDUINST;
		public double? P19_EDUPUBPRIV;
		public double? P20_EDULEVEL;
		public double? P21_EDUFIELD;
		public double? P22A_EDULITERACY;
		public double? P22B_EDULITERACY;
		public double? P22C_EDULITERACY;
		public double? P22D_EDULITERACY;
		public double? P22E_EDULITERACY;
		public double? P22F_EDULITERACY;
		public double? P23A_EMPLOYMENTSTATUS;
		public double? P23B_EMPLOYMENTSTATUS;
		public double? P23C_EMPLOYMENTSTATUS;
		public double? P24_TEMPWORKABSENCE;
		public double? P25_UNEMPLOYMENT;
		public double? P26_UNEMPLOYMENT;
		public double? P27_REASONSNOTWORKING;
		public double? P28_WORKAVAILABILITY;
		public double? P29A_INDUSTRY;
		public double? P30A_OCCUPATION;
		public double? P31_SECTOR;
		public double? P32_CHILDEVERBORN;
		public double? P33_AGEFIRSTBIRTH;
		public double? P34_CHILDBORNBOYS;
		public double? P34_CHILDBORNGIRLS;
		public double? P34_CHILDBORNTOT;
		public double? P38_LASTCHILDDAY;
		public double? P38_LASTCHILDMO;
		public double? P38_LASTCHILDYR;
		public double? P39_LASTCHILDSEX;
		public double? P40_LASTCHILDALIVE;
		public double? P41_DATEOFDEATHOFLASTCHILDDAZ;
		public double? P41_DATEOFDEATHOFLASTCHILDMONTJ;
		public double? P41_DATEOFDEATHOFLASTCHILDYEAT;
		public double? DERP_BIRTH_REGION;
		public double? DERP_PREVRESPROV;
		public double? DERP_USUALRESPROV;
		public double? DERP_EMPLOY_STATUS;
		public double? DERP_EMPLOY_STATUS_OFFICIAL;
		public double? DERP_EMPLOY_STATUS_EXPANDED;
		public double? DERP_INDUSTRY;
		public double? DERP_OCCUPATION;
		public double? OCCUP_LEV01;
		public double? OCCUP_LEV02;
		public double? OCCUP_LEV03;
		public double? OCCUP_LEV04;
		public double? DERP_Sector;
		public double? DERP_EDUCATIONAL_LEVEL;
		public double? DERP_BIRTHS_12MONTHS;
		public double? P_GEOTYPE;
		public double? P_PROVINCE;
		public double? P_DISTRICT;
		public double? P_MUNIC;
		public double? PERSON_10PER_WGT;

		public RecordsPerson AsRecord()
		{
			return new RecordsPerson { };
		}
	}
}