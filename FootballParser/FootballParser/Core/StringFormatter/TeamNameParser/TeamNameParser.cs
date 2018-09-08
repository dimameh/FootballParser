using System;
using System.Collections.Generic;
using System.Linq;
using AngleSharp.Dom;
using AngleSharp.Dom.Html;

namespace FootballParser.Core.StringFormatter.TeamNameParser
{
	internal class TeamNameParser : IParser<string[]>
	{
		public string[] Parse(IHtmlDocument document)
		{
			var list = new List<string>();

			var items = document.QuerySelectorAll("a[href*='/p/7003/club/']");

			foreach (var item in items)
			{
				list.Add(item.GetAttribute("href").Substring(13));
			}

			return list.ToArray();
		}

	}
}
