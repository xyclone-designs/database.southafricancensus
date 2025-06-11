using System.IO;
using System.Linq;

using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Structs;
using XycloneDesigns.Database.SouthAfricanCensus.Tables;

namespace Database.SouthAfricanCensus.Inputs.CSVs
{
	public class CSVRow1996Household : CSVRow1996
    {
		public CSVRow1996Household(string line, StreamWriter logger) : base(line)
		{
			if (new bool[]
			{
				ProcessInt(LineSplit[00], logger, nameof(province), out province),
				ProcessInt(LineSplit[01], logger, nameof(district), out district),
				ProcessInt(LineSplit[02], logger, nameof(dccode), out dccode),
				ProcessInt(LineSplit[03], logger, nameof(newla), out newla),
				ProcessInt(LineSplit[04], logger, nameof(hhnumber), out hhnumber),
				ProcessString(LineSplit[05], logger, nameof(questype), out questype),
				ProcessInt(LineSplit[06], logger, nameof(urban), out urban),
				ProcessInt(LineSplit[07], logger, nameof(addmon2), out addmon2),
				ProcessInt(LineSplit[08], logger, nameof(payment2), out payment2),
				ProcessInt(LineSplit[09], logger, nameof(migrant), out migrant),
				ProcessInt(LineSplit[10], logger, nameof(hhmigran), out hhmigran),
				ProcessInt(LineSplit[11], logger, nameof(dwelling), out dwelling),
				ProcessInt(LineSplit[12], logger, nameof(rooms), out rooms),
				ProcessInt(LineSplit[13], logger, nameof(nsharedh), out nsharedh),
				ProcessInt(LineSplit[14], logger, nameof(owend), out owend),
				ProcessInt(LineSplit[15], logger, nameof(fuelcook), out fuelcook),
				ProcessInt(LineSplit[16], logger, nameof(fuelheat), out fuelheat),
				ProcessInt(LineSplit[17], logger, nameof(fuelligh), out fuelligh),
				ProcessInt(LineSplit[18], logger, nameof(water), out water),
				ProcessInt(LineSplit[19], logger, nameof(toilet), out toilet),
				ProcessInt(LineSplit[20], logger, nameof(refuse), out refuse),
				ProcessInt(LineSplit[21], logger, nameof(telephon), out telephon),
				ProcessInt(LineSplit[22], logger, nameof(hohrace), out hohrace),
				ProcessInt(LineSplit[23], logger, nameof(hohsex), out hohsex),
				ProcessInt(LineSplit[24], logger, nameof(hohage), out hohage),
				ProcessInt(LineSplit[25], logger, nameof(hoheduca), out hoheduca),
				ProcessInt(LineSplit[26], logger, nameof(hohocp1), out hohocp1),
				ProcessInt(LineSplit[27], logger, nameof(hohecona), out hohecona),
				ProcessInt(LineSplit[28], logger, nameof(hhsize), out hhsize),
				ProcessInt(LineSplit[29], logger, nameof(hinchh), out hinchh),
				ProcessInt(LineSplit[30], logger, nameof(hinchhra), out hinchhra),
				ProcessInt(LineSplit[31], logger, nameof(hinchhse), out hinchhse),
				ProcessInt(LineSplit[32], logger, nameof(hhinccat), out hhinccat),
				ProcessDouble(LineSplit[33], logger, nameof(peshhwei), out peshhwei),

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

		public RecordsHousehold AsRecord()
		{
			return new RecordsHousehold
			{
				TenPercentWeight = peshhwei,

				Number = hhnumber,
				Province = default(Provinces).FromInt(province, Years._1996)?.ToString() ?? null,
				CouncilCodeDistrict = district,
				CouncilCodeMagisterial = dccode,
				//CouncilCodeTransitionalLocalRural
				Dwelling = default(TypeDwelling).FromInt(dwelling, Years._1996, out NotAvailables? _dwelling)?.ToString() ?? _dwelling?.ToString() ?? null,
				DwellingsOwned = default(SourceOfFuel).FromInt(owend, Years._1996, out NotAvailables? _owend)?.ToString() ?? _owend?.ToString() ?? null,
				FacilitiesToilet = default(FacilitiesToilet).FromInt(toilet, Years._1996, out NotAvailables? _toilet)?.ToString() ?? _toilet?.ToString() ?? null,
				FacilitiesTelephone = default(FacilitiesTelephone).FromInt(telephon, Years._1996, out NotAvailables? _telephon)?.ToString() ?? _telephon?.ToString() ?? null,
				FacilitiesRefuseDisposal = default(FacilitiesRefuseDisposal).FromInt(refuse, Years._1996, out NotAvailables? _refuse)?.ToString() ?? _refuse?.ToString() ?? null,
				_HeadOf_Age = Uncertain.From<int>(hohage.ToString()),
				HeadOf_Education = default(EducationFields).FromInt(hoheduca, Years._1996, out NotAvailables? _hoheduca)?.ToString() ?? _hoheduca?.ToString() ?? null,
				HeadOf_EmploymentStatus = default(EmploymentStatuses).FromInt(hohecona, Years._1996, out NotAvailables? _hohecona)?.ToString() ?? _hohecona?.ToString() ?? null,
				HeadOf_IncomeLevel = default(IncomeLevelsMonthly).FromInt(hhinccat, Years._1996, out NotAvailables? _hhinccat)?.ToString() ?? _hhinccat?.ToString() ?? null,
				HeadOf_Occupation = hohocp1,
				HeadOf_Race = default(PopulationGroups).FromInt(hohrace, Years._1996, out NotAvailables? _hohrace)?.ToString() ?? _hohrace?.ToString() ?? null,
				HeadOf_Sex = default(Sexes).FromInt(hohsex, Years._1996, out NotAvailables? _hohsex)?.ToString() ?? _hohsex?.ToString() ?? null,
				HighestIncomeIn_Gender = default(Sexes).FromInt(hinchhse, Years._1996, out NotAvailables? _hinchhse)?.ToString() ?? _hinchhse?.ToString() ?? null,
				HighestIncomeIn_Race = default(PopulationGroups).FromInt(hinchhra, Years._1996, out NotAvailables? _hinchhra)?.ToString() ?? _hinchhra?.ToString() ?? null,
				HouseholdSize = default(SourceOfFuel).FromInt(hhsize, Years._1996, out NotAvailables? _hhsize)?.ToString() ?? _hhsize?.ToString() ?? null,
				//Income
				//IncomeAdditional
				//IncomeReceivedRemittances
				_Migrant = Uncertain.From<bool>(migrant.ToString()),
				_NumberOf_MigrantWorkers = Uncertain.From<int>(hhmigran.ToString()), 
				_NumberOf_HouseholdsSharingOneRoom = Uncertain.From<int>(nsharedh.ToString()), 
				QuestionType = questype,
				_Rooms = Uncertain.From<int>(rooms.ToString()), 
				SourceOfWater = default(SourceOfWater).FromInt(water, Years._1996, out NotAvailables? _water)?.ToString() ?? _water?.ToString() ?? null, 
				SourceOfFuelCooking = default(SourceOfFuel).FromInt(fuelcook, Years._1996, out NotAvailables? _fuelcook)?.ToString() ?? _fuelcook?.ToString() ?? null,
				SourceOfFuelHeating = default(SourceOfFuel).FromInt(fuelheat, Years._1996, out NotAvailables? _fuelheat)?.ToString() ?? _fuelheat?.ToString() ?? null, 
				SourceOfFuelLighting = default(SourceOfFuel).FromInt(fuelligh, Years._1996, out NotAvailables? _fuelligh)?.ToString() ?? _fuelligh?.ToString() ?? null, 
				_Urban = Uncertain.From<bool>(urban.ToString()),
			};
		}

		//public int? newla;
		//public int? addmon2;
		//public int? payment2;
		//public int? hinchh;

		public Uncertain<Provinces>? _Province;

		public Uncertain<bool>? _DwellingsOwned;

		public Uncertain<TypeDwelling>? _Dwelling;

		public Uncertain<FacilitiesToilet>? _FacilitiesToilet;

		public Uncertain<FacilitiesTelephone>? _FacilitiesTelephone;

		public Uncertain<FacilitiesRefuseDisposal>? _FacilitiesRefuseDisposal;

		public Uncertain<int>? _HeadOf_Age;

		public Uncertain<EducationLevels>? _HeadOf_Education;

		public Uncertain<EmploymentStatuses>? _HeadOf_EmploymentStatus;

		public Uncertain<IncomeLevelsMonthly>? _HeadOf_IncomeLevel;

		public Uncertain<PopulationGroups>? _HeadOf_Race;

		public Uncertain<Sexes>? _HeadOf_Sex;

		public Uncertain<Sexes>? _HighestIncomeIn_Gender;

		public Uncertain<PopulationGroups>? _HighestIncomeIn_Race;

		public Uncertain<int>? _HouseholdSize;

		public Uncertain<IncomeLevelsMonthlyHousehold>? _Income;

		public Uncertain<IncomeLevelsMonthlyHousehold>? _IncomeAdditional;

		public Uncertain<IncomeLevelsMonthlyHousehold>? _IncomeReceivedRemittances;

		public Uncertain<bool>? _Migrant;

		public Uncertain<int>? _NumberOf_MigrantWorkers;

		public Uncertain<int>? _NumberOf_HouseholdsSharingOneRoom;

		public Uncertain<TypeQuestionnaireHouseholds>? _QuestionType;

		public Uncertain<int>? _Rooms;

		public Uncertain<bool>? _Urban;
	}
}