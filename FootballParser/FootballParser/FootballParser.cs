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
		private readonly ParserWorker<string[]> _wildParser;

		private TeamNameDictionary _teamNames;

		public FootballParser()
		{
			InitializeComponent();
			_wildParser = new ParserWorker<string[]>(
				new WildParser()
			);

			InitTeamNames();

			_wildParser.OnCompleted += WildParserOnCompleted;
			_wildParser.OnNewData += WildParserOnNewData;
		}

		private void InitTeamNames()
		{
			_teamNames = new TeamNameDictionary();
			_teamNames.teamNamesParser.OnCompleted += delegate
				{
					foreach (var value in _teamNames.Teams)
					{
						team1.Items.Add(value.Key);
						team2.Items.Add(value.Key);
					}
				};
		}

		private void WildParserOnNewData(object arg1, string[] arg2)
		{
			InfoListBox.Items.AddRange(arg2);
			foreach (var value in arg2)
			{
				testbox.Text += value;
			}
		}

		private void WildParserOnCompleted(object obj)
		{
			MessageBox.Show("Выполнено");
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{																																																																														
			_wildParser.Settings = new WildSettings(_teamNames.Teams[team1.SelectedItem.ToString()], _teamNames.Teams[team2.SelectedItem.ToString()]);
			_wildParser.Start();
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			_wildParser.Abort();
		}
	}
}