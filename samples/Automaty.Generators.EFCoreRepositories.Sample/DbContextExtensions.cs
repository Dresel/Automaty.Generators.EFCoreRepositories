﻿namespace Automaty.Generators.EFCoreRepositories.Sample
{
	using System.Collections.Generic;
	using System.Linq;
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Infrastructure;
	using Microsoft.EntityFrameworkCore.Migrations;

	public static class DbContextExtensions
	{
		public static bool AllMigrationsApplied(this DbContext context)
		{
			IEnumerable<string> applied = context.GetService<IHistoryRepository>().GetAppliedMigrations()
				.Select(m => m.MigrationId);

			IEnumerable<string> total = context.GetService<IMigrationsAssembly>().Migrations.Select(m => m.Key);

			return !total.Except(applied).Any();
		}
	}
}