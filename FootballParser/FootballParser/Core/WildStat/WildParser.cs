#region

using System.Collections.Generic;
using System.Linq;
using AngleSharp.Dom.Html;

#endregion

namespace FootballParser.Core.WildStat
{
	internal class WildParser : IParser<string[]>
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