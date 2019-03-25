// <copyright file="BaseRepository.cs">
// Copyright (c) Christopher Dresel. All rights reserved.
// </copyright>

namespace Automaty.Generators.EFCoreRepositories.Sample
{
	public class BaseRepository
	{
		public BaseRepository(IContext context)
		{
			Context = context;
		}

		protected IContext Context { get; }
	}
}