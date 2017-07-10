namespace Automaty.Generators.EFCoreRepositories.Sample
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Linq.Expressions;

	public class BaseRepository
	{
		protected IUnitOfWork UnitOfWork { get; set; }

		public void Add<TEntity>(TEntity entity) where TEntity : class
		{
			UnitOfWork.Add(entity);
		}

		public void Delete<TEntity>(TEntity entity) where TEntity : class
		{
			UnitOfWork.Delete(entity);
		}

		public void Delete<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
		{
			foreach (TEntity entity in entities)
			{
				UnitOfWork.Delete(entity);
			}
		}

		public ICollection<TEntity> GetAll<TEntity>() where TEntity : class
		{
			return UnitOfWork.Set<TEntity>().ToList();
		}

		public void LoadCollection<TEntity, TProperty>(TEntity entity,
			Expression<Func<TEntity, IEnumerable<TProperty>>> propertyExpression) where TEntity : class where TProperty : class
		{
			UnitOfWork.LoadCollection(entity, propertyExpression);
		}

		public void LoadReference<TEntity, TProperty>(TEntity entity, Expression<Func<TEntity, TProperty>> propertyExpression)
			where TEntity : class where TProperty : class
		{
			UnitOfWork.LoadReference(entity, propertyExpression);
		}

		public void Save()
		{
			UnitOfWork.Save();
		}
	}
}