namespace Automaty.Generators.EFCoreRepositories
{
	using System;
	using System.Linq;

	public static class TypeExtensions
	{
		public static string Name(this Type type)
		{
			if (!type.IsGenericType)
			{
				return type.Name;
			}

			return
				$"{type.Name.Substring(0, type.Name.IndexOf('`'))}<{string.Join(", ", type.GenericTypeArguments.Select(x => Name(x)))}>";
		}
	}
}