using System.Collections.Generic;
using System.IO;
using System.Linq;

using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Models;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;
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
				ProcessInt(LineSplit[30], logger, nameof(p11a_pur), out p11a_pur),
				ProcessInt(LineSplit[31], logger, nameof(p12_96), out p12_96),
				ProcessInt(LineSplit[32], logger, nameof(p12b_96y), out p12b_96y),
				ProcessInt(LineSplit[33], logger, nameof(p12b_prp), out p12b_prp),
				ProcessInt(LineSplit[34], logger, nameof(p12a_ppr), out p12a_ppr),
				ProcessInt(LineSplit[35], logger, nameof(p13b_sg), out p13b_sg),
				ProcessInt(LineSplit[36], logger, nameof(p13c_hr), out p13c_hr),
				ProcessInt(LineSplit[37], logger, nameof(p13d_co), out p13d_co),
				ProcessInt(LineSplit[38], logger, nameof(p13e_ph), out p13e_ph),
				ProcessInt(LineSplit[39], logger, nameof(p13f_in), out p13f_in),
				ProcessInt(LineSplit[40], logger, nameof(p13g_em), out p13g_em),
				ProcessInt(LineSplit[41], logger, nameof(der5_dis), out der5_dis),
				ProcessInt(LineSplit[42], logger, nameof(p14_ma), out p14_ma),
				ProcessInt(LineSplit[43], logger, nameof(p14a_mno), out p14a_mno),
				ProcessInt(LineSplit[44], logger, nameof(p15_fa), out p15_fa),
				ProcessInt(LineSplit[45], logger, nameof(p15a_fno), out p15a_fno),
				ProcessInt(LineSplit[46], logger, nameof(p16_stud), out p16_stud),
				ProcessInt(LineSplit[47], logger, nameof(p16a_stt), out p16a_stt),
				ProcessInt(LineSplit[48], logger, nameof(p17_educ), out p17_educ),
				ProcessInt(LineSplit[49], logger, nameof(der27_ed), out der27_ed),
				ProcessInt(LineSplit[50], logger, nameof(p17a_edf), out p17a_edf),
				ProcessInt(LineSplit[51], logger, nameof(p18_work), out p18_work),
				ProcessInt(LineSplit[52], logger, nameof(p18a_wno), out p18a_wno),
				ProcessInt(LineSplit[53], logger, nameof(p18b_wst), out p18b_wst),
				ProcessInt(LineSplit[54], logger, nameof(p18c_wav), out p18c_wav),
				ProcessInt(LineSplit[55], logger, nameof(der10_em), out der10_em),
				ProcessInt(LineSplit[56], logger, nameof(der11_em), out der11_em),
				ProcessInt(LineSplit[57], logger, nameof(der57_em), out der57_em),
				ProcessInt(LineSplit[58], logger, nameof(p19_wsta), out p19_wsta),
				ProcessInt(LineSplit[59], logger, nameof(p19b_ind), out p19b_ind),
				ProcessInt(LineSplit[60], logger, nameof(p19c_occ), out p19c_occ),
				ProcessInt(LineSplit[61], logger, nameof(p19d_hrs), out p19d_hrs),
				ProcessInt(LineSplit[62], logger, nameof(p19e_wp), out p19e_wp),
				ProcessInt(LineSplit[63], logger, nameof(p19f4_wp), out p19f4_wp),
				ProcessInt(LineSplit[64], logger, nameof(p19f_wpl), out p19f_wpl),
				ProcessInt(LineSplit[65], logger, nameof(p20_tceb), out p20_tceb),
				ProcessInt(LineSplit[66], logger, nameof(p20_mceb), out p20_mceb),
				ProcessInt(LineSplit[67], logger, nameof(p20_fceb), out p20_fceb),
				ProcessInt(LineSplit[68], logger, nameof(p20a_tcs), out p20a_tcs),
				ProcessInt(LineSplit[69], logger, nameof(p20a_mcs), out p20a_mcs),
				ProcessInt(LineSplit[70], logger, nameof(p20a_fcs), out p20a_fcs),
				ProcessInt(LineSplit[71], logger, nameof(p20b_lda), out p20b_lda),
				ProcessInt(LineSplit[72], logger, nameof(p20b_lmt), out p20b_lmt),
				ProcessInt(LineSplit[73], logger, nameof(p20b_lye), out p20b_lye),
				ProcessInt(LineSplit[74], logger, nameof(der24_ti), out der24_ti),
				ProcessInt(LineSplit[75], logger, nameof(der23_ag), out der23_ag),
				ProcessInt(LineSplit[76], logger, nameof(p20b_lse), out p20b_lse),
				ProcessInt(LineSplit[77], logger, nameof(p20b_la), out p20b_la),
				ProcessInt(LineSplit[78], logger, nameof(p21_wtra), out p21_wtra),
				ProcessInt(LineSplit[79], logger, nameof(p22_incm), out p22_incm),
				ProcessInt(LineSplit[80], logger, nameof(der60_mg), out der60_mg),
				ProcessInt(LineSplit[81], logger, nameof(der61_mg), out der61_mg),
				ProcessInt(LineSplit[82], logger, nameof(der62_mg), out der62_mg),
				ProcessInt(LineSplit[83], logger, nameof(der63_mg), out der63_mg),
				ProcessInt(LineSplit[84], logger, nameof(der64_mg), out der64_mg),
				ProcessInt(LineSplit[85], logger, nameof(der65_mg), out der65_mg),
				ProcessInt(LineSplit[86], logger, nameof(der66_mg), out der66_mg),
				ProcessInt(LineSplit[87], logger, nameof(der67_mg), out der67_mg),
				ProcessDouble(LineSplit[88], logger, nameof(weight), out weight),

			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public int? sn;
		public int? munic_co;
		public int? md_code;
		public int? dc_munic;
		public int? pr_code;
		public int? ea_type;
		public int? EATYPE96;
		public int? DENSITY;
		public int? h23_quar;
		public int? p01_pno;
		public int? p02_day;
		public int? p02_mth;
		public int? p02_yr;
		public int? p02_age;
		public int? p03_sex;
		public int? p04_rel;
		public int? p05_mar;
		public int? p05a_spo;
		public int? p06_race;
		public int? p07_lng;
		public int? p08_rlg;
		public int? der25_re;
		public int? p09_rsa;
		public int? p09a_prv;
		public int? p09b_cnt;
		public int? der28_bi;
		public int? p10a_cnt;
		public int? der29_ci;
		public int? p11_4ngt;
		public int? p11c_pru;
		public int? p11a_pur;
		public int? p12_96;
		public int? p12b_96y;
		public int? p12b_prp;
		public int? p12a_ppr;
		public int? p13b_sg;
		public int? p13c_hr;
		public int? p13d_co;
		public int? p13e_ph;
		public int? p13f_in;
		public int? p13g_em;
		public int? der5_dis;
		public int? p14_ma;
		public int? p14a_mno;
		public int? p15_fa;
		public int? p15a_fno;
		public int? p16_stud;
		public int? p16a_stt;
		public int? p17_educ;
		public int? der27_ed;
		public int? p17a_edf;
		public int? p18_work;
		public int? p18a_wno;
		public int? p18b_wst;
		public int? p18c_wav;
		public int? der10_em;
		public int? der11_em;
		public int? der57_em;
		public int? p19_wsta;
		public int? p19b_ind;
		public int? p19c_occ;
		public int? p19d_hrs;
		public int? p19e_wp;
		public int? p19f4_wp;
		public int? p19f_wpl;
		public int? p20_tceb;
		public int? p20_mceb;
		public int? p20_fceb;
		public int? p20a_tcs;
		public int? p20a_mcs;
		public int? p20a_fcs;
		public int? p20b_lda;
		public int? p20b_lmt;
		public int? p20b_lye;
		public int? der24_ti;
		public int? der23_ag;
		public int? p20b_lse;
		public int? p20b_la;
		public int? p21_wtra;
		public int? p22_incm;
		public int? der60_mg;
		public int? der61_mg;
		public int? der62_mg;
		public int? der63_mg;
		public int? der64_mg;
		public int? der65_mg;
		public int? der66_mg;
		public int? der67_mg;
		public double? weight;

		public RecordPerson AsModel(StreamWriter logger)
		{
			Dictionary<string, object> errors = [];
			RecordPerson model = new() 
			{
				SerialNumber = sn,
				TenPercentWeight = weight,

				Disabilities = new Disabilities { },
				Household = new Household { },
				Location = new Location { },
				Metadata = new Metadata { },
				Motherhood = new Motherhood { },
				Occupation = new Occupation { },
				Personhood = new Personhood { },
				Residence = new Residence { },
			};

			if (munic_co is not null)
			{
				if (default(TypeDisability).FromInt(munic_co.Value, Years._2001, out TypeDisability? _munic_co, out NotAvailables? _munic_cona))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_munic_co ?? (int?)_munic_cona);
				else errors.Add(nameof(munic_co), munic_co);
			}
			if (md_code is not null)
			{
				if (default(TypeDisability).FromInt(md_code.Value, Years._2001, out TypeDisability? _md_code, out NotAvailables? _md_codena))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_md_code ?? (int?)_md_codena);
				else errors.Add(nameof(md_code), md_code);
			}
			if (dc_munic is not null)
			{
				if (default(TypeDisability).FromInt(dc_munic.Value, Years._2001, out TypeDisability? _dc_munic, out NotAvailables? _dc_municna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_dc_munic ?? (int?)_dc_municna);
				else errors.Add(nameof(dc_munic), dc_munic);
			}
			if (pr_code is not null)
			{
				if (default(TypeDisability).FromInt(pr_code.Value, Years._2001, out TypeDisability? _pr_code, out NotAvailables? _pr_codena))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_pr_code ?? (int?)_pr_codena);
				else errors.Add(nameof(pr_code), pr_code);
			}
			if (ea_type is not null)
			{
				if (default(TypeDisability).FromInt(ea_type.Value, Years._2001, out TypeDisability? _ea_type, out NotAvailables? _ea_typena))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_ea_type ?? (int?)_ea_typena);
				else errors.Add(nameof(ea_type), ea_type);
			}
			if (EATYPE96 is not null)
			{
				if (default(TypeDisability).FromInt(EATYPE96.Value, Years._2001, out TypeDisability? _EATYPE96, out NotAvailables? _EATYPE96na))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_EATYPE96 ?? (int?)_EATYPE96na);
				else errors.Add(nameof(EATYPE96), EATYPE96);
			}
			if (DENSITY is not null)
			{
				if (default(TypeDisability).FromInt(DENSITY.Value, Years._2001, out TypeDisability? _DENSITY, out NotAvailables? _DENSITYna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_DENSITY ?? (int?)_DENSITYna);
				else errors.Add(nameof(DENSITY), DENSITY);
			}
			if (h23_quar is not null)
			{
				if (default(TypeDisability).FromInt(h23_quar.Value, Years._2001, out TypeDisability? _h23_quar, out NotAvailables? _h23_quarna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_h23_quar ?? (int?)_h23_quarna);
				else errors.Add(nameof(h23_quar), h23_quar);
			}
			if (p01_pno is not null)
			{
				if (default(TypeDisability).FromInt(p01_pno.Value, Years._2001, out TypeDisability? _p01_pno, out NotAvailables? _p01_pnona))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p01_pno ?? (int?)_p01_pnona);
				else errors.Add(nameof(p01_pno), p01_pno);
			}
			if (p02_day is not null)
			{
				if (default(TypeDisability).FromInt(p02_day.Value, Years._2001, out TypeDisability? _p02_day, out NotAvailables? _p02_dayna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p02_day ?? (int?)_p02_dayna);
				else errors.Add(nameof(p02_day), p02_day);
			}
			if (p02_mth is not null)
			{
				if (default(TypeDisability).FromInt(p02_mth.Value, Years._2001, out TypeDisability? _p02_mth, out NotAvailables? _p02_mthna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p02_mth ?? (int?)_p02_mthna);
				else errors.Add(nameof(p02_mth), p02_mth);
			}
			if (p02_yr is not null)
			{
				if (default(TypeDisability).FromInt(p02_yr.Value, Years._2001, out TypeDisability? _p02_yr, out NotAvailables? _p02_yrna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p02_yr ?? (int?)_p02_yrna);
				else errors.Add(nameof(p02_yr), p02_yr);
			}
			if (p02_age is not null)
			{
				if (default(TypeDisability).FromInt(p02_age.Value, Years._2001, out TypeDisability? _p02_age, out NotAvailables? _p02_agena))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p02_age ?? (int?)_p02_agena);
				else errors.Add(nameof(p02_age), p02_age);
			}
			if (p03_sex is not null)
			{
				if (default(TypeDisability).FromInt(p03_sex.Value, Years._2001, out TypeDisability? _p03_sex, out NotAvailables? _p03_sexna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p03_sex ?? (int?)_p03_sexna);
				else errors.Add(nameof(p03_sex), p03_sex);
			}
			if (p04_rel is not null)
			{
				if (default(TypeDisability).FromInt(p04_rel.Value, Years._2001, out TypeDisability? _p04_rel, out NotAvailables? _p04_relna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p04_rel ?? (int?)_p04_relna);
				else errors.Add(nameof(p04_rel), p04_rel);
			}
			if (p05_mar is not null)
			{
				if (default(TypeDisability).FromInt(p05_mar.Value, Years._2001, out TypeDisability? _p05_mar, out NotAvailables? _p05_marna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p05_mar ?? (int?)_p05_marna);
				else errors.Add(nameof(p05_mar), p05_mar);
			}
			if (p05a_spo is not null)
			{
				if (default(TypeDisability).FromInt(p05a_spo.Value, Years._2001, out TypeDisability? _p05a_spo, out NotAvailables? _p05a_spona))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p05a_spo ?? (int?)_p05a_spona);
				else errors.Add(nameof(p05a_spo), p05a_spo);
			}
			if (p06_race is not null)
			{
				if (default(TypeDisability).FromInt(p06_race.Value, Years._2001, out TypeDisability? _p06_race, out NotAvailables? _p06_racena))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p06_race ?? (int?)_p06_racena);
				else errors.Add(nameof(p06_race), p06_race);
			}
			if (p07_lng is not null)
			{
				if (default(TypeDisability).FromInt(p07_lng.Value, Years._2001, out TypeDisability? _p07_lng, out NotAvailables? _p07_lngna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p07_lng ?? (int?)_p07_lngna);
				else errors.Add(nameof(p07_lng), p07_lng);
			}
			if (p08_rlg is not null)
			{
				if (default(TypeDisability).FromInt(p08_rlg.Value, Years._2001, out TypeDisability? _p08_rlg, out NotAvailables? _p08_rlgna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p08_rlg ?? (int?)_p08_rlgna);
				else errors.Add(nameof(p08_rlg), p08_rlg);
			}
			if (der25_re is not null)
			{
				if (default(TypeDisability).FromInt(der25_re.Value, Years._2001, out TypeDisability? _der25_re, out NotAvailables? _der25_rena))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der25_re ?? (int?)_der25_rena);
				else errors.Add(nameof(der25_re), der25_re);
			}
			if (p09_rsa is not null)
			{
				if (default(TypeDisability).FromInt(p09_rsa.Value, Years._2001, out TypeDisability? _p09_rsa, out NotAvailables? _p09_rsana))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p09_rsa ?? (int?)_p09_rsana);
				else errors.Add(nameof(p09_rsa), p09_rsa);
			}
			if (p09a_prv is not null)
			{
				if (default(TypeDisability).FromInt(p09a_prv.Value, Years._2001, out TypeDisability? _p09a_prv, out NotAvailables? _p09a_prvna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p09a_prv ?? (int?)_p09a_prvna);
				else errors.Add(nameof(p09a_prv), p09a_prv);
			}
			if (p09b_cnt is not null)
			{
				if (default(TypeDisability).FromInt(p09b_cnt.Value, Years._2001, out TypeDisability? _p09b_cnt, out NotAvailables? _p09b_cntna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p09b_cnt ?? (int?)_p09b_cntna);
				else errors.Add(nameof(p09b_cnt), p09b_cnt);
			}
			if (der28_bi is not null)
			{
				if (default(TypeDisability).FromInt(der28_bi.Value, Years._2001, out TypeDisability? _der28_bi, out NotAvailables? _der28_bina))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der28_bi ?? (int?)_der28_bina);
				else errors.Add(nameof(der28_bi), der28_bi);
			}
			if (p10a_cnt is not null)
			{
				if (default(TypeDisability).FromInt(p10a_cnt.Value, Years._2001, out TypeDisability? _p10a_cnt, out NotAvailables? _p10a_cntna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p10a_cnt ?? (int?)_p10a_cntna);
				else errors.Add(nameof(p10a_cnt), p10a_cnt);
			}
			if (der29_ci is not null)
			{
				if (default(TypeDisability).FromInt(der29_ci.Value, Years._2001, out TypeDisability? _der29_ci, out NotAvailables? _der29_cina))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der29_ci ?? (int?)_der29_cina);
				else errors.Add(nameof(der29_ci), der29_ci);
			}
			if (p11_4ngt is not null)
			{
				if (default(TypeDisability).FromInt(p11_4ngt.Value, Years._2001, out TypeDisability? _p11_4ngt, out NotAvailables? _p11_4ngtna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p11_4ngt ?? (int?)_p11_4ngtna);
				else errors.Add(nameof(p11_4ngt), p11_4ngt);
			}
			if (p11c_pru is not null)
			{
				if (default(TypeDisability).FromInt(p11c_pru.Value, Years._2001, out TypeDisability? _p11c_pru, out NotAvailables? _p11c_pruna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p11c_pru ?? (int?)_p11c_pruna);
				else errors.Add(nameof(p11c_pru), p11c_pru);
			}
			if (p11a_pur is not null)
			{
				if (default(TypeDisability).FromInt(p11a_pur.Value, Years._2001, out TypeDisability? _p11a_pur, out NotAvailables? _p11a_purna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p11a_pur ?? (int?)_p11a_purna);
				else errors.Add(nameof(p11a_pur), p11a_pur);
			}
			if (p12_96 is not null)
			{
				if (default(TypeDisability).FromInt(p12_96.Value, Years._2001, out TypeDisability? _p12_96, out NotAvailables? _p12_96na))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p12_96 ?? (int?)_p12_96na);
				else errors.Add(nameof(p12_96), p12_96);
			}
			if (p12b_96y is not null)
			{
				if (default(TypeDisability).FromInt(p12b_96y.Value, Years._2001, out TypeDisability? _p12b_96y, out NotAvailables? _p12b_96yna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p12b_96y ?? (int?)_p12b_96yna);
				else errors.Add(nameof(p12b_96y), p12b_96y);
			}
			if (p12b_prp is not null)
			{
				if (default(TypeDisability).FromInt(p12b_prp.Value, Years._2001, out TypeDisability? _p12b_prp, out NotAvailables? _p12b_prpna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p12b_prp ?? (int?)_p12b_prpna);
				else errors.Add(nameof(p12b_prp), p12b_prp);
			}
			if (p12a_ppr is not null)
			{
				if (default(TypeDisability).FromInt(p12a_ppr.Value, Years._2001, out TypeDisability? _p12a_ppr, out NotAvailables? _p12a_pprna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p12a_ppr ?? (int?)_p12a_pprna);
				else errors.Add(nameof(p12a_ppr), p12a_ppr);
			}
			if (p13b_sg is not null)
			{
				if (default(TypeDisability).FromInt(p13b_sg.Value, Years._2001, out TypeDisability? _p13b_sg, out NotAvailables? _p13b_sgna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p13b_sg ?? (int?)_p13b_sgna);
				else errors.Add(nameof(p13b_sg), p13b_sg);
			}
			if (p13c_hr is not null)
			{
				if (default(TypeDisability).FromInt(p13c_hr.Value, Years._2001, out TypeDisability? _p13c_hr, out NotAvailables? _p13c_hrna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p13c_hr ?? (int?)_p13c_hrna);
				else errors.Add(nameof(p13c_hr), p13c_hr);
			}
			if (p13d_co is not null)
			{
				if (default(TypeDisability).FromInt(p13d_co.Value, Years._2001, out TypeDisability? _p13d_co, out NotAvailables? _p13d_cona))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p13d_co ?? (int?)_p13d_cona);
				else errors.Add(nameof(p13d_co), p13d_co);
			}
			if (p13e_ph is not null)
			{
				if (default(TypeDisability).FromInt(p13e_ph.Value, Years._2001, out TypeDisability? _p13e_ph, out NotAvailables? _p13e_phna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p13e_ph ?? (int?)_p13e_phna);
				else errors.Add(nameof(p13e_ph), p13e_ph);
			}
			if (p13f_in is not null)
			{
				if (default(TypeDisability).FromInt(p13f_in.Value, Years._2001, out TypeDisability? _p13f_in, out NotAvailables? _p13f_inna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p13f_in ?? (int?)_p13f_inna);
				else errors.Add(nameof(p13f_in), p13f_in);
			}
			if (p13g_em is not null)
			{
				if (default(TypeDisability).FromInt(p13g_em.Value, Years._2001, out TypeDisability? _p13g_em, out NotAvailables? _p13g_emna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p13g_em ?? (int?)_p13g_emna);
				else errors.Add(nameof(p13g_em), p13g_em);
			}
			if (der5_dis is not null)
			{
				if (default(TypeDisability).FromInt(der5_dis.Value, Years._2001, out TypeDisability? _der5_dis, out NotAvailables? _der5_disna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der5_dis ?? (int?)_der5_disna);
				else errors.Add(nameof(der5_dis), der5_dis);
			}
			if (p14_ma is not null)
			{
				if (default(TypeDisability).FromInt(p14_ma.Value, Years._2001, out TypeDisability? _p14_ma, out NotAvailables? _p14_mana))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p14_ma ?? (int?)_p14_mana);
				else errors.Add(nameof(p14_ma), p14_ma);
			}
			if (p14a_mno is not null)
			{
				if (default(TypeDisability).FromInt(p14a_mno.Value, Years._2001, out TypeDisability? _p14a_mno, out NotAvailables? _p14a_mnona))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p14a_mno ?? (int?)_p14a_mnona);
				else errors.Add(nameof(p14a_mno), p14a_mno);
			}
			if (p15_fa is not null)
			{
				if (default(TypeDisability).FromInt(p15_fa.Value, Years._2001, out TypeDisability? _p15_fa, out NotAvailables? _p15_fana))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p15_fa ?? (int?)_p15_fana);
				else errors.Add(nameof(p15_fa), p15_fa);
			}
			if (p15a_fno is not null)
			{
				if (default(TypeDisability).FromInt(p15a_fno.Value, Years._2001, out TypeDisability? _p15a_fno, out NotAvailables? _p15a_fnona))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p15a_fno ?? (int?)_p15a_fnona);
				else errors.Add(nameof(p15a_fno), p15a_fno);
			}
			if (p16_stud is not null)
			{
				if (default(TypeDisability).FromInt(p16_stud.Value, Years._2001, out TypeDisability? _p16_stud, out NotAvailables? _p16_studna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p16_stud ?? (int?)_p16_studna);
				else errors.Add(nameof(p16_stud), p16_stud);
			}
			if (p16a_stt is not null)
			{
				if (default(TypeDisability).FromInt(p16a_stt.Value, Years._2001, out TypeDisability? _p16a_stt, out NotAvailables? _p16a_sttna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p16a_stt ?? (int?)_p16a_sttna);
				else errors.Add(nameof(p16a_stt), p16a_stt);
			}
			if (p17_educ is not null)
			{
				if (default(TypeDisability).FromInt(p17_educ.Value, Years._2001, out TypeDisability? _p17_educ, out NotAvailables? _p17_educna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p17_educ ?? (int?)_p17_educna);
				else errors.Add(nameof(p17_educ), p17_educ);
			}
			if (der27_ed is not null)
			{
				if (default(TypeDisability).FromInt(der27_ed.Value, Years._2001, out TypeDisability? _der27_ed, out NotAvailables? _der27_edna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der27_ed ?? (int?)_der27_edna);
				else errors.Add(nameof(der27_ed), der27_ed);
			}
			if (p17a_edf is not null)
			{
				if (default(TypeDisability).FromInt(p17a_edf.Value, Years._2001, out TypeDisability? _p17a_edf, out NotAvailables? _p17a_edfna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p17a_edf ?? (int?)_p17a_edfna);
				else errors.Add(nameof(p17a_edf), p17a_edf);
			}
			if (p18_work is not null)
			{
				if (default(TypeDisability).FromInt(p18_work.Value, Years._2001, out TypeDisability? _p18_work, out NotAvailables? _p18_workna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p18_work ?? (int?)_p18_workna);
				else errors.Add(nameof(p18_work), p18_work);
			}
			if (p18a_wno is not null)
			{
				if (default(TypeDisability).FromInt(p18a_wno.Value, Years._2001, out TypeDisability? _p18a_wno, out NotAvailables? _p18a_wnona))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p18a_wno ?? (int?)_p18a_wnona);
				else errors.Add(nameof(p18a_wno), p18a_wno);
			}
			if (p18b_wst is not null)
			{
				if (default(TypeDisability).FromInt(p18b_wst.Value, Years._2001, out TypeDisability? _p18b_wst, out NotAvailables? _p18b_wstna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p18b_wst ?? (int?)_p18b_wstna);
				else errors.Add(nameof(p18b_wst), p18b_wst);
			}
			if (p18c_wav is not null)
			{
				if (default(TypeDisability).FromInt(p18c_wav.Value, Years._2001, out TypeDisability? _p18c_wav, out NotAvailables? _p18c_wavna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p18c_wav ?? (int?)_p18c_wavna);
				else errors.Add(nameof(p18c_wav), p18c_wav);
			}
			if (der10_em is not null)
			{
				if (default(TypeDisability).FromInt(der10_em.Value, Years._2001, out TypeDisability? _der10_em, out NotAvailables? _der10_emna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der10_em ?? (int?)_der10_emna);
				else errors.Add(nameof(der10_em), der10_em);
			}
			if (der11_em is not null)
			{
				if (default(TypeDisability).FromInt(der11_em.Value, Years._2001, out TypeDisability? _der11_em, out NotAvailables? _der11_emna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der11_em ?? (int?)_der11_emna);
				else errors.Add(nameof(der11_em), der11_em);
			}
			if (der57_em is not null)
			{
				if (default(TypeDisability).FromInt(der57_em.Value, Years._2001, out TypeDisability? _der57_em, out NotAvailables? _der57_emna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der57_em ?? (int?)_der57_emna);
				else errors.Add(nameof(der57_em), der57_em);
			}
			if (p19_wsta is not null)
			{
				if (default(TypeDisability).FromInt(p19_wsta.Value, Years._2001, out TypeDisability? _p19_wsta, out NotAvailables? _p19_wstana))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p19_wsta ?? (int?)_p19_wstana);
				else errors.Add(nameof(p19_wsta), p19_wsta);
			}
			if (p19b_ind is not null)
			{
				if (default(TypeDisability).FromInt(p19b_ind.Value, Years._2001, out TypeDisability? _p19b_ind, out NotAvailables? _p19b_indna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p19b_ind ?? (int?)_p19b_indna);
				else errors.Add(nameof(p19b_ind), p19b_ind);
			}
			if (p19c_occ is not null)
			{
				if (default(TypeDisability).FromInt(p19c_occ.Value, Years._2001, out TypeDisability? _p19c_occ, out NotAvailables? _p19c_occna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p19c_occ ?? (int?)_p19c_occna);
				else errors.Add(nameof(p19c_occ), p19c_occ);
			}
			if (p19d_hrs is not null)
			{
				if (default(TypeDisability).FromInt(p19d_hrs.Value, Years._2001, out TypeDisability? _p19d_hrs, out NotAvailables? _p19d_hrsna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p19d_hrs ?? (int?)_p19d_hrsna);
				else errors.Add(nameof(p19d_hrs), p19d_hrs);
			}
			if (p19e_wp is not null)
			{
				if (default(TypeDisability).FromInt(p19e_wp.Value, Years._2001, out TypeDisability? _p19e_wp, out NotAvailables? _p19e_wpna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p19e_wp ?? (int?)_p19e_wpna);
				else errors.Add(nameof(p19e_wp), p19e_wp);
			}
			if (p19f4_wp is not null)
			{
				if (default(TypeDisability).FromInt(p19f4_wp.Value, Years._2001, out TypeDisability? _p19f4_wp, out NotAvailables? _p19f4_wpna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p19f4_wp ?? (int?)_p19f4_wpna);
				else errors.Add(nameof(p19f4_wp), p19f4_wp);
			}
			if (p19f_wpl is not null)
			{
				if (default(TypeDisability).FromInt(p19f_wpl.Value, Years._2001, out TypeDisability? _p19f_wpl, out NotAvailables? _p19f_wplna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p19f_wpl ?? (int?)_p19f_wplna);
				else errors.Add(nameof(p19f_wpl), p19f_wpl);
			}
			if (p20_tceb is not null)
			{
				if (default(TypeDisability).FromInt(p20_tceb.Value, Years._2001, out TypeDisability? _p20_tceb, out NotAvailables? _p20_tcebna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p20_tceb ?? (int?)_p20_tcebna);
				else errors.Add(nameof(p20_tceb), p20_tceb);
			}
			if (p20_mceb is not null)
			{
				if (default(TypeDisability).FromInt(p20_mceb.Value, Years._2001, out TypeDisability? _p20_mceb, out NotAvailables? _p20_mcebna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p20_mceb ?? (int?)_p20_mcebna);
				else errors.Add(nameof(p20_mceb), p20_mceb);
			}
			if (p20_fceb is not null)
			{
				if (default(TypeDisability).FromInt(p20_fceb.Value, Years._2001, out TypeDisability? _p20_fceb, out NotAvailables? _p20_fcebna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p20_fceb ?? (int?)_p20_fcebna);
				else errors.Add(nameof(p20_fceb), p20_fceb);
			}
			if (p20a_tcs is not null)
			{
				if (default(TypeDisability).FromInt(p20a_tcs.Value, Years._2001, out TypeDisability? _p20a_tcs, out NotAvailables? _p20a_tcsna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p20a_tcs ?? (int?)_p20a_tcsna);
				else errors.Add(nameof(p20a_tcs), p20a_tcs);
			}
			if (p20a_mcs is not null)
			{
				if (default(TypeDisability).FromInt(p20a_mcs.Value, Years._2001, out TypeDisability? _p20a_mcs, out NotAvailables? _p20a_mcsna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p20a_mcs ?? (int?)_p20a_mcsna);
				else errors.Add(nameof(p20a_mcs), p20a_mcs);
			}
			if (p20a_fcs is not null)
			{
				if (default(TypeDisability).FromInt(p20a_fcs.Value, Years._2001, out TypeDisability? _p20a_fcs, out NotAvailables? _p20a_fcsna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p20a_fcs ?? (int?)_p20a_fcsna);
				else errors.Add(nameof(p20a_fcs), p20a_fcs);
			}
			if (p20b_lda is not null)
			{
				if (default(TypeDisability).FromInt(p20b_lda.Value, Years._2001, out TypeDisability? _p20b_lda, out NotAvailables? _p20b_ldana))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p20b_lda ?? (int?)_p20b_ldana);
				else errors.Add(nameof(p20b_lda), p20b_lda);
			}
			if (p20b_lmt is not null)
			{
				if (default(TypeDisability).FromInt(p20b_lmt.Value, Years._2001, out TypeDisability? _p20b_lmt, out NotAvailables? _p20b_lmtna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p20b_lmt ?? (int?)_p20b_lmtna);
				else errors.Add(nameof(p20b_lmt), p20b_lmt);
			}
			if (p20b_lye is not null)
			{
				if (default(TypeDisability).FromInt(p20b_lye.Value, Years._2001, out TypeDisability? _p20b_lye, out NotAvailables? _p20b_lyena))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p20b_lye ?? (int?)_p20b_lyena);
				else errors.Add(nameof(p20b_lye), p20b_lye);
			}
			if (der24_ti is not null)
			{
				if (default(TypeDisability).FromInt(der24_ti.Value, Years._2001, out TypeDisability? _der24_ti, out NotAvailables? _der24_tina))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der24_ti ?? (int?)_der24_tina);
				else errors.Add(nameof(der24_ti), der24_ti);
			}
			if (der23_ag is not null)
			{
				if (default(TypeDisability).FromInt(der23_ag.Value, Years._2001, out TypeDisability? _der23_ag, out NotAvailables? _der23_agna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der23_ag ?? (int?)_der23_agna);
				else errors.Add(nameof(der23_ag), der23_ag);
			}
			if (p20b_lse is not null)
			{
				if (default(TypeDisability).FromInt(p20b_lse.Value, Years._2001, out TypeDisability? _p20b_lse, out NotAvailables? _p20b_lsena))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p20b_lse ?? (int?)_p20b_lsena);
				else errors.Add(nameof(p20b_lse), p20b_lse);
			}
			if (p20b_la is not null)
			{
				if (default(TypeDisability).FromInt(p20b_la.Value, Years._2001, out TypeDisability? _p20b_la, out NotAvailables? _p20b_lana))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p20b_la ?? (int?)_p20b_lana);
				else errors.Add(nameof(p20b_la), p20b_la);
			}
			if (p21_wtra is not null)
			{
				if (default(TypeDisability).FromInt(p21_wtra.Value, Years._2001, out TypeDisability? _p21_wtra, out NotAvailables? _p21_wtrana))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p21_wtra ?? (int?)_p21_wtrana);
				else errors.Add(nameof(p21_wtra), p21_wtra);
			}
			if (p22_incm is not null)
			{
				if (default(TypeDisability).FromInt(p22_incm.Value, Years._2001, out TypeDisability? _p22_incm, out NotAvailables? _p22_incmna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_p22_incm ?? (int?)_p22_incmna);
				else errors.Add(nameof(p22_incm), p22_incm);
			}
			if (der60_mg is not null)
			{
				if (default(TypeDisability).FromInt(der60_mg.Value, Years._2001, out TypeDisability? _der60_mg, out NotAvailables? _der60_mgna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der60_mg ?? (int?)_der60_mgna);
				else errors.Add(nameof(der60_mg), der60_mg);
			}
			if (der61_mg is not null)
			{
				if (default(TypeDisability).FromInt(der61_mg.Value, Years._2001, out TypeDisability? _der61_mg, out NotAvailables? _der61_mgna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der61_mg ?? (int?)_der61_mgna);
				else errors.Add(nameof(der61_mg), der61_mg);
			}
			if (der62_mg is not null)
			{
				if (default(TypeDisability).FromInt(der62_mg.Value, Years._2001, out TypeDisability? _der62_mg, out NotAvailables? _der62_mgna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der62_mg ?? (int?)_der62_mgna);
				else errors.Add(nameof(der62_mg), der62_mg);
			}
			if (der63_mg is not null)
			{
				if (default(TypeDisability).FromInt(der63_mg.Value, Years._2001, out TypeDisability? _der63_mg, out NotAvailables? _der63_mgna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der63_mg ?? (int?)_der63_mgna);
				else errors.Add(nameof(der63_mg), der63_mg);
			}
			if (der64_mg is not null)
			{
				if (default(TypeDisability).FromInt(der64_mg.Value, Years._2001, out TypeDisability? _der64_mg, out NotAvailables? _der64_mgna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der64_mg ?? (int?)_der64_mgna);
				else errors.Add(nameof(der64_mg), der64_mg);
			}
			if (der65_mg is not null)
			{
				if (default(TypeDisability).FromInt(der65_mg.Value, Years._2001, out TypeDisability? _der65_mg, out NotAvailables? _der65_mgna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der65_mg ?? (int?)_der65_mgna);
				else errors.Add(nameof(der65_mg), der65_mg);
			}
			if (der66_mg is not null)
			{
				if (default(TypeDisability).FromInt(der66_mg.Value, Years._2001, out TypeDisability? _der66_mg, out NotAvailables? _der66_mgna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der66_mg ?? (int?)_der66_mgna);
				else errors.Add(nameof(der66_mg), der66_mg);
			}
			if (der67_mg is not null)
			{
				if (default(TypeDisability).FromInt(der67_mg.Value, Years._2001, out TypeDisability? _der67_mg, out NotAvailables? _der67_mgna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_der67_mg ?? (int?)_der67_mgna);
				else errors.Add(nameof(der67_mg), der67_mg);
			}

			if (errors.Count > 0)
				logger?.WriteLine("[{0}]: {1}", LineNumber, string.Join(", ", errors.Select(_ => string.Format("[{0} {1}]", _.Key, _.Value))));

			return model;
		}
		public RecordsPerson AsRecord()
		{
			return new RecordsPerson { };		
		}
	}			
}							