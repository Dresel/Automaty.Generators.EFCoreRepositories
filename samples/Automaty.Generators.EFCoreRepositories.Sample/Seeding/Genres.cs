namespace Automaty.Generators.EFCoreRepositories.Sample.Seeding
{
	using System.Collections.Generic;
	using System.Linq;
	using Automaty.Generators.EFCoreRepositories.Sample.Entities;

	public static class Genres
	{
		public static IDictionary<string, Genre> Get()
		{
			Genre[] genresList =
			{
				new Genre
				{
					Name = "Pop"
				},
				new Genre
				{
					Name = "Rock"
				},
				new Genre
				{
					Name = "Jazz"
				},
				new Genre
				{
					Name = "Metal"
				},
				new Genre
				{
					Name = "Electronic"
				},
				new Genre
				{
					Name = "Blues"
				},
				new Genre
				{
					Name = "Latin"
				},
				new Genre
				{
					Name = "Rap"
				},
				new Genre
				{
					Name = "Classical"
				},
				new Genre
				{
					Name = "Alternative"
				},
				new Genre
				{
					Name = "Country"
				},
				new Genre
				{
					Name = "R&B"
				},
				new Genre
				{
					Name = "Indie"
				},
				new Genre
				{
					Name = "Punk"
				},
				new Genre
				{
					Name = "World"
				}
			};

			return genresList.ToDictionary(x => x.Name, x => x);
		}
	}
}