#region

using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FootballParser.Core.StringFormatter.TeamNameParser;
using FootballParser.Core.WildStat;

#endregion

namespace FootballParser.Core
{
	internal class HtmlLoader
	{
		private readonly HttpClient client;
		private string url;

		public HtmlLoader(IParserSettings settings)
		{
			client = new HttpClient();

			if (settings is WildSettings tempSettings1)
			{
				WildUrlMaker(tempSettings1);
			}

			else if (settings is TeamNameSettings tempSettings)
			{
				TeamNameUrlMaker(tempSettings);
			}
			else
			{
				throw new TypeLoadException("Ошибка передачи Settings в HtmlLoader.");
			}
		}

		#region Two Teams Willd Source

		public async Task<string> GetSourceByTwoTeams(string team1, string team2)
		{
			var currentUrl = url.Replace("{CurrentTeam1}", team1).Replace("{CurrentTeam2}", team2);

			var response = await client.GetAsync(currentUrl);
			string source = null;

			if (response != null && response.StatusCode == HttpStatusCode.OK)
			{
				response.Content.Headers.ContentType.CharSet = "windows-1251";
				source = await response.Content.ReadAsStringAsync();
			}

			return source;
		}

		private void WildUrlMaker(WildSettings settings)
		{
			url =
				$"{settings.BaseUrl}/{settings.PrefixForTwoTeams}/club1/{settings.PrefixVersusTeam1}/club2/{settings.PrefixVersusTeam2}";

		}

		#endregion

		#region Team Name source

		private void TeamNameUrlMaker(TeamNameSettings settings)
		{
			url =
				$"{settings.BaseUrl}/{settings.PrefixTable}/{settings.PrefixYear}";
		}

		public async Task<string> GetSourceByUefaTable()
		{
			var response = await client.GetAsync(url);

			string source = null;

			if (response != null && response.StatusCode == HttpStatusCode.OK)
			{
				response.Content.Headers.ContentType.CharSet = "windows-1251";
				source = await response.Content.ReadAsStringAsync();
			}

			return source;
		}

		#endregion

	}
}