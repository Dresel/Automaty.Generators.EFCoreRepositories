namespace Automaty.Generators.EFCoreRepositories.Sample
{
	using System.Collections.Generic;
	using Automaty.Generators.EFCoreRepositories.Sample.Entities;
	using Automaty.Generators.EFCoreRepositories.Sample.Repositories;
	using Automaty.Generators.EFCoreRepositories.Sample.Seeding;
	using Microsoft.EntityFrameworkCore;

	public class Program
	{
		public static void Main(string[] args)
		{
			DbContextOptions<MusicStoreContext> options = new DbContextOptionsBuilder<MusicStoreContext>()
				.UseSqlite("Data Source=musicstore.db").Options;

			using (MusicStoreContext context = new MusicStoreContext(options))
			{
				context.Database.EnsureCreated();
				context.EnsureSeedData();

				AlbumRepository albumRepository = new AlbumRepository(context);
				ArtistRepository artistRepository = new ArtistRepository(context);
				GenreRepository genreRepository = new GenreRepository(context);

				ICollection<Album> filterByArtistIdAndGenreId =
					albumRepository.GetByArtistIdAndGenreId(artistRepository.GetByName("Iron Maiden").ArtistId,
						genreRepository.GetByName("Metal").GenreId);
			}
		}
	}
}