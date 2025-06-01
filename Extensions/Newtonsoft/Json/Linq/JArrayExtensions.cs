using Database.SouthAfricanCensus.Enums;

using System;
using System.Linq;

namespace Newtonsoft.Json.Linq
{
	public static class JArrayExtensions
	{
		public static void Add(this JArray jarray, string filename, Years? year)
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
				{ "Description", true switch
					{
						true when year.HasValue => string.Format("individual {0}database for round {1}", description, year.Value.AsString()),

						_ => string.Format("{0}database", description)
					}
				}
			});
		}
	}
}
