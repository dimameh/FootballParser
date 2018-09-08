#region

using System;
using AngleSharp.Parser.Html;
using FootballParser.Core.StringFormatter.TeamNameParser;
using FootballParser.Core.WildStat;

#endregion

namespace FootballParser.Core
{
	internal class ParserWorker<T> where T : class
	{

		private HtmlLoader loader;

		private IParserSettings parserSettings;

		public ParserWorker(IParser<T> parser)
		{
			Parser = parser;
		}

		public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(
			parser)
		{
			this.parserSettings = parserSettings;
		}

		public IParser<T> Parser { get; set; }

		public IParserSettings Settings
		{
			get => parserSettings;
			set
			{
				parserSettings = value;
				loader = new HtmlLoader(value);
			}
		}

		public bool IsActive { get; private set; }

		public event Action<object, T> OnNewData;

		public event Action<object> OnCompleted;

		public void Start()
		{
			IsActive = true;
			Worker();
		}

		public void Abort()
		{
			IsActive = false;
		}

		private async void Worker()
		{
			if (!IsActive)
			{
				OnCompleted?.Invoke(this);
				return;
			}

			string source = null;
			
			if (parserSettings is WildSettings)
			{
				WildSettings settings = parserSettings as WildSettings;

				source = await loader.GetSourceByTwoTeams(settings.PrefixVersusTeam1,
					settings.PrefixVersusTeam2);
			}

			if (parserSettings is TeamNameSettings)
			{
				source = await loader.GetSourceByUefaTable();
			}

			if (source == null)
			{
				throw new NullReferenceException("source was null. ParserSettingsError");
			}

			var domParser = new HtmlParser();

			var document = await domParser.ParseAsync(source);

			var result = Parser.Parse(document);
			OnNewData?.Invoke(this, result);

			OnCompleted?.Invoke(this);
			IsActive = false;
		}
	}
}