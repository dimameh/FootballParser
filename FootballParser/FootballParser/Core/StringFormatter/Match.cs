using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballParser.Core.StringFormatter
{
	class Match
	{
		// Формат статистики матчей двух команд
		// Чемпионат Испании 2018/19, Примера, Второй круг  24.04.2019Леганес – Атлетик ЛеганесEstadio Municipal de ButarqueЧемпионат Испании 2018/19, Примера, Первый круг  20.08.2018Атлетик – Леганес2:1 (1:1) БильбаоEstadio de San MamésЧемпионат Испании 2017/18, Примера, Второй круг  11.03.2018Атлетик – Леганес2:0 (2:0) БильбаоEstadio de San MamésЧемпионат Испании 2017/18, Примера, Первый круг  22.10.2017Леганес – Атлетик1:0 (0:0) ЛеганесEstadio Municipal de ButarqueЧемпионат Испании 2016/17, Примера, Второй круг  14.05.2017Атлетик – Леганес1:1 (1:0) БильбаоEstadio de San MamésЧемпионат Испании 2016/17, Примера, Первый круг  14.01.2017Леганес – Атлетик0:0 ЛеганесEstadio Municipal de Butarque
		// Требуемый: Чемпионат испании 24.04.2019 Леганес - Атлетик 2:1 (1:1)
		// Чемпионат испании
		// 24.04.2019
		// Team1
		// 2:1
		// Team2
		// Чемпионат России по футболу 2018/19 | Рубин | 4:1 (3:1) | Динамо

		public string FootballEvent { get; set; }

		public DateTime MatchDate { get; set; }

		public Team Team1 { get; set; }

		public Team Team2 { get; set; }
	}
}
