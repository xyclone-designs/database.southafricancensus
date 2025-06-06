using Database.SouthAfricanCensus.Enums;
using Database.SouthAfricanCensus.Inputs.CSVs;

using ICSharpCode.SharpZipLib.GZip;

using Newtonsoft.Json.Linq;

using SQLite;

using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Database.SouthAfricanCensus
{
	internal partial class Program
	{
		static readonly string DirectoryNameOutput = ".output";
		static readonly string DirectoryNameInput = ".input";

		//static readonly string DirectoryCurrent = Directory.GetCurrentDirectory();
		static readonly string DirectoryCurrent = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName!;

		static readonly string DirectoryOutput = Path.Combine(DirectoryCurrent, DirectoryNameOutput);
		static readonly string DirectoryInput = Path.Combine(DirectoryCurrent, DirectoryNameInput);
		
		static readonly string DirectoryInputCensus = Path.Combine(DirectoryInput, "census10%");
		static readonly string DirectoryInputCensus1996 = Path.Combine(DirectoryInputCensus, "1996");
		static readonly string[] DirectoryInputCensus1996All = new string[]
		{
			Path.Combine(DirectoryInputCensus1996, "1996.Household.zip"),
			Path.Combine(DirectoryInputCensus1996, "1996.Person.zip"),
		};
		static readonly string DirectoryInputCensus2001 = Path.Combine(DirectoryInputCensus, "2001");
		static readonly string[] DirectoryInputCensus2001All = new string[]
		{
			Path.Combine(DirectoryInputCensus2001, "2001.Household.zip"),
			Path.Combine(DirectoryInputCensus2001, "2001.Mortality.zip"),
			Path.Combine(DirectoryInputCensus2001, "2001.Person.zip"),
		};
		static readonly string DirectoryInputCensus2011 = Path.Combine(DirectoryInputCensus, "2011");
		static readonly string[] DirectoryInputCensus2011All = new string[]
		{
			Path.Combine(DirectoryInputCensus2011, "2011.Agriculture.zip"),
			Path.Combine(DirectoryInputCensus2011, "2011.Household.zip"),
			Path.Combine(DirectoryInputCensus2011, "2011.Mortality.zip"),
			Path.Combine(DirectoryInputCensus2011, "2011.Person.zip"),
		};
		static readonly string DirectoryInputCensus2022 = Path.Combine(DirectoryInputCensus, "2022");
		static readonly string[] DirectoryInputCensus2022All = new string[] 
		{
			Path.Combine(DirectoryInputCensus2022, "2022.sample_F18.zip"),
			Path.Combine(DirectoryInputCensus2022, "2022.sample_F19.zip"),
			Path.Combine(DirectoryInputCensus2022, "2022.sample_F21.zip"),
		};

		static readonly string DirectoryInputMetadata = Path.Combine(DirectoryInput, "metadata10%");
		static readonly string DirectoryInputMetadata1996 = Path.Combine(DirectoryInputMetadata, "1996");
		static readonly string[] DirectoryInputMetadata1996CodesArea = new string[]
		{
			Path.Combine(DirectoryInputMetadata1996, "codes.area.txt"),
		};
		static readonly string[] DirectoryInputMetadata1996CodesDistrictMagisterial = new string[]
		{
			Path.Combine(DirectoryInputMetadata1996, "codes.district.magisterial.txt"),
		};
		static readonly string[] DirectoryInputMetadata1996CodesDistrictCouncil = new string[]
		{
			Path.Combine(DirectoryInputMetadata1996, "codes.district.council.txt"),
		};
		static readonly string[] DirectoryInputMetadata1996CodesIndustry = new string[]
		{
			Path.Combine(DirectoryInputMetadata1996, "codes.occupation.1.txt"),
			Path.Combine(DirectoryInputMetadata1996, "codes.occupation.2.txt"),
			Path.Combine(DirectoryInputMetadata1996, "codes.occupation.3.txt"),
		};
		static readonly string[] DirectoryInputMetadata1996CodesOccupation = new string[]
		{
			Path.Combine(DirectoryInputMetadata1996, "codes.occupation.1.txt"),
			Path.Combine(DirectoryInputMetadata1996, "codes.occupation.2.txt"),
			Path.Combine(DirectoryInputMetadata1996, "codes.occupation.3.txt"),
		};

		static readonly string DirectoryInputMetadata2001 = Path.Combine(DirectoryInputMetadata, "2001");
		static readonly string[] DirectoryInputMetadata2001CodesCauseOfDeath = new string[]
		{
			Path.Combine(DirectoryInputMetadata2001, "codes.causeofdeath.txt"),
		};
		static readonly string[] DirectoryInputMetadata2001CodesIndustry = new string[]
		{
			Path.Combine(DirectoryInputMetadata2001, "codes.occupation.1.txt"),
			Path.Combine(DirectoryInputMetadata2001, "codes.occupation.2.txt"),
			Path.Combine(DirectoryInputMetadata2001, "codes.occupation.3.txt"),
		};
		static readonly string[] DirectoryInputMetadata2001CodesOccupation = new string[]
		{
			Path.Combine(DirectoryInputMetadata2001, "codes.occupation.1.txt"),
			Path.Combine(DirectoryInputMetadata2001, "codes.occupation.2.txt"),
			Path.Combine(DirectoryInputMetadata2001, "codes.occupation.3.txt"),
		};
		static readonly string[] DirectoryInputMetadata2001CodesReligion = new string[]
		{
			Path.Combine(DirectoryInputMetadata2001, "codes.religion.txt"),
		};
		static readonly string DirectoryInputMetadata2011 = Path.Combine(DirectoryInputMetadata, "2011");
		static readonly string DirectoryInputMetadata2022 = Path.Combine(DirectoryInputMetadata, "2022");
	}
}
