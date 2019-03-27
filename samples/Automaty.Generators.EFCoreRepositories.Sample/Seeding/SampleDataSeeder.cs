namespace Automaty.Generators.EFCoreRepositories.Sample.Seeding
{
	using System.Collections.Generic;
	using System.Linq;
	using Automaty.Generators.EFCoreRepositories.Sample;
	using Automaty.Generators.EFCoreRepositories.Sample.Entities;

	public static class SampleDataSeeder
	{
		public static void EnsureSeedData(this MusicStoreContext context)
		{
			//if (context.AllMigrationsApplied())
			{
				if (!context.Genres.Any())
				{
					IDictionary<string, Genre> genres = Genres.Get();

					context.Genres.AddRange(genres.Values);
					context.SaveChanges();
				}

				if (!context.Artists.Any())
				{
					IDictionary<string, Artist> artists = Artists.Get();

					context.Artists.AddRange(artists.Values);
					context.SaveChanges();
				}

				if (!context.Albums.Any())
				{
					IEnumerable<Album> albums = Albums.Get(context.Genres.ToDictionary(x => x.Name, x => x),
						context.Artists.ToDictionary(x => x.Name, x => x));

					context.Albums.AddRange(albums);
					context.SaveChanges();
				}
			}
		}
	}
}