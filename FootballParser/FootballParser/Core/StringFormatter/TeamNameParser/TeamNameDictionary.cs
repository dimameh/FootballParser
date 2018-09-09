using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballParser.Core.StringFormatter.TeamNameParser
{
	class TeamNameDictionary
	{
		public Dictionary<string, string> Teams { get; set; }

		private readonly ParserWorker<Dictionary<string, string>> teamNamesParser;

		public TeamNameDictionary()
		{
			teamNamesParser = new ParserWorker<Dictionary<string, string>>(new TeamNameParser());
			
			teamNamesParser.OnNewData += WildParserOnNewData;

			teamNamesParser.Settings = new TeamNameSettings();
			teamNamesParser.Start();
		}

		private void WildParserOnNewData(object arg1, Dictionary<string, string> arg2)
		{
			Teams = arg2;
		}
	}
}
