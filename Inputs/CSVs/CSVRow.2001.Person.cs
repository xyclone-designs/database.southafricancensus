using System.IO;
using System.Linq;
using XycloneDesigns.Database.SouthAfricanCensus.Tables;

namespace Database.SouthAfricanCensus.Inputs.CSVs
{
	public class CSVRow2001Person : CSVRow2001
    {
		public CSVRow2001Person(string line, StreamWriter logger) : base(line) 
		{
			if (new bool[]	
			{
				ProcessInt(LineSplit[00], logger, nameof(sn), out sn),
				ProcessInt(LineSplit[01], logger, nameof(munic_co), out munic_co),
				ProcessInt(LineSplit[02], logger, nameof(md_code), out md_code),
				ProcessInt(LineSplit[03], logger, nameof(dc_munic), out dc_munic),
				ProcessInt(LineSplit[04], logger, nameof(pr_code), out pr_code),
				ProcessInt(LineSplit[05], logger, nameof(ea_type), out ea_type),
				ProcessInt(LineSplit[06], logger, nameof(EATYPE96), out EATYPE96),
				ProcessInt(LineSplit[07], logger, nameof(DENSITY), out DENSITY),
				ProcessInt(LineSplit[08], logger, nameof(h23_quar), out h23_quar),
				ProcessInt(LineSplit[09], logger, nameof(p01_pno), out p01_pno),
				ProcessInt(LineSplit[10], logger, nameof(p02_day), out p02_day),
				ProcessInt(LineSplit[11], logger, nameof(p02_mth), out p02_mth),
				ProcessInt(LineSplit[12], logger, nameof(p02_yr), out p02_yr),
				ProcessInt(LineSplit[13], logger, nameof(p02_age), out p02_age),
				ProcessInt(LineSplit[14], logger, nameof(p03_sex), out p03_sex),
				ProcessInt(LineSplit[15], logger, nameof(p04_rel), out p04_rel),
				ProcessInt(LineSplit[16], logger, nameof(p05_mar), out p05_mar),
				ProcessInt(LineSplit[17], logger, nameof(p05a_spo), out p05a_spo),
				ProcessInt(LineSplit[18], logger, nameof(p06_race), out p06_race),
				ProcessInt(LineSplit[19], logger, nameof(p07_lng), out p07_lng),
				ProcessInt(LineSplit[20], logger, nameof(p08_rlg), out p08_rlg),
				ProcessInt(LineSplit[21], logger, nameof(der25_re), out der25_re),
				ProcessInt(LineSplit[22], logger, nameof(p09_rsa), out p09_rsa),
				ProcessInt(LineSplit[23], logger, nameof(p09a_prv), out p09a_prv),
				ProcessInt(LineSplit[24], logger, nameof(p09b_cnt), out p09b_cnt),
				ProcessInt(LineSplit[25], logger, nameof(der28_bi), out der28_bi),
				ProcessInt(LineSplit[26], logger, nameof(p10a_cnt), out p10a_cnt),
				ProcessInt(LineSplit[27], logger, nameof(der29_ci), out der29_ci),
				ProcessInt(LineSplit[28], logger, nameof(p11_4ngt), out p11_4ngt),
				ProcessInt(LineSplit[29], logger, nameof(p11c_pru), out p11c_pru),
				ProcessInt(LineSplit[00], logger, nameof(p11a_pur), out p11a_pur),
				ProcessInt(LineSplit[01], logger, nameof(p12_96), out p12_96),
				ProcessInt(LineSplit[02], logger, nameof(p12b_96y), out p12b_96y),
				ProcessInt(LineSplit[03], logger, nameof(p12b_prp), out p12b_prp),
				ProcessInt(LineSplit[04], logger, nameof(p12a_ppr), out p12a_ppr),
				ProcessInt(LineSplit[05], logger, nameof(p13b_sg), out p13b_sg),
				ProcessInt(LineSplit[06], logger, nameof(p13c_hr), out p13c_hr),
				ProcessInt(LineSplit[07], logger, nameof(p13d_co), out p13d_co),
				ProcessInt(LineSplit[08], logger, nameof(p13e_ph), out p13e_ph),
				ProcessInt(LineSplit[09], logger, nameof(p13f_in), out p13f_in),
				ProcessInt(LineSplit[10], logger, nameof(p13g_em), out p13g_em),
				ProcessInt(LineSplit[12], logger, nameof(der5_dis), out der5_dis),
				ProcessInt(LineSplit[13], logger, nameof(p14_ma), out p14_ma),
				ProcessInt(LineSplit[14], logger, nameof(p14a_mno), out p14a_mno),
				ProcessInt(LineSplit[15], logger, nameof(p15_fa), out p15_fa),
				ProcessInt(LineSplit[16], logger, nameof(p15a_fno), out p15a_fno),
				ProcessInt(LineSplit[17], logger, nameof(p16_stud), out p16_stud),
				ProcessInt(LineSplit[18], logger, nameof(p16a_stt), out p16a_stt),
				ProcessInt(LineSplit[19], logger, nameof(p17_educ), out p17_educ),
				ProcessInt(LineSplit[20], logger, nameof(der27_ed), out der27_ed),
				ProcessInt(LineSplit[21], logger, nameof(p17a_edf), out p17a_edf),
				ProcessInt(LineSplit[22], logger, nameof(p18_work), out p18_work),
				ProcessInt(LineSplit[23], logger, nameof(p18a_wno), out p18a_wno),
				ProcessInt(LineSplit[24], logger, nameof(p18b_wst), out p18b_wst),
				ProcessInt(LineSplit[25], logger, nameof(p18c_wav), out p18c_wav),
				ProcessInt(LineSplit[26], logger, nameof(der10_em), out der10_em),
				ProcessInt(LineSplit[27], logger, nameof(der11_em), out der11_em),
				ProcessInt(LineSplit[28], logger, nameof(der57_em), out der57_em),
				ProcessInt(LineSplit[29], logger, nameof(p19_wsta), out p19_wsta),
				ProcessInt(LineSplit[00], logger, nameof(p19b_ind), out p19b_ind),
				ProcessInt(LineSplit[01], logger, nameof(p19c_occ), out p19c_occ),
				ProcessInt(LineSplit[02], logger, nameof(p19d_hrs), out p19d_hrs),
				ProcessInt(LineSplit[03], logger, nameof(p19e_wp), out p19e_wp),
				ProcessInt(LineSplit[04], logger, nameof(p19f4_wp), out p19f4_wp),
				ProcessInt(LineSplit[05], logger, nameof(p19f_wpl), out p19f_wpl),
				ProcessInt(LineSplit[06], logger, nameof(p20_tceb), out p20_tceb),
				ProcessInt(LineSplit[07], logger, nameof(p20_mceb), out p20_mceb),
				ProcessInt(LineSplit[08], logger, nameof(p20_fceb), out p20_fceb),
				ProcessInt(LineSplit[09], logger, nameof(p20a_tcs), out p20a_tcs),
				ProcessInt(LineSplit[10], logger, nameof(p20a_mcs), out p20a_mcs),
				ProcessInt(LineSplit[11], logger, nameof(p20a_fcs), out p20a_fcs),
				ProcessInt(LineSplit[12], logger, nameof(p20b_lda), out p20b_lda),
				ProcessInt(LineSplit[13], logger, nameof(p20b_lmt), out p20b_lmt),
				ProcessInt(LineSplit[14], logger, nameof(p20b_lye), out p20b_lye),
				ProcessInt(LineSplit[15], logger, nameof(der24_ti), out der24_ti),
				ProcessInt(LineSplit[16], logger, nameof(der23_ag), out der23_ag),
				ProcessInt(LineSplit[17], logger, nameof(p20b_lse), out p20b_lse),
				ProcessInt(LineSplit[18], logger, nameof(p20b_la), out p20b_la),
				ProcessInt(LineSplit[19], logger, nameof(p21_wtra), out p21_wtra),
				ProcessInt(LineSplit[20], logger, nameof(p22_incm), out p22_incm),
				ProcessInt(LineSplit[21], logger, nameof(der60_mg), out der60_mg),
				ProcessInt(LineSplit[22], logger, nameof(der61_mg), out der61_mg),
				ProcessInt(LineSplit[23], logger, nameof(der62_mg), out der62_mg),
				ProcessInt(LineSplit[24], logger, nameof(der63_mg), out der63_mg),
				ProcessInt(LineSplit[25], logger, nameof(der64_mg), out der64_mg),
				ProcessInt(LineSplit[26], logger, nameof(der65_mg), out der65_mg),
				ProcessInt(LineSplit[27], logger, nameof(der66_mg), out der66_mg),
				ProcessInt(LineSplit[28], logger, nameof(der67_mg), out der67_mg),
				ProcessDouble(LineSplit[29], logger, nameof(weight), out weight),

			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public uint? sn;
		public uint? munic_co;
		public uint? md_code;
		public uint? dc_munic;
		public uint? pr_code;
		public uint? ea_type;
		public uint? EATYPE96;
		public uint? DENSITY;
		public uint? h23_quar;
		public uint? p01_pno;
		public uint? p02_day;
		public uint? p02_mth;
		public uint? p02_yr;
		public uint? p02_age;
		public uint? p03_sex;
		public uint? p04_rel;
		public uint? p05_mar;
		public uint? p05a_spo;
		public uint? p06_race;
		public uint? p07_lng;
		public uint? p08_rlg;
		public uint? der25_re;
		public uint? p09_rsa;
		public uint? p09a_prv;
		public uint? p09b_cnt;
		public uint? der28_bi;
		public uint? p10a_cnt;
		public uint? der29_ci;
		public uint? p11_4ngt;
		public uint? p11c_pru;
		public uint? p11a_pur;
		public uint? p12_96;
		public uint? p12b_96y;
		public uint? p12b_prp;
		public uint? p12a_ppr;
		public uint? p13b_sg;
		public uint? p13c_hr;
		public uint? p13d_co;
		public uint? p13e_ph;
		public uint? p13f_in;
		public uint? p13g_em;
		public uint? der5_dis;
		public uint? p14_ma;
		public uint? p14a_mno;
		public uint? p15_fa;
		public uint? p15a_fno;
		public uint? p16_stud;
		public uint? p16a_stt;
		public uint? p17_educ;
		public uint? der27_ed;
		public uint? p17a_edf;
		public uint? p18_work;
		public uint? p18a_wno;
		public uint? p18b_wst;
		public uint? p18c_wav;
		public uint? der10_em;
		public uint? der11_em;
		public uint? der57_em;
		public uint? p19_wsta;
		public uint? p19b_ind;
		public uint? p19c_occ;
		public uint? p19d_hrs;
		public uint? p19e_wp;
		public uint? p19f4_wp;
		public uint? p19f_wpl;
		public uint? p20_tceb;
		public uint? p20_mceb;
		public uint? p20_fceb;
		public uint? p20a_tcs;
		public uint? p20a_mcs;
		public uint? p20a_fcs;
		public uint? p20b_lda;
		public uint? p20b_lmt;
		public uint? p20b_lye;
		public uint? der24_ti;
		public uint? der23_ag;
		public uint? p20b_lse;
		public uint? p20b_la;
		public uint? p21_wtra;
		public uint? p22_incm;
		public uint? der60_mg;
		public uint? der61_mg;
		public uint? der62_mg;
		public uint? der63_mg;
		public uint? der64_mg;
		public uint? der65_mg;
		public uint? der66_mg;
		public uint? der67_mg;
		public double? weight;

		public RecordsPerson AsRecord()
		{
			return new RecordsPerson { };
		}
	}
}