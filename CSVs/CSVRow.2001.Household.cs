using System.IO;
using System.Linq;

namespace Database.SouthAfricanCensus.CSVs
{
	public class CSVRow2001Household : CSVRow2001
	{
        public CSVRow2001Household(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{
				ProcessInt(LineSplit[00], logger, nameof(sn), out sn),
				ProcessInt(LineSplit[01], logger, nameof(munic_co), out munic_co),
				ProcessInt(LineSplit[02], logger, nameof(md_code), out md_code),
				ProcessInt(LineSplit[03], logger, nameof(dc_munic), out dc_munic),
				ProcessInt(LineSplit[04], logger, nameof(pr_code), out pr_code),
				ProcessInt(LineSplit[05], logger, nameof(ea_type), out ea_type),
				ProcessInt(LineSplit[06], logger, nameof(eatype96), out eatype96),
				ProcessInt(LineSplit[07], logger, nameof(density), out density),
				ProcessInt(LineSplit[08], logger, nameof(der2_hhs), out der2_hhs),
				ProcessInt(LineSplit[09], logger, nameof(h23_quar), out h23_quar),
				ProcessInt(LineSplit[00], logger, nameof(h23a_hu), out h23a_hu),
				ProcessInt(LineSplit[01], logger, nameof(h23b_mul), out h23b_mul),
				ProcessInt(LineSplit[02], logger, nameof(h24_room), out h24_room),
				ProcessInt(LineSplit[03], logger, nameof(h24a_sha), out h24a_sha),
				ProcessInt(LineSplit[04], logger, nameof(h25_tenu), out h25_tenu),
				ProcessInt(LineSplit[05], logger, nameof(h26_pipe), out h26_pipe),
				ProcessInt(LineSplit[06], logger, nameof(h26a_sou), out h26a_sou),
				ProcessInt(LineSplit[07], logger, nameof(der3_wat), out der3_wat),
				ProcessInt(LineSplit[08], logger, nameof(h27_toil), out h27_toil),
				ProcessInt(LineSplit[09], logger, nameof(h28a_coo), out h28a_coo),
				ProcessInt(LineSplit[00], logger, nameof(h28b_hea), out h28b_hea),
				ProcessInt(LineSplit[01], logger, nameof(h28c_lgh), out h28c_lgh),
				ProcessInt(LineSplit[02], logger, nameof(h29_radi), out h29_radi),
				ProcessInt(LineSplit[03], logger, nameof(h29_tv), out h29_tv),
				ProcessInt(LineSplit[04], logger, nameof(h29_comp), out h29_comp),
				ProcessInt(LineSplit[05], logger, nameof(h29_frid), out h29_frid),
				ProcessInt(LineSplit[06], logger, nameof(h29_tele), out h29_tele),
				ProcessInt(LineSplit[07], logger, nameof(h29_cell), out h29_cell),
				ProcessInt(LineSplit[08], logger, nameof(h29a_acc), out h29a_acc),
				ProcessInt(LineSplit[09], logger, nameof(der4_tel), out der4_tel),
				ProcessInt(LineSplit[00], logger, nameof(h30_refu), out h30_refu),
				ProcessInt(LineSplit[01], logger, nameof(der52_ma), out der52_ma),
				ProcessInt(LineSplit[02], logger, nameof(der16_hh), out der16_hh),
				ProcessInt(LineSplit[03], logger, nameof(weight), out weight),

			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public int? sn;
		public int? munic_co;
		public int? md_code;
		public int? dc_munic;
		public int? pr_code;
		public int? ea_type;
		public int? eatype96;
		public int? density;
		public int? der2_hhs;
		public int? h23_quar;
		public int? h23a_hu;
		public int? h23b_mul;
		public int? h24_room;
		public int? h24a_sha;
		public int? h25_tenu;
		public int? h26_pipe;
		public int? h26a_sou;
		public int? der3_wat;
		public int? h27_toil;
		public int? h28a_coo;
		public int? h28b_hea;
		public int? h28c_lgh;
		public int? h29_radi;
		public int? h29_tv;
		public int? h29_comp;
		public int? h29_frid;
		public int? h29_tele;
		public int? h29_cell;
		public int? h29a_acc;
		public int? der4_tel;
		public int? h30_refu;
		public int? der52_ma;
		public int? der16_hh;
		public int? weight;
	}
}