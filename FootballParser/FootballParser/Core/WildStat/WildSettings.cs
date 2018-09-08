namespace FootballParser.Core.WildStat
{
	internal class WildSettings : IParserSettings
	{
		public WildSettings(string team1, string team2)
		{
			PrefixVersusTeam1 = team1;
			PrefixVersusTeam2 = team2;
		}

		public string BaseUrl { get; set; } = "http://wildstat.ru";

		public string PrefixTeam { get; set; } = "p/1/club";

		public string PrefixForTwoTeams { get; set; } = "p/1/ch/all";

		public string PrefixVersusTeam1 { get; set; } = "{CurrentTeam1}";

		public string PrefixVersusTeam2 { get; set; } = "{CurrentTeam1}";
	}
}