using System.IO;
using System.Linq;

namespace Database.SouthAfricanCensus.CSVs
{
	public class CSVRow1996Person : CSVRow1996
	{
		public CSVRow1996Person(string line, StreamWriter logger) : base(line) 
		{
			if (new bool[]
			{
				ProcessInt(LineSplit[00], logger, nameof(province), out province),
				ProcessInt(LineSplit[01], logger, nameof(district), out district),
				ProcessInt(LineSplit[02], logger, nameof(dccode), out dccode),
				ProcessInt(LineSplit[03], logger, nameof(newla), out newla),
				ProcessInt(LineSplit[04], logger, nameof(hhnumber), out hhnumber),
				ProcessInt(LineSplit[05], logger, nameof(personno), out personno),
				ProcessString(LineSplit[06], logger, nameof(hhrecord), out hhrecord),
				ProcessInt(LineSplit[07], logger, nameof(urban), out urban),
				ProcessInt(LineSplit[08], logger, nameof(insttype), out insttype),
				ProcessInt(LineSplit[09], logger, nameof(sex), out sex),
				ProcessInt(LineSplit[10], logger, nameof(age), out age),
				ProcessInt(LineSplit[11], logger, nameof(relship), out relship),
				ProcessInt(LineSplit[12], logger, nameof(marstau), out marstau),
				ProcessInt(LineSplit[13], logger, nameof(race), out race),
				ProcessInt(LineSplit[14], logger, nameof(languag1), out languag1),
				ProcessInt(LineSplit[15], logger, nameof(languag2), out languag2),
				ProcessInt(LineSplit[16], logger, nameof(religion), out religion),
				ProcessInt(LineSplit[17], logger, nameof(birthcou), out birthcou),
				ProcessInt(LineSplit[18], logger, nameof(citizenc), out citizenc),
				ProcessInt(LineSplit[19], logger, nameof(citizeno), out citizeno),
				ProcessInt(LineSplit[20], logger, nameof(citizenr), out citizenr),
				ProcessInt(LineSplit[21], logger, nameof(migworke), out migworke),
				ProcessInt(LineSplit[22], logger, nameof(tempresi), out tempresi),
				ProcessInt(LineSplit[23], logger, nameof(usualdis), out usualdis),
				ProcessInt(LineSplit[24], logger, nameof(movedy2), out movedy2),
				ProcessInt(LineSplit[25], logger, nameof(moveddis), out moveddis),
				ProcessInt(LineSplit[26], logger, nameof(disablec), out disablec),
				ProcessInt(LineSplit[27], logger, nameof(sight), out sight),
				ProcessInt(LineSplit[28], logger, nameof(hearing), out hearing),
				ProcessInt(LineSplit[29], logger, nameof(physical), out physical),
				ProcessInt(LineSplit[30], logger, nameof(mental), out mental),
				ProcessInt(LineSplit[31], logger, nameof(motheral), out motheral),
				ProcessInt(LineSplit[32], logger, nameof(fatheral), out fatheral),
				ProcessInt(LineSplit[33], logger, nameof(chilborn), out chilborn),
				ProcessInt(LineSplit[34], logger, nameof(childliv), out childliv),
				ProcessInt(LineSplit[35], logger, nameof(agefrstb), out agefrstb),
				ProcessInt(LineSplit[36], logger, nameof(bornlast), out bornlast),
				ProcessInt(LineSplit[37], logger, nameof(school), out school),
				ProcessInt(LineSplit[38], logger, nameof(qualfld), out qualfld),
				ProcessInt(LineSplit[39], logger, nameof(study), out study),
				ProcessInt(LineSplit[40], logger, nameof(quallev), out quallev),
				ProcessInt(LineSplit[41], logger, nameof(deducode), out deducode),
				ProcessInt(LineSplit[42], logger, nameof(econactt), out econactt),
				ProcessInt(LineSplit[43], logger, nameof(worktime), out worktime),
				ProcessInt(LineSplit[44], logger, nameof(wmployme), out wmployme),
				ProcessInt(LineSplit[45], logger, nameof(occupat), out occupat),
				ProcessInt(LineSplit[46], logger, nameof(lstwrk1), out lstwrk1),
				ProcessInt(LineSplit[47], logger, nameof(industr), out industr),
				ProcessInt(LineSplit[48], logger, nameof(workingd), out workingd),
				ProcessInt(LineSplit[49], logger, nameof(income), out income),
				ProcessDouble(LineSplit[50], logger, nameof(pespweig), out pespweig),
				
			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public uint? province;
		public uint? district;
		public uint? dccode;
		public uint? newla;
		public uint? hhnumber;
		public uint? personno;
		public string? hhrecord;
		public uint? urban;
		public uint? insttype;
		public uint? sex;
		public uint? age;
		public uint? relship;
		public uint? marstau;
		public uint? race;
		public uint? languag1;
		public uint? languag2;
		public uint? religion;
		public uint? birthcou;
		public uint? citizenc;
		public uint? citizeno;
		public uint? citizenr;
		public uint? migworke;
		public uint? tempresi;
		public uint? usualdis;
		public uint? movedy2;
		public uint? moveddis;
		public uint? disablec;
		public uint? sight;
		public uint? hearing;
		public uint? physical;
		public uint? mental;
		public uint? motheral;
		public uint? fatheral;
		public uint? chilborn;
		public uint? childliv;
		public uint? agefrstb;
		public uint? bornlast;
		public uint? school;
		public uint? qualfld;
		public uint? study;
		public uint? quallev;
		public uint? deducode;
		public uint? econactt;
		public uint? worktime;
		public uint? wmployme;
		public uint? occupat;
		public uint? lstwrk1;
		public uint? industr;
		public uint? workingd;
		public uint? income;
		public double? pespweig;
	}
}