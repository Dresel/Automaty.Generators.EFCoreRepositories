namespace Automaty.Generators.EFCoreRepositories.Sample
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;
	using Automaty.Generators.EFCoreRepositories.Sample.Entities;
	using Microsoft.EntityFrameworkCore;

	public class MusicStoreContext : DbContext, IUnitOfWork
	{
		public MusicStoreContext(DbContextOptions<MusicStoreContext> options) : base(options)
		{
		}

		public DbSet<Album> Albums { get; set; }

		public DbSet<Artist> Artists { get; set; }

		public DbSet<CartItem> CartItems { get; set; }

		public DbSet<Genre> Genres { get; set; }

		public DbSet<OrderDetail> OrderDetails { get; set; }

		public DbSet<Order> Orders { get; set; }

		public new void Add<T>(T entity) where T : class
		{
			Set<T>().Add(entity);
		}

		public void Delete<T>(T entity) where T : class
		{
			Set<T>().Remove(entity);
		}

		public void LoadCollection<TEntity, TProperty>(TEntity entity,
			Expression<Func<TEntity, IEnumerable<TProperty>>> propertyExpression) where TEntity : class where TProperty : class
		{
			if (entity == null)
			{
				return;
			}

			Entry(entity).Collection(propertyExpression).Load();
		}

		public void LoadReference<TEntity, TProperty>(TEntity entity, Expression<Func<TEntity, TProperty>> propertyExpression)
			where TEntity : class where TProperty : class
		{
			if (entity == null)
			{
				return;
			}

			Entry(entity).Reference(propertyExpression).Load();
		}

		public void Save()
		{
			SaveChanges();
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Artist>().HasIndex(x => new { x.Name }).IsUnique();
			modelBuilder.Entity<Genre>().HasIndex(x => new { x.Name }).IsUnique();

			modelBuilder.Entity<Album>().HasIndex(x => new { x.ArtistId, x.GenreId });
		}
	}
}