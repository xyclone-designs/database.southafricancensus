using Database.SouthAfricanCensus.CSVs;
using Database.SouthAfricanCensus.Enums;
using Database.SouthAfricanCensus.Models;

using System;
using System.IO;

namespace Database.SouthAfricanCensus.Tables
{
	[SQLite.Table("households")]
    public class Household : _Table
	{
		[SQLite.Table("households")]
		public class Individual : Household
		{
			public Individual() { }
			public Individual(Household household)
			{
				Pk = household.Pk;
			}

			[SQLite.AutoIncrement]
			[SQLite.NotNull]
			[SQLite.PrimaryKey]
			[SQLite.Unique]
			public new int Pk { get; set; }
		}

		public uint? QN_TYPE;
		public long? SN;
		public uint? H01_QUARTERS;
		public uint? H02_MAINDWELLING;
		public uint? H02_OTHERDWELLING;
		public uint? H02A_ROOF;
		public uint? H02A_WALL;
		public uint? H03_DININGROOMS;
		public uint? H03_LIVINGROOMS;
		public uint? H03_DINING_LIVING;
		public uint? H03_BEDROOMS;
		public uint? H03_STUDYROOMS;
		public uint? H03_MULTIPLE_USE;
		public uint? H03_OTHERROOMS;
		public uint? H03_TOTROOMS;
		public uint? H04_TENURE;
		public uint? H07_WATERPIPED;
		public uint? H08_WATERSOURCE;
		public double? H09_WATERSUPPLY;
		public double? H09A_WATERSUPPLY;
		public double? H09B_ALT_WATERSOURCE;
		public bool? HasToilet { get; set; }
		public bool? HasEnergyForCooking { get; set; }
		public bool? HasEnergyForHeating { get; set; }
		public bool? HasEnergyForLighting { get; set; }
		public bool? HasRefuse { get; set; }
		public bool? HasRefridgerator { get; set; }
		public bool? HasStove { get; set; }
		public bool? HasVacuumCleaner { get; set; }
		public bool? HasWashingMachine { get; set; }
		public bool? HasComputer { get; set; }
		public bool? HasSatellite { get; set; }
		public bool? HasDvdPlayer { get; set; }
		public bool? HasMotorcar { get; set; }
		public bool? HasTV { get; set; }
		public bool? HasRadio { get; set; }
		public bool? HasLandline { get; set; }
		public bool? HasCellphone { get; set; }
		public bool? HasPostbox { get; set; }
		public bool? HasResidentialMail { get; set; }
		public bool? HasInternet { get; set; }
		public double? HM00_DEATHS;
		public double? HM00A_DEATHSNO;
		public uint? DERH_HHAGE;
		public uint? DERH_HHPOP;
		public uint? DERH_HHSEX;
		public uint? DERH_HINCOME;
		public uint? DERH_HH_EMPLOY_STATUS;
		public uint? DERH_HSIZE;
		public double? DERH_XPOP;
		public uint? DERH_INCOME_CLASS;

		public Location? Location { get; set; }

		public static Household FromCSV(CSVRow2011Household csvrow2011household)
		{
			return new Household { };
		}
	}

	public static partial class StreamWriterExtensions
	{
		public static void Log(this StreamWriter streamwriter, Household household)
		{
			streamwriter.Log(household as _Table);
		}
		public static void LogError(this StreamWriter streamwriter, Household household)
		{
			streamwriter.LogError(household as _Table);
		}
	}
}