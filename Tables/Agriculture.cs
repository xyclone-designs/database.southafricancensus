using Database.SouthAfricanCensus.Inputs.CSVs;
using Database.SouthAfricanCensus.Enums;
using Database.SouthAfricanCensus.Models;

using System;
using System.IO;

namespace Database.SouthAfricanCensus.Tables
{
	[SQLite.Table("agricultures")]
    public class Agriculture : _Table
	{
		[SQLite.Table("agricultures")]
		public class Individual : Agriculture
		{
			public Individual() { }
			public Individual(Agriculture agriculture)
			{
				Pk = agriculture.Pk;
			}

			[SQLite.AutoIncrement]
			[SQLite.NotNull]
			[SQLite.PrimaryKey]
			[SQLite.Unique]
			public new int Pk { get; set; }
		}

		public static Agriculture FromCSV(CSVRow2011Agriculture csvrow2011agriculture)
		{
			return new Agriculture { };
		}
	}

	public static partial class StreamWriterExtensions
	{
		public static void Log(this StreamWriter streamwriter, Agriculture agriculture)
		{
			streamwriter.Log(agriculture as _Table);
		}
		public static void LogError(this StreamWriter streamwriter, Agriculture agriculture)
		{
			streamwriter.LogError(agriculture as _Table);
		}
	}
}