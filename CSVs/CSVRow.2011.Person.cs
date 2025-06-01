using System.IO;
using System.Linq;

namespace Database.SouthAfricanCensus.CSVs
{
	public class CSVRow2011Person : CSVRow2011
    {
		public CSVRow2011Person(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{
				ProcessInt(LineSplit[00], logger, nameof(QN_TYPE),out QN_TYPE),
				ProcessInt(LineSplit[00], logger, nameof(SN),out SN),
				ProcessInt(LineSplit[00], logger, nameof(F00_NR),out F00_NR),
				ProcessInt(LineSplit[00], logger, nameof(F02_AGE),out F02_AGE),
				ProcessInt(LineSplit[00], logger, nameof(F03_SEX),out F03_SEX),
				ProcessInt(LineSplit[00], logger, nameof(P01_DAY),out P01_DAY),
				ProcessInt(LineSplit[00], logger, nameof(P01_MONTH),out P01_MONTH),
				ProcessInt(LineSplit[00], logger, nameof(P01_YEAR),out P01_YEAR),
				ProcessInt(LineSplit[00], logger, nameof(P02_RELATION),out P02_RELATION),
				ProcessInt(LineSplit[00], logger, nameof(P03_MARITAL_ST),out P03_MARITAL_ST),
				ProcessInt(LineSplit[00], logger, nameof(P04_SPN),out P04_SPN),
				ProcessInt(LineSplit[00], logger, nameof(P05_POP_GROUP),out P05_POP_GROUP),
				ProcessInt(LineSplit[00], logger, nameof(P06A_LANGUAGE),out P06A_LANGUAGE),
				ProcessInt(LineSplit[00], logger, nameof(P06B_LANGUAGE),out P06B_LANGUAGE),
				ProcessInt(LineSplit[00], logger, nameof(P07_PROV_POB),out P07_PROV_POB),
				ProcessInt(LineSplit[00], logger, nameof(P08_COUNTRYOFBIRTH),out P08_COUNTRYOFBIRTH),
				ProcessInt(LineSplit[00], logger, nameof(P08A_YEARMOVED),out P08A_YEARMOVED),
				ProcessInt(LineSplit[00], logger, nameof(P09_CITIZENSHIP),out P09_CITIZENSHIP),
				ProcessInt(LineSplit[00], logger, nameof(P10_USUALRES),out P10_USUALRES),
				ProcessInt(LineSplit[00], logger, nameof(P10A_USUALRESPROV),out P10A_USUALRESPROV),
				ProcessInt(LineSplit[00], logger, nameof(P10B_USUALRESMUNIC),out P10B_USUALRESMUNIC),
				ProcessInt(LineSplit[00], logger, nameof(P11_SINCE2001),out P11_SINCE2001),
				ProcessInt(LineSplit[00], logger, nameof(P11A_RESMONTHMOVED),out P11A_RESMONTHMOVED),
				ProcessInt(LineSplit[00], logger, nameof(P11A_RESYEARMOVED),out P11A_RESYEARMOVED),
				ProcessInt(LineSplit[00], logger, nameof(P11B_PREVRESPROV),out P11B_PREVRESPROV),
				ProcessInt(LineSplit[00], logger, nameof(P11C_PREVRESMUNIC),out P11C_PREVRESMUNIC),
				ProcessInt(LineSplit[00], logger, nameof(P12A_SEEING),out P12A_SEEING),
				ProcessInt(LineSplit[00], logger, nameof(P12B_HEARING),out P12B_HEARING),
				ProcessInt(LineSplit[00], logger, nameof(P12C_COMMUNICATION),out P12C_COMMUNICATION),
				ProcessInt(LineSplit[00], logger, nameof(P12D_WALKING),out P12D_WALKING),
				ProcessInt(LineSplit[00], logger, nameof(P12E_REMEMBERING),out P12E_REMEMBERING),
				ProcessInt(LineSplit[00], logger, nameof(P12F_SELF_CARE),out P12F_SELF_CARE),
				ProcessInt(LineSplit[00], logger, nameof(P13A_DEVMEDEYEGLAS),out P13A_DEVMEDEYEGLAS),
				ProcessInt(LineSplit[00], logger, nameof(P13B_DEVMEDHEARINGAID),out P13B_DEVMEDHEARINGAID),
				ProcessInt(LineSplit[00], logger, nameof(P13C_DEVMEWALKINGSTICK),out P13C_DEVMEWALKINGSTICK),
				ProcessInt(LineSplit[00], logger, nameof(P13D_DEVMEDWHEELCHAIR),out P13D_DEVMEDWHEELCHAIR),
				ProcessInt(LineSplit[00], logger, nameof(P13E_DEVMEDCHRONIC),out P13E_DEVMEDCHRONIC),
				ProcessInt(LineSplit[00], logger, nameof(P14_MOTHERALIVE),out P14_MOTHERALIVE),
				ProcessInt(LineSplit[00], logger, nameof(P14A_MOTHERPNR),out P14A_MOTHERPNR),
				ProcessInt(LineSplit[00], logger, nameof(P15_FATHERALIVE),out P15_FATHERALIVE),
				ProcessInt(LineSplit[00], logger, nameof(P15A_FATHERPNR),out P15A_FATHERPNR),
				ProcessInt(LineSplit[00], logger, nameof(P16_INCOME),out P16_INCOME),
				ProcessInt(LineSplit[00], logger, nameof(P17_SCHOOLATTEND),out P17_SCHOOLATTEND),
				ProcessInt(LineSplit[00], logger, nameof(P18_EDUINST),out P18_EDUINST),
				ProcessInt(LineSplit[00], logger, nameof(P19_EDUPUBPRIV),out P19_EDUPUBPRIV),
				ProcessInt(LineSplit[00], logger, nameof(P20_EDULEVEL),out P20_EDULEVEL),
				ProcessInt(LineSplit[00], logger, nameof(P21_EDUFIELD),out P21_EDUFIELD),
				ProcessInt(LineSplit[00], logger, nameof(P22A_EDULITERACY),out P22A_EDULITERACY),
				ProcessInt(LineSplit[00], logger, nameof(P22B_EDULITERACY),out P22B_EDULITERACY),
				ProcessInt(LineSplit[00], logger, nameof(P22C_EDULITERACY),out P22C_EDULITERACY),
				ProcessInt(LineSplit[00], logger, nameof(P22D_EDULITERACY),out P22D_EDULITERACY),
				ProcessInt(LineSplit[00], logger, nameof(P22E_EDULITERACY),out P22E_EDULITERACY),
				ProcessInt(LineSplit[00], logger, nameof(P22F_EDULITERACY),out P22F_EDULITERACY),
				ProcessInt(LineSplit[00], logger, nameof(P23A_EMPLOYMENTSTATUS),out P23A_EMPLOYMENTSTATUS),
				ProcessInt(LineSplit[00], logger, nameof(P23B_EMPLOYMENTSTATUS),out P23B_EMPLOYMENTSTATUS),
				ProcessInt(LineSplit[00], logger, nameof(P23C_EMPLOYMENTSTATUS),out P23C_EMPLOYMENTSTATUS),
				ProcessInt(LineSplit[00], logger, nameof(P24_TEMPWORKABSENCE),out P24_TEMPWORKABSENCE),
				ProcessInt(LineSplit[00], logger, nameof(P25_UNEMPLOYMENT),out P25_UNEMPLOYMENT),
				ProcessInt(LineSplit[00], logger, nameof(P26_UNEMPLOYMENT),out P26_UNEMPLOYMENT),
				ProcessInt(LineSplit[00], logger, nameof(P27_REASONSNOTWORKING),out P27_REASONSNOTWORKING),
				ProcessInt(LineSplit[00], logger, nameof(P28_WORKAVAILABILITY),out P28_WORKAVAILABILITY),
				ProcessInt(LineSplit[00], logger, nameof(P29A_INDUSTRY),out P29A_INDUSTRY),
				ProcessInt(LineSplit[00], logger, nameof(P30A_OCCUPATION),out P30A_OCCUPATION),
				ProcessInt(LineSplit[00], logger, nameof(P31_SECTOR),out P31_SECTOR),
				ProcessInt(LineSplit[00], logger, nameof(P32_CHILDEVERBORN),out P32_CHILDEVERBORN),
				ProcessInt(LineSplit[00], logger, nameof(P33_AGEFIRSTBIRTH),out P33_AGEFIRSTBIRTH),
				ProcessInt(LineSplit[00], logger, nameof(P34_CHILDBORNBOYS),out P34_CHILDBORNBOYS),
				ProcessInt(LineSplit[00], logger, nameof(P34_CHILDBORNGIRLS),out P34_CHILDBORNGIRLS),
				ProcessInt(LineSplit[00], logger, nameof(P34_CHILDBORNTOT),out P34_CHILDBORNTOT),
				ProcessInt(LineSplit[00], logger, nameof(P38_LASTCHILDDAY),out P38_LASTCHILDDAY),
				ProcessInt(LineSplit[00], logger, nameof(P38_LASTCHILDMO),out P38_LASTCHILDMO),
				ProcessInt(LineSplit[00], logger, nameof(P38_LASTCHILDYR),out P38_LASTCHILDYR),
				ProcessInt(LineSplit[00], logger, nameof(P39_LASTCHILDSEX),out P39_LASTCHILDSEX),
				ProcessInt(LineSplit[00], logger, nameof(P40_LASTCHILDALIVE),out P40_LASTCHILDALIVE),
				ProcessInt(LineSplit[00], logger, nameof(P41_DATEOFDEATHOFLASTCHILDDAZ),out P41_DATEOFDEATHOFLASTCHILDDAZ),
				ProcessInt(LineSplit[00], logger, nameof(P41_DATEOFDEATHOFLASTCHILDMONTJ),out P41_DATEOFDEATHOFLASTCHILDMONTJ),
				ProcessInt(LineSplit[00], logger, nameof(P41_DATEOFDEATHOFLASTCHILDYEAT),out P41_DATEOFDEATHOFLASTCHILDYEAT),
				ProcessInt(LineSplit[00], logger, nameof(DERP_BIRTH_REGION),out DERP_BIRTH_REGION),
				ProcessInt(LineSplit[00], logger, nameof(DERP_PREVRESPROV),out DERP_PREVRESPROV),
				ProcessInt(LineSplit[00], logger, nameof(DERP_USUALRESPROV),out DERP_USUALRESPROV),
				ProcessInt(LineSplit[00], logger, nameof(DERP_EMPLOY_STATUS),out DERP_EMPLOY_STATUS),
				ProcessInt(LineSplit[00], logger, nameof(DERP_EMPLOY_STATUS_OFFICIAL),out DERP_EMPLOY_STATUS_OFFICIAL),
				ProcessInt(LineSplit[00], logger, nameof(DERP_EMPLOY_STATUS_EXPANDED),out DERP_EMPLOY_STATUS_EXPANDED),
				ProcessInt(LineSplit[00], logger, nameof(DERP_INDUSTRY),out DERP_INDUSTRY),
				ProcessInt(LineSplit[00], logger, nameof(DERP_OCCUPATION),out DERP_OCCUPATION),
				ProcessInt(LineSplit[00], logger, nameof(OCCUP_LEV01),out OCCUP_LEV01),
				ProcessInt(LineSplit[00], logger, nameof(OCCUP_LEV02),out OCCUP_LEV02),
				ProcessInt(LineSplit[00], logger, nameof(OCCUP_LEV03),out OCCUP_LEV03),
				ProcessInt(LineSplit[00], logger, nameof(OCCUP_LEV04),out OCCUP_LEV04),
				ProcessInt(LineSplit[00], logger, nameof(DERP_Sector),out DERP_Sector),
				ProcessInt(LineSplit[00], logger, nameof(DERP_EDUCATIONAL_LEVEL),out DERP_EDUCATIONAL_LEVEL),
				ProcessInt(LineSplit[00], logger, nameof(DERP_BIRTHS_12MONTHS),out DERP_BIRTHS_12MONTHS),
				ProcessInt(LineSplit[00], logger, nameof(P_GEOTYPE),out P_GEOTYPE),
				ProcessInt(LineSplit[00], logger, nameof(P_PROVINCE),out P_PROVINCE),
				ProcessInt(LineSplit[00], logger, nameof(P_DISTRICT),out P_DISTRICT),
				ProcessInt(LineSplit[00], logger, nameof(P_MUNIC),out P_MUNIC),
				ProcessInt(LineSplit[00], logger, nameof(PERSON_10PER_WGT),out PERSON_10PER_WGT),

			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public int? QN_TYPE;
		public int? SN;
		public int? F00_NR;
		public int? F02_AGE;
		public int? F03_SEX;
		public int? P01_DAY;
		public int? P01_MONTH;
		public int? P01_YEAR;
		public int? P02_RELATION;
		public int? P03_MARITAL_ST;
		public int? P04_SPN;
		public int? P05_POP_GROUP;
		public int? P06A_LANGUAGE;
		public int? P06B_LANGUAGE;
		public int? P07_PROV_POB;
		public int? P08_COUNTRYOFBIRTH;
		public int? P08A_YEARMOVED;
		public int? P09_CITIZENSHIP;
		public int? P10_USUALRES;
		public int? P10A_USUALRESPROV;
		public int? P10B_USUALRESMUNIC;
		public int? P11_SINCE2001;
		public int? P11A_RESMONTHMOVED;
		public int? P11A_RESYEARMOVED;
		public int? P11B_PREVRESPROV;
		public int? P11C_PREVRESMUNIC;
		public int? P12A_SEEING;
		public int? P12B_HEARING;
		public int? P12C_COMMUNICATION;
		public int? P12D_WALKING;
		public int? P12E_REMEMBERING;
		public int? P12F_SELF_CARE;
		public int? P13A_DEVMEDEYEGLAS;
		public int? P13B_DEVMEDHEARINGAID;
		public int? P13C_DEVMEWALKINGSTICK;
		public int? P13D_DEVMEDWHEELCHAIR;
		public int? P13E_DEVMEDCHRONIC;
		public int? P14_MOTHERALIVE;
		public int? P14A_MOTHERPNR;
		public int? P15_FATHERALIVE;
		public int? P15A_FATHERPNR;
		public int? P16_INCOME;
		public int? P17_SCHOOLATTEND;
		public int? P18_EDUINST;
		public int? P19_EDUPUBPRIV;
		public int? P20_EDULEVEL;
		public int? P21_EDUFIELD;
		public int? P22A_EDULITERACY;
		public int? P22B_EDULITERACY;
		public int? P22C_EDULITERACY;
		public int? P22D_EDULITERACY;
		public int? P22E_EDULITERACY;
		public int? P22F_EDULITERACY;
		public int? P23A_EMPLOYMENTSTATUS;
		public int? P23B_EMPLOYMENTSTATUS;
		public int? P23C_EMPLOYMENTSTATUS;
		public int? P24_TEMPWORKABSENCE;
		public int? P25_UNEMPLOYMENT;
		public int? P26_UNEMPLOYMENT;
		public int? P27_REASONSNOTWORKING;
		public int? P28_WORKAVAILABILITY;
		public int? P29A_INDUSTRY;
		public int? P30A_OCCUPATION;
		public int? P31_SECTOR;
		public int? P32_CHILDEVERBORN;
		public int? P33_AGEFIRSTBIRTH;
		public int? P34_CHILDBORNBOYS;
		public int? P34_CHILDBORNGIRLS;
		public int? P34_CHILDBORNTOT;
		public int? P38_LASTCHILDDAY;
		public int? P38_LASTCHILDMO;
		public int? P38_LASTCHILDYR;
		public int? P39_LASTCHILDSEX;
		public int? P40_LASTCHILDALIVE;
		public int? P41_DATEOFDEATHOFLASTCHILDDAZ;
		public int? P41_DATEOFDEATHOFLASTCHILDMONTJ;
		public int? P41_DATEOFDEATHOFLASTCHILDYEAT;
		public int? DERP_BIRTH_REGION;
		public int? DERP_PREVRESPROV;
		public int? DERP_USUALRESPROV;
		public int? DERP_EMPLOY_STATUS;
		public int? DERP_EMPLOY_STATUS_OFFICIAL;
		public int? DERP_EMPLOY_STATUS_EXPANDED;
		public int? DERP_INDUSTRY;
		public int? DERP_OCCUPATION;
		public int? OCCUP_LEV01;
		public int? OCCUP_LEV02;
		public int? OCCUP_LEV03;
		public int? OCCUP_LEV04;
		public int? DERP_Sector;
		public int? DERP_EDUCATIONAL_LEVEL;
		public int? DERP_BIRTHS_12MONTHS;
		public int? P_GEOTYPE;
		public int? P_PROVINCE;
		public int? P_DISTRICT;
		public int? P_MUNIC;
		public int? PERSON_10PER_WGT;
	}
}