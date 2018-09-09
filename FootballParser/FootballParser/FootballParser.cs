#region

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FootballParser.Core;
using FootballParser.Core.StringFormatter.TeamNameParser;
using FootballParser.Core.WildStat;

#endregion

namespace FootballParser
{
	public partial class FootballParser : Form
	{

		private readonly ParserWorker<string[]> wildParser;

		private TeamNameDictionary TeamNames;

		public FootballParser()
		{
			InitializeComponent();
			wildParser = new ParserWorker<string[]>(
				new WildParser()
			);

			TeamNames = new TeamNameDictionary();

			wildParser.OnCompleted += WildParserOnCompleted;
			wildParser.OnNewData += WildParserOnNewData;
		}

		private void WildParserOnNewData(object arg1, string[] arg2)
		{
			//InfoListBox.Items.AddRange(arg2);
			//foreach (var asd in arg2)
			//{
			//	testbox.Text += asd;
			//}
			foreach (var key in TeamNames.Teams.Keys)
			{
				testbox.Text += key + " - " + TeamNames.Teams[key];
			}
		}

		private void WildParserOnCompleted(object obj)
		{
			MessageBox.Show("Выполнено");
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			//wildParser.Settings = new WildSettings(team1.Text, team2.Text);
			///////////////////////////

			wildParser.Settings = new WildSettings("ESP_CD_Leganes", "ESP_Athletic_Bilbao");
			wildParser.Start();
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			wildParser.Abort();
		}
	}
}