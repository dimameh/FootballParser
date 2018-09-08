namespace FootballParser.Core.StringFormatter
{
	public class Team
	{
		// Формат строки на каждую команду
		// Место в рейтинге УЕФА (2018)-Матчей5Побед1Ничьих2Поражений2Забитых мячей3Пропущенных мячей5Разница мячей-2Самая крупная победа1:0Самое крупное поражение0:2Самый результативный матч1:2Самая результативная ничья1:1Очков5
		//-------------------------------------------------------------------

		public Team(string statString)
		{
			//Рейтинг УЕФА
			UefaRate = statString.Substring(
				statString.LastIndexOf("Место в рейтинге УЕФА (2018)"),
				statString.IndexOf("Матчей") -
				statString.LastIndexOf("Место в рейтинге УЕФА (2018)"));

			//Матчей
			Matches = statString.Substring(statString.LastIndexOf("Матчей"),
				statString.IndexOf("Побед") - statString.LastIndexOf("Матчей"));

			//Побед
			Wins = statString.Substring(statString.LastIndexOf("Побед"),
				statString.IndexOf("Ничьих") - statString.LastIndexOf("Побед"));

			//Ничьих
			Draws = statString.Substring(statString.LastIndexOf("Ничьих"),
				statString.IndexOf("Поражений") - statString.LastIndexOf("Ничьих"));

			//Поражений
			Loses = statString.Substring(statString.LastIndexOf("Поражений"),
				statString.IndexOf("Забитых мячей") - statString.LastIndexOf("Поражений"));

			//Забитых мячей
			GoalsScored = statString.Substring(statString.LastIndexOf("Забитых мячей"),
				statString.IndexOf("Пропущенных мячей") - statString.LastIndexOf("Забитых мячей"));

			//Пропущенных мячей
			GoalsMissed = statString.Substring(statString.LastIndexOf("Пропущенных мячей"),
				statString.IndexOf("Разница мячей") - statString.LastIndexOf("Пропущенных мячей"));

			//Разница мячей
			GoalDifference = statString.Substring(statString.LastIndexOf("Разница мячей"),
				statString.IndexOf("Самая крупная победа") - statString.LastIndexOf("Разница мячей"));

			//Самая крупная победа
			BiggestVictory = statString.Substring(statString.LastIndexOf("Самая крупная победа"),
				statString.IndexOf("Самое крупное поражение") - statString.LastIndexOf("Самая крупная победа"));

			//Самое крупное поражение
			BiggestDefeat = statString.Substring(statString.LastIndexOf("Самое крупное поражение"),
				statString.IndexOf("Самый результативный матч") - statString.LastIndexOf("Самое крупное поражение"));

			//Самый результативный матч
			MostResultMatch = statString.Substring(statString.LastIndexOf("Самый результативный матч"),
				statString.IndexOf("Самая результативная ничья") - statString.LastIndexOf("Самый результативный матч"));

			//Самая результативная ничья
			MostResultDraw = statString.Substring(statString.LastIndexOf("Самая результативная ничья"),
				statString.IndexOf("Очков") - statString.LastIndexOf("Самая результативная ничья"));

			//Очков
			Score = statString.Substring(statString.LastIndexOf("Очков"), statString.Length - 1);
		}

		#region stats

		public string UefaRate { get; set; }

		public string Matches { get; set; }

		public string Wins { get; set; }

		public string Draws { get; set; }

		public string Loses { get; set; }

		public string GoalsScored { get; set; }

		public string GoalsMissed { get; set; }

		public string GoalDifference { get; set; }

		public string BiggestVictory { get; set; }

		public string BiggestDefeat { get; set; }

		public string MostResultMatch { get; set; }

		public string MostResultDraw { get; set; }

		public string Score { get; set; }

		#endregion
	}
}