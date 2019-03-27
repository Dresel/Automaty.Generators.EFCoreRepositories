namespace Automaty.Generators.EFCoreRepositories
{
	using System;
	using System.Collections.Generic;

	public static class DictionaryExtension
	{
		public static void Add<T1, T2>(this IDictionary<T1, T2> target, KeyValuePair<T1, T2> item)
		{
			if (target == null)
			{
				throw new ArgumentNullException(nameof(target));
			}

			target.Add(item);
		}
	}
}