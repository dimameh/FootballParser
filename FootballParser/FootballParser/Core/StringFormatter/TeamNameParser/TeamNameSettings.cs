using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballParser.Core.StringFormatter.TeamNameParser
{
	class TeamNameSettings : IParserSettings
	{
		public TeamNameSettings()
		{
		}

		public string BaseUrl { get; set; } = "http://wildstat.ru";

		public string PrefixTable { get; set; } = "p/7003/year";

		public string PrefixYear{ get; set; } = DateTime.Today.Year.ToString();

	}
}
