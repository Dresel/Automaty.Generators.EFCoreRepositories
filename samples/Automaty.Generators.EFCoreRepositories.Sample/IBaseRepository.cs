namespace Automaty.Generators.EFCoreRepositories.Sample
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;

	public interface IBaseRepository<TEntity> where TEntity : class
	{
		void Add(TEntity entity);

		void Delete(IEnumerable<TEntity> entities);

		void Delete(TEntity entity);

		ICollection<TEntity> GetAll();

		void LoadCollection<TProperty>(TEntity entity, Expression<Func<TEntity, IEnumerable<TProperty>>> propertyExpression)
			where TProperty : class;

		void LoadReference<TProperty>(TEntity entity, Expression<Func<TEntity, TProperty>> propertyExpression)
			where TProperty : class;

		void Save();
	}
}