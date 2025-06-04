using Database.SouthAfricanCensus.CSVs;
using Database.SouthAfricanCensus.Enums;
using Database.SouthAfricanCensus.Models;

using System;
using System.IO;

namespace Database.SouthAfricanCensus.Tables
{
	[SQLite.Table("mortalitys")]
    public class Mortality : _Table
	{
		[SQLite.Table("mortalitys")]
		public class Individual : Mortality
		{
			public Individual() { }
			public Individual(Mortality mortality)
			{
				Pk = mortality.Pk;
			}

			[SQLite.AutoIncrement]
			[SQLite.NotNull]
			[SQLite.PrimaryKey]
			[SQLite.Unique]
			public new int Pk { get; set; }
		}

		public DateTime? Date { get; set; }
		public Sexes? Sex { get; set; }
		public int? Age { get; set; }
		public string? Cause { get; set; }
		public PopulationGroups? PopulationGroup { get; set; }
		public GeoTypes? GeoType { get; set; }
		public Provinces? Province { get; set; }
		public string? District { get; set; }
		public string? Municipality { get; set; }

		public uint? H31Acc;

		public static Mortality FromCSV(CSVRow2001Mortality csvrow2001mortality)
		{
			return new Mortality 
			{
				SerialNumber = csvrow2001mortality.SN,
				Date = new DateTime(csvrow2001mortality.H31Yr, csvrow2001mortality.H31Mo, 0),
				Sex = csvrow2001mortality.H31Sx,
				Age = csvrow2001mortality.H31Age,
				Cause = csvrow2001mortality.M05_CAUSE,
				PopulationGroup = csvrow2001mortality.M_MX_POP_GROUP,
				GeoType = csvrow2001mortality.M_GEOTYPE,
				Province = csvrow2001mortality.H31Pr,
				TenPercentWeight = csvrow2001mortality.MMwgt,
			};
		}
		public static Mortality FromCSV(CSVRow2011Mortality csvrow2011mortality)
		{
			return new Mortality 
			{
				SerialNumber = csvrow2011mortality.SN,
				Date = new DateTime(csvrow2011mortality.M02_YEAR, csvrow2011mortality.M02_MONTH, 0),
				Sex = csvrow2011mortality.M03_SEX,
				Age = csvrow2011mortality.M04_AGE,
				Cause = csvrow2011mortality.M05_CAUSE,
				PopulationGroup = csvrow2011mortality.M_MX_POP_GROUP,
				GeoType = csvrow2011mortality.M_GEOTYPE,
				Province = csvrow2011mortality.M_PROVINCE,
				District = csvrow2011mortality.M_DISTRICT,
				Municipality = csvrow2011mortality.M_MUNIC,
				TenPercentWeight = csvrow2011mortality.MORTALITY_10PERCENT_WEIGHT,
			};
		}
	}

	public static partial class StreamWriterExtensions
	{
		public static void Log(this StreamWriter streamwriter, Mortality mortality)
		{
			streamwriter.Log(mortality as _Table);
		}
		public static void LogError(this StreamWriter streamwriter, Mortality mortality)
		{
			streamwriter.LogError(mortality as _Table);
		}
	}
}