namespace Automaty.Generators.EFCoreRepositories
{
	using Humanizer;
	using SmartFormat.Core.Extensions;

	public class PluralizeFormatter : IFormatter
	{
		public string[] Names { get; set; } = { "pluralize" };

		public bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			bool canHandleThisInput = formattingInfo.CurrentValue is string;

			if (!canHandleThisInput)
			{
				return false;
			}

			formattingInfo.Write(((string)formattingInfo.CurrentValue).Pluralize(false));

			return true;
		}
	}
}