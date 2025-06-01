
namespace Database.SouthAfricanCensus.CSVs
{
	public class CSVRow1996Person : CSVRow1996
	{
		public CSVRow1996Person(string line) : base(line) { }

		public int province { get; set; }
		public int district { get; set; }
		public int dccode { get; set; }
		public int newla { get; set; }
		public int hhnumber { get; set; }
		public int personno { get; set; }
		public int hhrecord { get; set; }
		public int urban { get; set; }
		public int insttype { get; set; }
		public int sex { get; set; }
		public int age { get; set; }
		public int relship { get; set; }
		public int marstau { get; set; }
		public int race { get; set; }
		public int languag1 { get; set; }
		public int languag2 { get; set; }
		public int religion { get; set; }
		public int birthcou { get; set; }
		public int citizenc { get; set; }
		public int citizeno { get; set; }
		public int citizenr { get; set; }
		public int migworke { get; set; }
		public int tempresi { get; set; }
		public int usualdis { get; set; }
		public int movedy2 { get; set; }
		public int moveddis { get; set; }
		public int disablec { get; set; }
		public int sight { get; set; }
		public int hearing { get; set; }
		public int physical { get; set; }
		public int mental { get; set; }
		public int motheral { get; set; }
		public int fatheral { get; set; }
		public int chilborn { get; set; }
		public int childliv { get; set; }
		public int agefrstb { get; set; }
		public int bornlast { get; set; }
		public int school { get; set; }
		public int qualfld { get; set; }
		public int study { get; set; }
		public int quallev { get; set; }
		public int deducode { get; set; }
		public int econactt { get; set; }
		public int worktime { get; set; }
		public int wmployme { get; set; }
		public int occupat { get; set; }
		public int lstwrk1 { get; set; }
		public int industr { get; set; }
		public int workingd { get; set; }
		public int income { get; set; }
		public int pespweig { get; set; }
	}
}