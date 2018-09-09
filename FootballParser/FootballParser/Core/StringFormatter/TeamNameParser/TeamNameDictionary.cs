using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballParser.Core.StringFormatter.TeamNameParser
{
	class TeamNameDictionary
	{
		public Dictionary<string, string> Teams { get; private set; }

		public readonly ParserWorker<Dictionary<string, string>> teamNamesParser;

		public TeamNameDictionary()
		{
			teamNamesParser = new ParserWorker<Dictionary<string, string>>(new TeamNameParser());
			
			teamNamesParser.OnNewData += TeamDictionaryParserOnNewData;

			teamNamesParser.Settings = new TeamNameSettings();
			teamNamesParser.Start();
		}

		private void TeamDictionaryParserOnNewData(object arg1, Dictionary<string, string> arg2)
		{
			Teams = new Dictionary<string, string>(arg2);
			Teams = Teams.OrderBy(k => k.Key).ToDictionary(process => process.Key, process => process.Value);
		}
	}
}
