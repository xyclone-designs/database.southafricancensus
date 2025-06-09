using Database.SouthAfricanCensus.Inputs.CSVs;
using Database.SouthAfricanCensus.Inputs.TXTs;

using ICSharpCode.SharpZipLib.GZip;

using Newtonsoft.Json.Linq;

using SQLite;

using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

using XycloneDesigns.Database.SouthAfricanCensus.Enums;
using XycloneDesigns.Database.SouthAfricanCensus.Tables;

namespace Database.SouthAfricanCensus
{
	internal partial class Program
	{
		static void Main(string[] args)
		{
			_CleaningPre();

			 Directory.CreateDirectory(DirectoryOutput);

			string sqlconnectionpath = Path.Combine(DirectoryOutput, "southafricancensus.db");

			JArray apifiles = [];
			StreamWriters streamwriters = [];
			SQLiteConnection sqliteconnection = _SQLiteConnection(sqlconnectionpath, false);

			#region 1999
			sqliteconnection.InsertAllAndReturn(
				objs: DirectoryInputMetadata1996CodesArea
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodeSextuplet>())
					.Select(_ => new CodesArea
					{
						ProvinceCode = int.TryParse(_.ItemOne, out int provincecode) ? provincecode : new int?(),
						ProvinceName = _.ItemTwo,
						DistrictCouncilCode = int.TryParse(_.ItemOne, out int districtcouncilcode) ? districtcouncilcode : new int?(),
						DistrictCouncilName = _.ItemFour,
						TLCTRCCode = int.TryParse(_.ItemOne, out int tlctrccode) ? tlctrccode : new int?(),
						TLCTRCName = _.ItemSix,
					}));
			sqliteconnection.InsertAllAndReturn(
				objs: DirectoryInputMetadata1996CodesDistrictCouncil
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodeTriplet>())
					.Select(_ => new CodesCouncilDistrict
					{
						Code = int.TryParse(_.ItemOne, out int code) ? code : new int?(),
						ProvinceCode = int.TryParse(_.ItemTwo, out int provincecode) ? provincecode : new int?(),
						Name = _.ItemThree,
					}));
			sqliteconnection.InsertAllAndReturn(
				objs: DirectoryInputMetadata1996CodesDistrictMagisterial
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ => new CodesCouncilMagisterial
					{
						Code = int.TryParse(_.ItemOne, out int code) ? code : new int?(),
						Name = _.ItemTwo,
					}));
			sqliteconnection.InsertAllAndReturn(
				objs: DirectoryInputMetadata1996CodesIndustry
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ => new CodesIndustry
					{
						Code1Digit = _.ItemOne,
						Code2Digit = _.ItemOne,
						Code3Digit = _.ItemOne,
						Value = _.ItemTwo,
					}));
			sqliteconnection.InsertAllAndReturn(
				objs: DirectoryInputMetadata1996CodesOccupation
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ => new CodesOccupation
					{
						Code1Digit = _.ItemOne,
						Code2Digit = _.ItemOne,
						Code3Digit = _.ItemOne,
						Value = _.ItemTwo,
					}));
			#endregion

			#region 2001
			sqliteconnection.InsertAllAndReturn(
				objs: DirectoryInputMetadata2001CodesCauseOfDeath
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ =>
					{
						(string? _, string? start, string? end) code =
							_.ItemOne?.Split('-') is not string[] split 
								? (null, null, null)
								: split.Length == 2
									? (null, split[0], split[1])
									: (split[0], null, null);

						return new CodesCauseOfDeath
						{
							Code = code._,
							CodeStart = code.start,
							CodeEnd = code.end,
							Name = _.ItemTwo,
						};
					}));
			sqliteconnection.InsertAllAndReturn(
				objs: DirectoryInputMetadata2001CodesIndustry
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ => new CodesIndustry
					{
						Code1Digit = _.ItemOne,
						Code2Digit = _.ItemOne,
						Code3Digit = _.ItemOne,
						Value = _.ItemTwo,
					}));
			sqliteconnection.InsertAllAndReturn(
				objs: DirectoryInputMetadata2001CodesOccupation
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ => new CodesOccupation
					{
						Code1Digit = _.ItemOne,
						Code2Digit = _.ItemOne,
						Code3Digit = _.ItemOne,
						Value = _.ItemTwo,
					}));
			sqliteconnection.InsertAllAndReturn(
				objs: DirectoryInputMetadata2001CodesReligion
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ => new CodesReligion
					{
						Code = _.ItemOne,
						Value = _.ItemTwo,
					}));
			#endregion

			#region 1996

			foreach (string directoryinputcensusall in DirectoryInputCensus1996All)
			{
				using FileStream filestream = File.OpenRead(directoryinputcensusall);
				using ZipArchive ziparchive = new(filestream);

				Stream[] streams = ziparchive.Entries
					.Select(_ => _.Open())
					.ToArray();

				string filename = string.Join('.', directoryinputcensusall.Split('\\').Last().Split('.')[0..^1]);

				Years years = default(Years).FromFilename(filename);
				Types types = default(Types).FromFilename(filename);

				string directorypath = Path.Combine(DirectoryOutput, string.Format("{0}.{1}", years.AsString(), types));

				Directory.CreateDirectory(directorypath);
				Console.WriteLine(directorypath);

				streamwriters.Add(filename, Path.Combine(directorypath, "log.txt"));

				switch (years, types)
				{
					case (Years._1996, Types.Household):
						foreach (CSVRow1996Household csvrow1996household in Utils.CSVs.Rows<CSVRow1996Household>(streamwriters[filename], streams))
						{ }
						break;
					case (Years._1996, Types.Person):
						foreach (CSVRow1996Person csvrow1996person in Utils.CSVs.Rows<CSVRow1996Person>(streamwriters[filename], streams))
						{ }
						break;

					default: break;
				}

				streamwriters.Dispose(true, filename);
			}

			#endregion

			#region 2001

			foreach (string directoryinputcensusall in DirectoryInputCensus2001All)
			{
				using FileStream filestream = File.OpenRead(directoryinputcensusall);
				using ZipArchive ziparchive = new(filestream);

				Stream[] streams = ziparchive.Entries
					.Select(_ => _.Open())
					.ToArray();

				string filename = string.Join('.', directoryinputcensusall.Split('\\').Last().Split('.')[0..^1]);

				Years years = default(Years).FromFilename(filename);
				Types types = default(Types).FromFilename(filename);

				string directorypath = Path.Combine(DirectoryOutput, string.Format("{0}.{1}", years.AsString(), types));

				Directory.CreateDirectory(directorypath);
				Console.WriteLine(directorypath);

				streamwriters.Add(filename, Path.Combine(directorypath, "log.txt"));

				switch (years, types)
				{
					case (Years._2001, Types.Household):
						foreach (CSVRow2001Household csvrow2001household in Utils.CSVs.Rows<CSVRow2001Household>(streamwriters[filename], streams))
						{ }
						break;
					case (Years._2001, Types.Mortality):
						foreach (CSVRow2001Mortality csvrow2001mortality in Utils.CSVs.Rows<CSVRow2001Mortality>(streamwriters[filename], streams))
						{ }
						break;
					case (Years._2001, Types.Person):
						foreach (CSVRow2001Person csvrow2001person in Utils.CSVs.Rows<CSVRow2001Person>(streamwriters[filename], streams))
						{ }
						break;

					default: break;
				}

				streamwriters.Dispose(true, filename);
			}

			#endregion

			#region 2011

			foreach (string directoryinputcensusall in DirectoryInputCensus2011All)
			{
				using FileStream filestream = File.OpenRead(directoryinputcensusall);
				using ZipArchive ziparchive = new(filestream);

				Stream[] streams = ziparchive.Entries
					.Select(_ => _.Open())
					.ToArray();

				string filename = string.Join('.', directoryinputcensusall.Split('\\').Last().Split('.')[0..^1]);

				Years years = default(Years).FromFilename(filename);
				Types types = default(Types).FromFilename(filename);

				string directorypath = Path.Combine(DirectoryOutput, string.Format("{0}.{1}", years.AsString(), types));

				Directory.CreateDirectory(directorypath);
				Console.WriteLine(directorypath);

				streamwriters.Add(filename, Path.Combine(directorypath, "log.txt"));

				switch (years, types)
				{
					case (Years._2011, Types.Agriculture):
						foreach (CSVRow2011Agriculture csvrow2011agriculture in Utils.CSVs.Rows<CSVRow2011Agriculture>(streamwriters[filename], streams))
						{ }
						break;
					case (Years._2011, Types.Household):
						foreach (CSVRow2011Household csvrow2011household in Utils.CSVs.Rows<CSVRow2011Household>(streamwriters[filename], streams))
						{ }
						break;
					case (Years._2011, Types.Mortality):
						foreach (CSVRow2011Mortality csvrow2011mortality in Utils.CSVs.Rows<CSVRow2011Mortality>(streamwriters[filename], streams))
						{ }
						break;
					case (Years._2011, Types.Person):
						foreach (CSVRow2011Person csvrow2011person in Utils.CSVs.Rows<CSVRow2011Person>(streamwriters[filename], streams))
						{ }
						break;

					default: break;
				}

				streamwriters.Dispose(true, filename);
			}

			#endregion

			#region 2022

			foreach (string directoryinputcensusall in DirectoryInputCensus2022All)
			{
				using FileStream filestream = File.OpenRead(directoryinputcensusall);
				using ZipArchive ziparchive = new(filestream);

				Stream[] streams = ziparchive.Entries
					.Select(_ => _.Open())
					.ToArray();

				string filename = string.Join('.', directoryinputcensusall.Split('\\').Last().Split('.')[0..^1]);

				Years years = default(Years).FromFilename(filename);
				Types types = default(Types).FromFilename(filename);

				string directorypath = Path.Combine(DirectoryOutput, string.Format("{0}.{1}", years.AsString(), types));

				Directory.CreateDirectory(directorypath);
				Console.WriteLine(directorypath);

				streamwriters.Add(filename, Path.Combine(directorypath, "log.txt"));

				switch (years, types)
				{
					case (Years._2022, Types.Household):
						foreach (CSVRow2022F19 csvrow2022f19 in Utils.CSVs.Rows<CSVRow2022F19>(streamwriters[filename], streams))
						{ }
						break;
					case (Years._2022, Types.Person):
						foreach (CSVRow2022F21 csvrow2022f21 in Utils.CSVs.Rows<CSVRow2022F21>(streamwriters[filename], streams))
						{ }
						break;

					default: break;
				}

				streamwriters.Dispose(true, filename);
			}

			#endregion

			sqliteconnection.CommitAndClose();

			string sqliteconnectionzipname = ZipFile(sqlconnectionpath).Split('\\').Last();
			string sqliteconnectiongzipname = GZipFile(sqlconnectionpath).Split('\\').Last();

			apifiles.Add(sqliteconnectionzipname);
			apifiles.Add(sqliteconnectiongzipname);

			File.Delete(sqlconnectionpath);

			_CleaningPost();
		}

		static void _CleaningPre()
		{
			Console.WriteLine("Pre Cleaning...");

			if (Directory.Exists(DirectoryOutput)) Directory.Delete(DirectoryOutput, true);

			Console.WriteLine("Creating Directories...");

			Directory.CreateDirectory(DirectoryOutput);
		}
		static void _CleaningPost()
		{
			Console.WriteLine("Cleaning Up...");
		}
		static string ZipFile(string filepath)
		{
			string name = filepath.Split("\\").Last();
			string zipfilepath = filepath + ".zip";

			using FileStream filestream = File.OpenRead(filepath);
			using FileStream filestreamzip = File.Create(zipfilepath);
			using ZipArchive ziparchive = new(filestreamzip, ZipArchiveMode.Create, true);
			using Stream stream = ziparchive
				.CreateEntry(name)
				.Open();

			filestream.CopyTo(stream);
			filestream.Close();

			return zipfilepath;
		}
		static string GZipFile(string filepath)
		{
			string gzipfilepath = filepath + ".gz";

			using FileStream filestream = File.OpenRead(filepath);
			using FileStream filestreamgzip = File.Create(gzipfilepath);

			GZip.Compress(filestream, filestreamgzip, true, 512, 6);

			return gzipfilepath;
		}
		static SQLiteConnection _SQLiteConnection(string path, bool individual)
		{
			SQLiteConnection sqliteconnection = new(path);

			if (individual) 
			{
				//sqliteconnection.CreateTable<Agriculture>();
				sqliteconnection.CreateTable<Codes>();
				//sqliteconnection.CreateTable<Household>();
				//sqliteconnection.CreateTable<Mortality>();
				//sqliteconnection.CreateTable<Person>();
			} 
			else 
			{
				//sqliteconnection.CreateTable<Agriculture.Individual>();
				//sqliteconnection.CreateTable<Codes.Individual>();
				//sqliteconnection.CreateTable<Household.Individual>();
				//sqliteconnection.CreateTable<Mortality.Individual>();
				//sqliteconnection.CreateTable<Person.Individual>();
			}

			return sqliteconnection;
		}
	}
}
