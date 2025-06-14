using System.Collections.Generic;
using System.IO;
using System.Linq;

using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Models;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;
using XycloneDesigns.Database.SouthAfricanCensus.Tables;

namespace Database.SouthAfricanCensus.Inputs.CSVs
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

		public int? province;
		public int? district;
		public int? dccode;
		public int? newla;
		public int? hhnumber;
		public int? personno;
		public string? hhrecord;
		public int? urban;
		public int? insttype;
		public int? sex;
		public int? age;
		public int? relship;
		public int? marstau;
		public int? race;
		public int? languag1;
		public int? languag2;
		public int? religion;
		public int? birthcou;
		public int? citizenc;
		public int? citizeno;
		public int? citizenr;
		public int? migworke;
		public int? tempresi;
		public int? usualdis;
		public int? movedy2;
		public int? moveddis;
		public int? disablec;
		public int? sight;
		public int? hearing;
		public int? physical;
		public int? mental;
		public int? motheral;
		public int? fatheral;
		public int? chilborn;
		public int? childliv;
		public int? agefrstb;
		public int? bornlast;
		public int? school;
		public int? qualfld;
		public int? study;
		public int? quallev;
		public int? deducode;
		public int? econactt;
		public int? worktime;
		public int? wmployme;
		public int? occupat;
		public int? lstwrk1;
		public int? industr;
		public int? workingd;
		public int? income;
		public double? pespweig;

		public RecordPerson AsModel(StreamWriter logger)
		{
			Dictionary<string, object> errors = [];
			RecordPerson model = new()
			{
				Number = personno,
				TenPercentWeight = pespweig,

				Disabilities = new Disabilities
				{
					Sight = Uncertain.From<bool>(sight),
					Hearing = Uncertain.From<bool>(hearing),
					Physical = Uncertain.From<bool>(physical),
					Mental = Uncertain.From<bool>(mental),
				},
				Household = new Household
				{
					Number = hhnumber,
				},
				Location = new Location
				{
					CouncilCodeDistrict = district,
					CouncilCodeMagisterial = dccode,
					CouncilCodeTransitionalLocalRural = newla,

					Urban = Uncertain.From<bool>(urban ? 2 : 1),
				},
				Metadata = new Metadata { },
				Motherhood = new Motherhood 
				{
					ChildrenBorn = Uncertain.From<int>(chilborn),
					ChildrenAlive = Uncertain.From<int>(childliv),
					AgeAtFirstBorn = Uncertain.From<int>(agefrstb),
					NumberBirthsLast12Months = Uncertain.From<int>(bornlast),
				},
				Occupation = new Occupation { },
				Personhood = new Personhood
				{
					Age = Uncertain.From<int>(age),
					IsAliveFather = Uncertain.From<bool>(fatheral),
					IsAliveMother = Uncertain.From<bool>(motheral),
					Occupation = occupat
				},
				Residence = new Residence 
				{
					UsualMagesterialCode = usualdis,
					PreviousMagesterialCode = moveddis,
					UsualYearMoved = Uncertain.From<int>(movedy2),
				},
			};

			if (province is not null)
			{
				if (default(Provinces).FromInt(province.Value, Years._1996) is Provinces _province)
					model.Location.Province = Uncertain.From<Provinces>((int?)_province);
				else errors.Add(nameof(province), province);
			}			
			if (hhrecord is not null)
			{
				if (default(TypeQuestionnaireHouseholds).From(hhrecord, Years._1996, out TypeQuestionnaireHouseholds? _hhrecord, out NotAvailables? _hhrecordna))
					model.Household. = Uncertain.From<TypeQuestionnaireHouseholds>((int?)_hhrecord ?? (int?)_hhrecordna);
				else errors.Add(nameof(hhrecord), hhrecord);
			}
			if (insttype is not null)
			{
				if (default(TypeInstitution).FromInt(insttype.Value, Years._1996, out TypeInstitution? _insttype, out NotAvailables? _insttypena))
					model.Metadata.TypeInstitution = Uncertain.From<TypeInstitution>((int?)_insttype ?? (int?)_insttypena);
				else errors.Add(nameof(insttype), insttype);
			}
			if (sex is not null)
			{
				if (default(Sexes).FromInt(sex.Value, Years._1996, out Sexes? _sex, out NotAvailables? _sexna))
					model.Personhood.Gender = Uncertain.From<Sexes>((int?)_sex ?? (int?)_sexna);
				else errors.Add(nameof(sex), sex);
			}
			if (relship is not null)
			{
				if (default(Relations).FromInt(relship.Value, Years._1996, out Relations? _relship, out NotAvailables? _relshipna))
					model.Household.HeadOfRelationship = Uncertain.From<Relations>((int?)_relship ?? (int?)_relshipna);
				else errors.Add(nameof(relship), relship);
			}
			if (marstau is not null)
			{
				if (default(MaritalStatuses).FromInt(marstau.Value, Years._1996, out MaritalStatuses? _marstau, out NotAvailables? _marstauna))
					model.Personhood.MaritalStatus = Uncertain.From<MaritalStatuses>((int?)_marstau ?? (int?)_marstauna);
				else errors.Add(nameof(marstau), marstau);
			}
			if (race is not null)
			{
				if (default(PopulationGroups).FromInt(race.Value, Years._1996, out PopulationGroups? _race, out NotAvailables? _racena))
					model.Personhood.Race = Uncertain.From<PopulationGroups>((int?)_race ?? (int?)_racena);
				else errors.Add(nameof(race), race);
			}
			if (languag1 is not null)
			{
				if (default(Languages).FromInt(languag1.Value, Years._1996, out Languages? _languag1, out NotAvailables? _languag1na))
					model.Personhood.Language1 = Uncertain.From<Languages>((int?)_languag1 ?? (int?)_languag1na);
				else errors.Add(nameof(languag1), languag1);
			}
			if (languag2 is not null)
			{
				if (default(Languages).FromInt(languag2.Value, Years._1996, out Languages? _languag2, out NotAvailables? _languag2na))
					model.Personhood.Language2 = Uncertain.From<Languages>((int?)_languag2 ?? (int?)_languag2na);
				else errors.Add(nameof(languag2), languag2);
			}
			if (religion is not null)
			{
				if (default(Religions).FromInt(religion.Value, Years._1996, out Religions? _religion, out NotAvailables? _religionna))
					model.Personhood.Religion = Uncertain.From<Religions>((int?)_religion ?? (int?)_religionna);
				else errors.Add(nameof(religion), religion);
			}
			if (birthcou is not null)
			{
				if (default(Countries).FromInt(birthcou.Value, Years._1996, out Countries? _birthcou, out NotAvailables? _birthcouna))
					model.Personhood.CountryBirth = Uncertain.From<Countries>((int?)_birthcou ?? (int?)_birthcouna);
				else errors.Add(nameof(birthcou), birthcou);
			}
			if (citizenc is not null)
			{
				if (default(CitizenshipStatus).FromInt(citizenc.Value, Years._1996, out CitizenshipStatus? _citizenc, out NotAvailables? _citizencna))
					model.Personhood.Citizenship = Uncertain.From<CitizenshipStatus>((int?)_citizenc ?? (int?)_citizencna);
				else errors.Add(nameof(citizenc), citizenc);
			}			
			if (citizeno is not null)
			{
				if (default(Countries).FromInt(citizeno.Value, Years._1996, out Countries? _citizeno, out NotAvailables? _citizenona))
					model.Personhood.CountryCitizenOther = Uncertain.From<Countries>((int?)_citizeno ?? (int?)_citizenona);
				else errors.Add(nameof(citizeno), citizeno);
			}
			if (citizenr is not null)
			{
				if (default(Countries).FromInt(citizenr.Value, Years._1996, out Countries? _citizenr, out NotAvailables? _citizenrna))
					model.Personhood.CountryCitizenSouthAfrica = Uncertain.From<Countries>((int?)_citizenr ?? (int?)_citizenrna);
				else errors.Add(nameof(citizenr), citizenr);
			}
			
			if (migworke is not null)
			{
				if (default(TypeDisability).FromInt(migworke.Value, Years._1996, out TypeDisability? _migworke, out NotAvailables? _migworkena))
					model.P.Type = Uncertain.From<TypeDisability>((int?)_migworke ?? (int?)_migworkena);
				else errors.Add(nameof(migworke), migworke);
			}
			
			if (tempresi is not null)
			{
				if (default(UsualResidence).FromInt(tempresi.Value, Years._1996, out UsualResidence? _tempresi, out NotAvailables? _tempresina))
					model.Residence.UsualPlaceOf = Uncertain.From<UsualResidence>((int?)_tempresi ?? (int?)_tempresina);
				else errors.Add(nameof(tempresi), tempresi);
			}
			if (disablec is not null)
			{
				if (default(TypeDisability).FromInt(disablec.Value, Years._1996, out TypeDisability? _disablec, out NotAvailables? _disablecna))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_disablec ?? (int?)_disablecna);
				else errors.Add(nameof(disablec), disablec);
			}


			if (school is not null)
			{
				if (default(EducationLevels).FromInt(school.Value, Years._1996, out EducationLevels? _school, out NotAvailables? _schoolna))
					model.Personhood.HighestSchoolClass1 = Uncertain.From<EducationLevels>((int?)_school ?? (int?)_schoolna);
				else errors.Add(nameof(school), school);
			}
			if (qualfld is not null)
			{
				if (default(EducationFields).FromInt(qualfld.Value, Years._1996, out EducationFields? _qualfld, out NotAvailables? _qualfldna))
					model.Personhood.HighestQualification1 = Uncertain.From<EducationFields>((int?)_qualfld ?? (int?)_qualfldna);
				else errors.Add(nameof(qualfld), qualfld);
			}
			
			if (study is not null)
			{
				if (default(StatusStudying).FromInt(study.Value, Years._1996, out StatusStudying? _study, out NotAvailables? _studyna))
					model.Personhood.StatusStudying = Uncertain.From<StatusStudying>((int?)_study ?? (int?)_studyna);
				else errors.Add(nameof(study), study);
			}
			
			if (quallev is not null)
			{
				if (default(EducationLevels).FromInt(quallev.Value, Years._1996, out EducationLevels? _quallev, out NotAvailables? _quallevna))
					model.Personhood.HighestSchoolClass2 = Uncertain.From<EducationLevels>((int?)_quallev ?? (int?)_quallevna);
				else errors.Add(nameof(quallev), quallev);
			}
			
			if (deducode is not null)
			{
				if (default(EducationLevels).FromInt(deducode.Value, Years._1996, out EducationLevels? _deducode, out NotAvailables? _deducodena))
					model.Personhood.HighestQualification2 = Uncertain.From<EducationLevels>((int?)_deducode ?? (int?)_deducodena);
				else errors.Add(nameof(deducode), deducode);
			}
			
			if (econactt is not null)
			{
				if (default(EmploymentStatuses).FromInt(econactt.Value, Years._1996, out EmploymentStatuses? _econactt, out NotAvailables? _econacttna))
					model.Personhood.StatusEmployment = Uncertain.From<EmploymentStatuses>((int?)_econactt ?? (int?)_econacttna);
				else errors.Add(nameof(econactt), econactt);
			}
			
			if (worktime is not null)
			{
				if (default(TypeDisability).FromInt(worktime.Value, Years._1996, out TypeDisability? _worktime, out NotAvailables? _worktimena))
					model.Disabilities.Type = Uncertain.From<TypeDisability>((int?)_worktime ?? (int?)_worktimena);
				else errors.Add(nameof(disablec), disablec);
			}
			
			if (wmployme is not null)
			{
				if (default(EmploymentStatuses).FromInt(wmployme.Value, Years._1996, out EmploymentStatuses? _wmployme, out NotAvailables? _wmploymena))
					model.Personhood.StatusEmployment = Uncertain.From<EmploymentStatuses>((int?)_wmployme ?? (int?)_wmploymena);
				else errors.Add(nameof(disablec), disablec);
			}
			
			if (lstwrk1 is not null)
			{
				if (default(TypeDisability).FromInt(lstwrk1.Value, Years._1996, out TypeDisability? _lstwrk1, out NotAvailables? _lstwrk1na))
					model.Personhood.La = Uncertain.From<TypeDisability>((int?)_lstwrk1 ?? (int?)_lstwrk1na);
				else errors.Add(nameof(disablec), disablec);
			}
			
			if (industr is not null)
			{
				if (default(TypeDisability).FromInt(industr.Value, Years._1996, out TypeDisability? _industr, out NotAvailables? _industrna))
					model.Type = Uncertain.From<TypeDisability>((int?)_industr ?? (int?)_industrna);
				else errors.Add(nameof(disablec), disablec);
			}
			
			if (workingd is not null)
			{
				if (default(TypeDisability).FromInt(workingd.Value, Years._1996, out TypeDisability? _workingd, out NotAvailables? _workingdna))
					model.Personhood.Type = Uncertain.From<TypeDisability>((int?)_workingd ?? (int?)_workingdna);
				else errors.Add(nameof(workingd), workingd);
			}
			
			if (income is not null)
			{
				if (default(IncomeLevelsMonthly).FromInt(income.Value, Years._1996, out IncomeLevelsMonthly? _income, out NotAvailables? _incomena))
					model.Personhood.IncomeLevel = Uncertain.From<IncomeLevelsMonthly>((int?)_income ?? (int?)_incomena);
				else errors.Add(nameof(income), income);
			}
			
			if (errors.Count > 0)
				logger?.WriteLine("[{0}]: {1}", LineNumber, string.Join(", ", errors.Select(_ => string.Format("[{0} {1}]", _.Key, _.Value))na);

			return model;
		}
		public RecordsPerson AsRecord(StreamWriter logger)
		{
			RecordsPerson records = new ()
			{ 

			};

			return records;
		}
	}
}