namespace Automaty.Generators.EFCoreRepositories
{
	using Humanizer;
	using SmartFormat.Core.Extensions;

	public class FirstCharacterToLowerAndPluralizeFormatter : IFormatter
	{
		public string[] Names { get; set; } = { "firstcharactertolowerandpluralize", "fctlap" };

		public bool TryEvaluateFormat(IFormattingInfo formattingInfo)
		{
			bool canHandleThisInput = formattingInfo.CurrentValue is string;

			if (!canHandleThisInput)
			{
				return false;
			}

			formattingInfo.Write(((string)formattingInfo.CurrentValue).FirstCharacterToLower().Pluralize());

			return true;
		}
	}
}