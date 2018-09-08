using System.Collections.Generic;
using System.Linq;
using AngleSharp.Dom.Html;

namespace FootballParser.Core.StringFormatter.TeamNameParser
{
	internal class TeamNameParser : IParser<string[]>
	{
		public string[] Parse(IHtmlDocument document)
		{
			var list = new List<string>();

			var items = document.QuerySelectorAll("table").Where(item =>
				item.ClassName != null && item.ClassName.Contains("championship"));


			foreach (var item in items)
			{
				list.Add(item.TextContent);
			}

			return list.ToArray();
		}

	}
}
