using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;
using UglyToad.PdfPig.DocumentLayoutAnalysis;

namespace Database.SouthAfricanCensus.Inputs.TXTs
{
	public class _TXT : IDisposable
	{
		public _TXT(string filepath)
		{
			Filepath = filepath;
			Filename = Filepath.Split('\\')[^1];
		}

		private List<string>? _TextLines;
		public List<string> TextLines
		{
			get
			{
				if (_TextLines is null)
				{
					_TextLines = [];

					using FileStream filestream = File.OpenRead(Filepath);
					using StreamReader streamreader = new (filestream);

					while (streamreader.ReadLine() is string line) 
						_TextLines.Add(line);
				}

				return _TextLines;
			}
		}
		public string Filename { get; set; }
		public string Filepath { get; set; }

		public void Dispose() { }
	}
}
