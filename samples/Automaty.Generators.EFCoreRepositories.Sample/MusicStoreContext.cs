namespace Automaty.Generators.EFCoreRepositories.Sample
{
	using Automaty.Generators.EFCoreRepositories.Sample.Entities;
	using Microsoft.EntityFrameworkCore;

	public class MusicStoreContext : DbContext, IContext, IUnitOfWork
	{
		public MusicStoreContext(DbContextOptions<MusicStoreContext> options) : base(options)
		{
		}

		public DbSet<Album> Albums { get; set; }

		public DbSet<ArtistGenre> ArtistGenres { get; set; }

		public DbSet<Artist> Artists { get; set; }

		public DbSet<CartItem> CartItems { get; set; }

		public DbSet<Genre> Genres { get; set; }

		public DbSet<OrderDetail> OrderDetails { get; set; }

		public DbSet<Order> Orders { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Artist>().HasIndex(x => new
			{
				x.Name,
			}).IsUnique();

			modelBuilder.Entity<Genre>().HasIndex(x => new
			{
				x.Name,
			}).IsUnique();

			modelBuilder.Entity<Album>().HasIndex(x => new
			{
				x.ArtistId,
				x.GenreId,
			});

			modelBuilder.Entity<ArtistGenre>().Property<int>($"{nameof(ArtistGenre.Genre)}Id");
			modelBuilder.Entity<ArtistGenre>().HasKey(nameof(ArtistGenre.ArtistId), $"{nameof(ArtistGenre.Genre)}Id");
		}
	}
}