using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;
using XycloneDesigns.Database.SouthAfricanCensus.Tables;

namespace Database.SouthAfricanCensus.Inputs.CSVs
{
	public class CSVRow1996Household : CSVRow1996
    {
		public class Positions
		{
			public const int province = 00;
			public const int district = 01;
			public const int dccode = 02;
			public const int newla = 03;
			public const int hhnumber = 04;
			public const int questype = 05;
			public const int urban = 06;
			public const int addmon2 = 07;
			public const int payment2 = 08;
			public const int migrant = 09;
			public const int hhmigran = 10;
			public const int dwelling = 11;
			public const int rooms = 12;
			public const int nsharedh = 13;
			public const int owend = 14;
			public const int fuelcook = 15;
			public const int fuelheat = 16;
			public const int fuelligh = 17;
			public const int water = 18;
			public const int toilet = 19;
			public const int refuse = 20;
			public const int telephon = 21;
			public const int hohrace = 22;
			public const int hohsex = 23;
			public const int hohage = 24;
			public const int hoheduca = 25;
			public const int hohocp1 = 26;
			public const int hohecona = 27;
			public const int hhsize = 28;
			public const int hinchh = 29;
			public const int hinchhra = 30;
			public const int hinchhse = 31;
			public const int hhinccat = 32;
			public const int peshhwei = 33;
		}

		public CSVRow1996Household(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{
				ProcessInt(LineSplit[Positions.province], logger, nameof(province), out province),
				ProcessInt(LineSplit[Positions.district], logger, nameof(district), out district),
				ProcessInt(LineSplit[Positions.dccode], logger, nameof(dccode), out dccode),
				ProcessInt(LineSplit[Positions.newla], logger, nameof(newla), out newla),
				ProcessInt(LineSplit[Positions.hhnumber], logger, nameof(hhnumber), out hhnumber),
				ProcessString(LineSplit[Positions.questype], logger, nameof(questype), out questype),
				ProcessInt(LineSplit[Positions.urban], logger, nameof(urban), out urban),
				ProcessInt(LineSplit[Positions.addmon2], logger, nameof(addmon2), out addmon2),
				ProcessInt(LineSplit[Positions.payment2], logger, nameof(payment2), out payment2),
				ProcessInt(LineSplit[Positions.migrant], logger, nameof(migrant), out migrant),
				ProcessInt(LineSplit[Positions.hhmigran], logger, nameof(hhmigran), out hhmigran),
				ProcessInt(LineSplit[Positions.dwelling], logger, nameof(dwelling), out dwelling),
				ProcessInt(LineSplit[Positions.rooms], logger, nameof(rooms), out rooms),
				ProcessInt(LineSplit[Positions.nsharedh], logger, nameof(nsharedh), out nsharedh),
				ProcessInt(LineSplit[Positions.owend], logger, nameof(owend), out owend),
				ProcessInt(LineSplit[Positions.fuelcook], logger, nameof(fuelcook), out fuelcook),
				ProcessInt(LineSplit[Positions.fuelheat], logger, nameof(fuelheat), out fuelheat),
				ProcessInt(LineSplit[Positions.fuelligh], logger, nameof(fuelligh), out fuelligh),
				ProcessInt(LineSplit[Positions.water], logger, nameof(water), out water),
				ProcessInt(LineSplit[Positions.toilet], logger, nameof(toilet), out toilet),
				ProcessInt(LineSplit[Positions.refuse], logger, nameof(refuse), out refuse),
				ProcessInt(LineSplit[Positions.telephon], logger, nameof(telephon), out telephon),
				ProcessInt(LineSplit[Positions.hohrace], logger, nameof(hohrace), out hohrace),
				ProcessInt(LineSplit[Positions.hohsex], logger, nameof(hohsex), out hohsex),
				ProcessInt(LineSplit[Positions.hohage], logger, nameof(hohage), out hohage),
				ProcessInt(LineSplit[Positions.hoheduca], logger, nameof(hoheduca), out hoheduca),
				ProcessInt(LineSplit[Positions.hohocp1], logger, nameof(hohocp1), out hohocp1),
				ProcessInt(LineSplit[Positions.hohecona], logger, nameof(hohecona), out hohecona),
				ProcessInt(LineSplit[Positions.hhsize], logger, nameof(hhsize), out hhsize),
				ProcessInt(LineSplit[Positions.hinchh], logger, nameof(hinchh), out hinchh),
				ProcessInt(LineSplit[Positions.hinchhra], logger, nameof(hinchhra), out hinchhra),
				ProcessInt(LineSplit[Positions.hinchhse], logger, nameof(hinchhse), out hinchhse),
				ProcessInt(LineSplit[Positions.hhinccat], logger, nameof(hhinccat), out hhinccat),
				ProcessDouble(LineSplit[Positions.peshhwei], logger, nameof(peshhwei), out peshhwei),

			}.Any(_ => _ == false)) logger.WriteLine();
		}

		public int? province;
		public int? district;
		public int? dccode;
		public int? newla;
		public int? hhnumber;
		public string? questype;
		public int? urban;
		public int? addmon2;
		public int? payment2;
		public int? migrant;
		public int? hhmigran;
		public int? dwelling;
		public int? rooms;
		public int? nsharedh;
		public int? owend;
		public int? fuelcook;
		public int? fuelheat;
		public int? fuelligh;
		public int? water;
		public int? toilet;
		public int? refuse;
		public int? telephon;
		public int? hohrace;
		public int? hohsex;
		public int? hohage;
		public int? hoheduca;
		public int? hohocp1;
		public int? hohecona;
		public int? hhsize;
		public int? hinchh;
		public int? hinchhra; 
		public int? hinchhse;
		public int? hhinccat;
		public double? peshhwei;

		public RecordsHousehold AsRecord(StreamWriter? logger)
		{
			Dictionary<string, object> errors = [];
			RecordsHousehold record = new()
			{
				CouncilCodeDistrict = district,
				CouncilCodeMagisterial = dccode,
				Number = hhnumber,
				TenPercentWeight = peshhwei,

				_DwellingsOwned = Uncertain.From<bool>(hohage),
				_HeadOf_Age = Uncertain.From<int>(hohage),
				_Migrant = Uncertain.From<bool>(migrant),
				_NumberOf_MigrantWorkers = Uncertain.From<int>(hhmigran),
				_NumberOf_HouseholdsSharingOneRoom = Uncertain.From<int>(nsharedh),
				_Rooms = Uncertain.From<int>(rooms),
				_Urban = Uncertain.From<bool>(urban),
			};

			if (toilet is not null)
			{
				if (default(FacilitiesToilet).FromInt(toilet.Value, Years._1996, out FacilitiesToilet? _toilet, out NotAvailables? _toiletna))
					record.FacilitiesToilet = ((int?)_toilet)?.ToString() ?? (-(int?)_toiletna)?.ToString();
				else errors.Add(nameof(toilet), toilet);
			}
			if (telephon is not null)
			{
				if (default(FacilitiesTelephone).FromInt(telephon.Value, Years._1996, out FacilitiesTelephone? _telephon, out NotAvailables? _telephonna))
					record.FacilitiesTelephone = ((int?)_telephon)?.ToString() ?? (-(int?)_telephonna)?.ToString();
				else errors.Add(nameof(telephon), telephon);
			}
			if (refuse is not null)
			{
				if (default(FacilitiesRefuseDisposal).FromInt(refuse.Value, Years._1996, out FacilitiesRefuseDisposal? _refuse, out NotAvailables? _refusena))
					record.FacilitiesRefuseDisposal = ((int?)_refuse)?.ToString() ?? (-(int?)_refusena)?.ToString();
				else errors.Add(nameof(refuse), refuse);
			}
			if (dwelling is not null)
			{
				if (default(TypeDwelling).FromInt(dwelling.Value, Years._1996, out TypeDwelling? _dwelling, out NotAvailables? _dwellingna))
					record.Dwelling = ((int?)_dwelling)?.ToString() ?? (-(int?)_dwellingna)?.ToString();
				else errors.Add(nameof(dwelling), dwelling);
			}
			if (hoheduca is not null)
			{
				if (default(EducationLevels).FromInt(hoheduca.Value, Years._1996, out EducationLevels? _hoheduca, out NotAvailables? _hoheducana))
					record.HeadOf_Education = ((int?)_hoheduca)?.ToString() ?? (-(int?)_hoheducana)?.ToString();
				else errors.Add(nameof(hoheduca), hoheduca);
			}
			if (hohecona is not null)
			{
				if (default(EmploymentStatuses).FromInt(hohecona.Value, Years._1996, out EmploymentStatuses? _hohecona, out NotAvailables? _hoheconana))
					record.HeadOf_EmploymentStatus = ((int?)_hohecona)?.ToString() ?? (-(int?)_hoheconana)?.ToString();
				else errors.Add(nameof(hohecona), hohecona);
			}
			if (hhinccat is not null)
			{
				if (default(IncomeLevelsMonthly).FromInt(hhinccat.Value, Years._1996, out IncomeLevelsMonthly? _hhinccat, out NotAvailables? _hhinccatna))
					record.HeadOf_IncomeLevel = ((int?)_hhinccat)?.ToString() ?? (-(int?)_hhinccatna)?.ToString();
				else errors.Add(nameof(hhinccat), hhinccat);
			}
			if (hohrace is not null)
			{
				if (default(PopulationGroups).FromInt(hohrace.Value, Years._1996, out PopulationGroups? _hohrace, out NotAvailables? _hohracena))
					record.HeadOf_Race = ((int?)_hohrace)?.ToString() ?? (-(int?)_hohracena)?.ToString();
				else errors.Add(nameof(hohrace), hohrace);
			}
			if (hohsex is not null)
			{
				if (default(Sexes).FromInt(hohsex.Value, Years._1996, out Sexes? _hohsex, out NotAvailables? _hohsexna))
					record.HeadOf_Sex = ((int?)_hohsex)?.ToString() ?? (-(int?)_hohsexna)?.ToString();
				else errors.Add(nameof(hohsex), hohsex);
			}
			if (hinchhse is not null)
			{
				if (default(Sexes).FromInt(hinchhse.Value, Years._1996, out Sexes? _hinchhse, out NotAvailables? _hinchhsena))
					record.HighestIncomeIn_Gender = ((int?)_hinchhse)?.ToString() ?? (-(int?)_hinchhsena)?.ToString();
				else errors.Add(nameof(hinchhse), hinchhse);
			}
			if (hinchhra is not null)
			{
				if (default(PopulationGroups).FromInt(hinchhra.Value, Years._1996, out PopulationGroups? _hinchhra, out NotAvailables? _hinchhrana))
					record.HighestIncomeIn_Race = ((int?)_hinchhra)?.ToString() ?? (-(int?)_hinchhrana)?.ToString();
				else errors.Add(nameof(hinchhra), hinchhra);
			}
			if (fuelcook is not null)
			{
				if (default(SourceOfFuel).FromInt(fuelcook.Value, Years._1996, out SourceOfFuel? _fuelcook, out NotAvailables? _fuelcookna))
					record.SourceOfFuelCooking = ((int?)_fuelcook)?.ToString() ?? (-(int?)_fuelcookna)?.ToString();
				else errors.Add(nameof(fuelcook), fuelcook);
			}
			if (fuelheat is not null)
			{
				if (default(SourceOfFuel).FromInt(fuelheat.Value, Years._1996, out SourceOfFuel? _fuelheat, out NotAvailables? _fuelheatna))
					record.SourceOfFuelHeating = ((int?)_fuelheat)?.ToString() ?? (-(int?)_fuelheatna)?.ToString();
				else errors.Add(nameof(fuelheat), fuelheat);
			}
			if (fuelligh is not null)
			{
				if (default(SourceOfFuel).FromInt(fuelligh.Value, Years._1996, out SourceOfFuel? _fuelligh, out NotAvailables? _fuellighna))
					record.SourceOfFuelLighting = ((int?)_fuelligh)?.ToString() ?? (-(int?)_fuellighna)?.ToString();
				else errors.Add(nameof(fuelligh), fuelligh);
			}
			if (water is not null)
			{
				if (default(SourceOfWater).FromInt(water.Value, Years._1996, out SourceOfWater? _water, out NotAvailables? _waterna))
					record.SourceOfWater = ((int?)_water)?.ToString() ?? (-(int?)_waterna)?.ToString();
				else errors.Add(nameof(water), water);
			}

			if (errors.Count > 0)
				logger?.WriteLine("[{0}]: {1}", LineNumber, string.Join(", ", errors.Select(_ => string.Format("[{0} {1}]", _.Key, _.Value))));

			return record;

			return new RecordsHousehold
			{
				Province = default(Provinces).FromInt(province, Years._1996)?.ToString() ?? null,


				//CouncilCodeTransitionalLocalRural
				
				HeadOf_Occupation = hohocp1,
				
				//Income
				//IncomeAdditional
				//IncomeReceivedRemittances
				QuestionType = questype,
				
			};
		}

		//public int? newla;
		//public int? addmon2;
		//public int? payment2;
		//public int? hinchh;
	}
}