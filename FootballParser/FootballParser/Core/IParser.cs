#region

using AngleSharp.Dom.Html;

#endregion

namespace FootballParser.Core
{
	internal interface IParser<T> where T : class
	{
		T Parse(IHtmlDocument document);
	}
}