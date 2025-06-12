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
			SQLiteConnection sqliteconnection = _SQLiteConnection(sqlconnectionpath);

			// Codes 1999
			sqliteconnection.InsertAll(
				objects: DirectoryInputMetadata1996CodesArea
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
			sqliteconnection.InsertAll(
				objects: DirectoryInputMetadata1996CodesDistrictCouncil
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodeTriplet>())
					.Select(_ => new CodesCouncilDistrict
					{
						Code = int.TryParse(_.ItemOne, out int code) ? code : new int?(),
						ProvinceCode = int.TryParse(_.ItemTwo, out int provincecode) ? provincecode : new int?(),
						Name = _.ItemThree,
					}));
			sqliteconnection.InsertAll(
				objects: DirectoryInputMetadata1996CodesDistrictMagisterial
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ => new CodesCouncilMagisterial
					{
						Code = int.TryParse(_.ItemOne, out int code) ? code : new int?(),
						Name = _.ItemTwo,
					}));
			sqliteconnection.InsertAll(
				objects: DirectoryInputMetadata1996CodesIndustry
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ => new CodesIndustry
					{
						Code1Digit = _.ItemOne,
						Code2Digit = _.ItemOne,
						Code3Digit = _.ItemOne,
						Value = _.ItemTwo,
					}));
			sqliteconnection.InsertAll(
				objects: DirectoryInputMetadata1996CodesOccupation
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ => new CodesOccupation
					{
						Code1Digit = _.ItemOne,
						Code2Digit = _.ItemOne,
						Code3Digit = _.ItemOne,
						Value = _.ItemTwo,
					}));

			// Codes 2001
			sqliteconnection.InsertAll(
				objects: DirectoryInputMetadata2001CodesCauseOfDeath
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
			sqliteconnection.InsertAll(
				objects: DirectoryInputMetadata2001CodesIndustry
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ => new CodesIndustry
					{
						Code1Digit = _.ItemOne,
						Code2Digit = _.ItemOne,
						Code3Digit = _.ItemOne,
						Value = _.ItemTwo,
					}));
			sqliteconnection.InsertAll(
				objects: DirectoryInputMetadata2001CodesOccupation
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ => new CodesOccupation
					{
						Code1Digit = _.ItemOne,
						Code2Digit = _.ItemOne,
						Code3Digit = _.ItemOne,
						Value = _.ItemTwo,
					}));
			sqliteconnection.InsertAll(
				objects: DirectoryInputMetadata2001CodesReligion
					.SelectMany(_ => new TXTCodes(_).GetCodes<TXTCodes.CodePair>())
					.Select(_ => new CodesReligion
					{
						Code = _.ItemOne,
						Value = _.ItemTwo,
					}));

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

				apifiles.Add(filename, years, types);

				string directorypath = Path.Combine(DirectoryOutput, string.Format("{0}.{1}", years.AsString(), types));

				Directory.CreateDirectory(directorypath);
				Console.WriteLine(directorypath);

				streamwriters.Add(filename, Path.Combine(directorypath, "log.txt"));

				switch (years, types)
				{
					case (Years._1996, Types.Household):
						sqliteconnection.InsertAll(
							objects: Utils.CSVs
								.Rows<CSVRow1996Household>(streamwriters[filename], streams)
								.Select(_ => _.AsRecord(streamwriters[filename])));
						break;
					case (Years._1996, Types.Person):
						return;
						sqliteconnection.InsertAll(
							objects: Utils.CSVs
								.Rows<CSVRow1996Person>(streamwriters[filename], streams)
								.Select(_ => _.AsRecord()));
						break;

					default: break;
				}

				streamwriters.Dispose(true, filename);
			}
			return;
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

				apifiles.Add(filename, years, types);

				string directorypath = Path.Combine(DirectoryOutput, string.Format("{0}.{1}", years.AsString(), types));

				Directory.CreateDirectory(directorypath);
				Console.WriteLine(directorypath);

				streamwriters.Add(filename, Path.Combine(directorypath, "log.txt"));

				switch (years, types)
				{
					case (Years._2001, Types.Household):
						sqliteconnection.InsertAll(
							objects: Utils.CSVs
								.Rows<CSVRow2001Household>(streamwriters[filename], streams)
								.Select(_ => _.AsRecord()));
						break;
					case (Years._2001, Types.Mortality):
						sqliteconnection.InsertAll(
							objects: Utils.CSVs
								.Rows<CSVRow2001Mortality>(streamwriters[filename], streams)
								.Select(_ => _.AsRecord()));
						break;
					case (Years._2001, Types.Person):
						sqliteconnection.InsertAll(
							objects: Utils.CSVs
								.Rows<CSVRow2001Person>(streamwriters[filename], streams)
								.Select(_ => _.AsRecord()));
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

				apifiles.Add(filename, years, types);

				string directorypath = Path.Combine(DirectoryOutput, string.Format("{0}.{1}", years.AsString(), types));

				Directory.CreateDirectory(directorypath);
				Console.WriteLine(directorypath);

				streamwriters.Add(filename, Path.Combine(directorypath, "log.txt"));

				switch (years, types)
				{
					case (Years._2011, Types.Agriculture):
						sqliteconnection.InsertAll(
							objects: Utils.CSVs
								.Rows<CSVRow2011HouseholdAgricultural>(streamwriters[filename], streams)
								.Select(_ => _.AsRecord()));
						break;
					case (Years._2011, Types.Household):
						sqliteconnection.InsertAll(
							objects: Utils.CSVs
								.Rows<CSVRow2011Household>(streamwriters[filename], streams)
								.Select(_ => _.AsRecord()));
						break;
					case (Years._2011, Types.Mortality):
						sqliteconnection.InsertAll(
							objects: Utils.CSVs
								.Rows<CSVRow2011Mortality>(streamwriters[filename], streams)
								.Select(_ => _.AsRecord()));
						break;
					case (Years._2011, Types.Person):
						sqliteconnection.InsertAll(
							objects: Utils.CSVs
								.Rows<CSVRow2011Person>(streamwriters[filename], streams)
								.Select(_ => _.AsRecord()));
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

				apifiles.Add(filename, years, types);

				string directorypath = Path.Combine(DirectoryOutput, string.Format("{0}.{1}", years.AsString(), types));

				Directory.CreateDirectory(directorypath);
				Console.WriteLine(directorypath);

				streamwriters.Add(filename, Path.Combine(directorypath, "log.txt"));

				switch (years, types)
				{
					case (Years._2022, Types.Household):
						sqliteconnection.InsertAll(
							objects: Utils.CSVs
								.Rows<CSVRow2022F19>(streamwriters[filename], streams)
								.Select(_ => _.AsRecord()));
						break;
					case (Years._2022, Types.Person):
						sqliteconnection.InsertAll(
							objects: Utils.CSVs
								.Rows<CSVRow2022F21>(streamwriters[filename], streams)
								.Select(_ => _.AsRecord()));
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

			string apifilesjson = apifiles.ToString();
			string apifilespath = Path.Combine(DirectoryOutput, "index.json");

			using FileStream apifilesfilestream = File.OpenWrite(apifilespath);
			using StreamWriter apifilesstreamwriter = new(apifilesfilestream);

			apifilesstreamwriter.Write(apifilesjson);
			apifilesstreamwriter.Close();
			apifilesfilestream.Close();

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
		static SQLiteConnection _SQLiteConnection(string path)
		{
			SQLiteConnection sqliteconnection = new(path);

			sqliteconnection.CreateTable<CodesArea>();
			sqliteconnection.CreateTable<CodesCouncilDistrict>();
			sqliteconnection.CreateTable<CodesCouncilMagisterial>();
			sqliteconnection.CreateTable<CodesIndustry>();
			sqliteconnection.CreateTable<CodesOccupation>();
			sqliteconnection.CreateTable<CodesCauseOfDeath>();
			sqliteconnection.CreateTable<CodesReligion>();

			sqliteconnection.CreateTable<RecordsHousehold>();
			sqliteconnection.CreateTable<RecordsHouseholdAgricultural>();
			sqliteconnection.CreateTable<RecordsMortality>();
			sqliteconnection.CreateTable<RecordsPerson>();

			return sqliteconnection;
		}
	}

	public static class Extensions
	{
		public static void Add(this JArray jarray, string filename, Years year, Types type)
		{
			string description = filename.Split('.').Last() switch
			{
				"zip" => "zipped ",
				"gz" => "g-zipped ",

				_ => string.Empty
			};

			jarray.Add(new JObject
			{
				{ "DateCreated", DateTime.Now.ToString("dd-MM-yyyy") },
				{ "DateEdited", DateTime.Now.ToString("dd-MM-yyyy") },
				{ "Name", filename.Split('/').Last() },
				{ "Url", string.Format("https://raw.githubusercontent.com/xyclone-designs/database.southafricancensus/refs/heads/main/.output/{0}", filename) },
				{ "Description", string.Format("individual {0}database of {1} records taken in {2}", description, type, year) }
			});
		}
	}
}
