namespace Automaty.Generators.EFCoreRepositories.Sample
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;
	using Microsoft.EntityFrameworkCore;

	public interface IUnitOfWork
	{
		void Add<T>(T entity) where T : class;

		void Delete<T>(T entity) where T : class;

		void LoadReference<TEntity, TProperty>(TEntity entity, Expression<Func<TEntity, TProperty>> propertyExpression)
			where TEntity : class where TProperty : class;

		void LoadCollection<TEntity, TProperty>(TEntity entity,
			Expression<Func<TEntity, IEnumerable<TProperty>>> propertyExpression) where TEntity : class where TProperty : class;

		void Save();

		DbSet<T> Set<T>() where T : class;
	}
}