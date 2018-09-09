using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;

namespace FootballParser.Core.StringFormatter.TeamNameParser
{
	internal class TeamNameParser : IParser<Dictionary<string, string>>
	{

		public Dictionary<string, string> Parse(IHtmlDocument document)
		{
			var hrefList = new List<string>();
			var nameList = new List<string>();
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			var hrefs = document.QuerySelectorAll("a[href*='/p/7003/club/']");

			foreach (var item in hrefs)
			{
				nameList.Add(item.TextContent);
				hrefList.Add(item.GetAttribute("href").Substring(13));
			}



			for (int i = 0; i < nameList.Count; i++)
			{
				Debug.WriteLine(i + ")\t" + nameList[i] + " - " + hrefList[i]);

				if (!dictionary.ContainsKey(nameList[i]))
				{
					dictionary.Add(nameList[i], hrefList[i]);
				}
			}

			return dictionary;
		}
	}
}
