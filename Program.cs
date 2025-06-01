using Database.SouthAfricanCensus.CSVs;

using ICSharpCode.SharpZipLib.GZip;

using Newtonsoft.Json.Linq;

using SQLite;

using System.IO.Compression;

namespace Database.SouthAfricanCensus
{
	internal class Program
	{
		static readonly string DirectoryCurrent =
			Directory.GetCurrentDirectory();
		//Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.FullName!;

		static readonly string DirectoryOutput = Path.Combine(DirectoryCurrent, ".output");
		static readonly string DirectoryTemp = Path.Combine(DirectoryCurrent, ".temp");
		static readonly string DirectoryInput = Path.Combine(DirectoryCurrent, ".input");
		static readonly string DirectoryInputCensus = Path.Combine(DirectoryInput, "census");
		static readonly string[] DirectoryInputCensusAll = new string[]
		{
			Path.Combine(DirectoryInputCensus, "Census1996Household.zip"),
			//Path.Combine(DirectoryInputCensus, "Census1996Person.zip"),

			//Path.Combine(DirectoryInputCensus, "Census2001Household.zip"),
			//Path.Combine(DirectoryInputCensus, "Census2001Mortality.zip"),
			//Path.Combine(DirectoryInputCensus, "Census2001Person.zip"),

			//Path.Combine(DirectoryInputCensus, "Census2011Agriculture.zip"),
			//Path.Combine(DirectoryInputCensus, "Census2011Household.zip"),
			//Path.Combine(DirectoryInputCensus, "Census2011Mortality.zip"),
			//Path.Combine(DirectoryInputCensus, "Census2011Person.zip"),

			//Path.Combine(DirectoryInputCensus, "Census2022sample_F18.zip"),
			//Path.Combine(DirectoryInputCensus, "Census2022sample_F19.zip"),
			//Path.Combine(DirectoryInputCensus, "Census2022sample_F21.zip"),
		};

		static void Main(string[] args)
		{
			_CleaningPre();
			
			string sqlconnectionpath = Path.Combine(DirectoryOutput, "afrobarometer.db");

			JArray apifiles = [];
			StreamWriters streamwriters = [];
			SQLiteConnection sqliteconnection = _SQLiteConnection(sqlconnectionpath, false);

			foreach (string directoryinputcensusall in DirectoryInputCensusAll)
			{
				string filename = string.Join('.', directoryinputcensusall.Split('\\').Last().Split('.')[0..^1]);
				string directory = Path.Combine(DirectoryOutput, filename);

				Directory.CreateDirectory(directory);

				streamwriters.Add(filename, Path.Combine(directory, "log.txt"));

				foreach (CSVRow1996Household csvrow1996household in Utils.CSVs.Rows<CSVRow1996Household>(streamwriters[filename]))
				{ }

				streamwriters.Dispose(true, filename);
			}
			
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

			if (Directory.Exists(DirectoryTemp)) Directory.Delete(DirectoryTemp, true);
			if (Directory.Exists(DirectoryOutput)) Directory.Delete(DirectoryOutput, true);

			Console.WriteLine("Creating Directories...");

			Directory.CreateDirectory(DirectoryTemp);
			Directory.CreateDirectory(DirectoryOutput);
		}
		static void _CleaningPost()
		{
			Console.WriteLine("Cleaning Up...");

			Directory.Delete(DirectoryTemp, true);
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

			if (individual) { } else { }

			return sqliteconnection;
		}
	}
}
