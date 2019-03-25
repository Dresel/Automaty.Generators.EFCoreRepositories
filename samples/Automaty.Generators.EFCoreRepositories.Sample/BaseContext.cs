// <copyright file="BaseContext.cs">
// Copyright (c) Christopher Dresel. All rights reserved.
// </copyright>

namespace Automaty.Generators.EFCoreRepositories.Sample
{
	using Microsoft.EntityFrameworkCore;

	public class BaseContext : DbContext, IContext, IUnitOfWork
	{
		public BaseContext(DbContextOptions options)
			: base(options)
		{
		}
	}
}