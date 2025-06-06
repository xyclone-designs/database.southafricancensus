using System;
using System.Collections.Generic;
using System.IO;

namespace Database.SouthAfricanCensus.Inputs.TXTs
{
	public class TXTCodes : _TXT
	{
		public TXTCodes(string filepath) : base(filepath) { }

		public IEnumerable<TCode> GetCodes<TCode>() where TCode : Code
		{
			if (typeof(TCode) == typeof(CodePair))
				foreach (string line in TextLines)
				{
					Console.WriteLine(line);

					if (line.Split(',', 2) is string[] split && new CodePair
					{
						ItemOne = split[0],
						ItemTwo = split[1],

					} is TCode codepair) yield return codepair;
				}
			else if (typeof(TCode) == typeof(CodeTriplet))
				foreach (string line in TextLines)
				{
					Console.WriteLine(line);

					if (line.Split(',', 3) is string[] split && new CodeTriplet
					{
						ItemOne = split[0],
						ItemTwo = split[1],
						ItemThree = split[2],

					} is TCode codetriplet) yield return codetriplet;
				}
			else if (typeof(TCode) == typeof(CodeSextuplet))
				foreach (string line in TextLines)
				{
					Console.WriteLine(line);

					if (line.Split(',', 6) is string[] split && new CodeSextuplet
					{
						ItemOne = split[0],
						ItemTwo = split[1],
						ItemThree = split[2],
						ItemFour = split[3],
						ItemFive = split[4],
						ItemSix = split[5],

					} is TCode codesextuplet) yield return codesextuplet;
				}
		}

		public class Code { }
		public class CodePair : Code 
		{
			public string? ItemOne { get; set; }
			public string? ItemTwo { get; set; }
		}
		public class CodeTriplet : CodePair
		{
			public string? ItemThree { get; set; }
		}
		public class CodeQuadtruplet : CodeTriplet
		{
			public string? ItemFour { get; set; }
		}
		public class CodePentuplet : CodeQuadtruplet
		{
			public string? ItemFive { get; set; }
		}
		public class CodeSextuplet : CodePentuplet
		{
			public string? ItemSix { get; set; }
		}
	}

	public static partial class StreamWriterExtensions
	{
		public static void Log(this StreamWriter streamwriter, TXTCodes txtcodes) { }
		public static void LogError(this StreamWriter streamwriter, TXTCodes txtcodes) { }
	}
}
