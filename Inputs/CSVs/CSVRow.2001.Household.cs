using System.IO;
using System.Linq;

using XycloneDesigns.Database.SouthAfricanCensus.Tables;

namespace Database.SouthAfricanCensus.Inputs.CSVs
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
				ProcessDouble(LineSplit[03], logger, nameof(weight), out weight),

			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public uint? sn;
		public uint? munic_co;
		public uint? md_code;
		public uint? dc_munic;
		public uint? pr_code;
		public uint? ea_type;
		public uint? eatype96;
		public uint? density;
		public uint? der2_hhs;
		public uint? h23_quar;
		public uint? h23a_hu;
		public uint? h23b_mul;
		public uint? h24_room;
		public uint? h24a_sha;
		public uint? h25_tenu;
		public uint? h26_pipe;
		public uint? h26a_sou;
		public uint? der3_wat;
		public uint? h27_toil;
		public uint? h28a_coo;
		public uint? h28b_hea;
		public uint? h28c_lgh;
		public uint? h29_radi;
		public uint? h29_tv;
		public uint? h29_comp;
		public uint? h29_frid;
		public uint? h29_tele;
		public uint? h29_cell;
		public uint? h29a_acc;
		public uint? der4_tel;
		public uint? h30_refu;
		public uint? der52_ma;
		public uint? der16_hh;
		public double? weight;

		public RecordsHousehold AsRecord()
		{
			return new RecordsHousehold { };
		}
	}
}