using Database.SouthAfricanCensus.Inputs.TXTs;

using System.IO;
using Database.SouthAfricanCensus.Enums;
using System;

namespace Database.SouthAfricanCensus.Tables
{
	[SQLite.Table("Codes")]
    public class Code : _Table
	{
		[SQLite.Table("codes")]
		public class Individual : Code
		{
			public Individual() { }
			public Individual(Code code)
			{
				Pk = code.Pk;
			}

			[SQLite.AutoIncrement]
			[SQLite.NotNull]
			[SQLite.PrimaryKey]
			[SQLite.Unique]
			public new int Pk { get; set; }
		}
		
		public Years? Years { get; set; }
		public CodeTypes? Type { get; set; }
		public string? CodePair { get; set; }
		public string? CodeTriplet { get; set; }
		public string? CodeSextuplet { get; set; }

		public static Code FromTXTCodePair(TXTCodes.CodePair txtcodepair, Action<Code>? oncode)
		{
			Code code = new ()
			{
				CodePair = string.Format(
					"{0}::{1}",
					txtcodepair.ItemOne?.ToString() ?? "null", 
					txtcodepair.ItemTwo ?? "null")
			};

			oncode?.Invoke(code);

			return code;
		}
		public static Code FromTXTCodeTriplet(TXTCodes.CodeTriplet txtCodeTriplet, Action<Code>? oncode)
		{
			Code code = new ()
			{
				CodeTriplet = string.Format(
					"{0}::{1}::{2}",
					txtCodeTriplet.ItemOne?.ToString() ?? "null", 
					txtCodeTriplet.ItemTwo ?? "null", 
					txtCodeTriplet.ItemThree ?? "null")
			};

			oncode?.Invoke(code);

			return code;
		}
		public static Code FromTXTCodeSextuplet(TXTCodes.CodeSextuplet txtcodesextuplet, Action<Code>? oncode)
		{
			Code code = new ()
			{
				CodeSextuplet = string.Format(
					"{0}::{1}::{2}::{3}::{4}::{5}",
					txtcodesextuplet.ItemOne?.ToString() ?? "null", 
					txtcodesextuplet.ItemTwo ?? "null",
					txtcodesextuplet.ItemThree ?? "null",
					txtcodesextuplet.ItemFour ?? "null",
					txtcodesextuplet.ItemFive ?? "null",
					txtcodesextuplet.ItemSix ?? "null")
			};

			oncode?.Invoke(code);

			return code;
		}
	}

	public static partial class StreamWriterExtensions
	{
		public static void Log(this StreamWriter streamwriter, Code code)
		{
			streamwriter.Log(code as _Table);
		}
		public static void LogError(this StreamWriter streamwriter, Code code)
		{
			streamwriter.LogError(code as _Table);
		}
	}
}