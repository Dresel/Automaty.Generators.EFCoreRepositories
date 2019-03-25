namespace Automaty.Generators.EFCoreRepositories.Sample.Repositories
{
	using Automaty.Generators.EFCoreRepositories.Sample.Entities;

	// Automaty IncludeFiles ../MusicStoreContext.cs;../IContext.cs;../IUnitOfWork.cs
	// Automaty IncludeDirectory ../Entities
	public class RepositoriesHost : BaseHost<MusicStoreContext>
	{
		public RepositoriesHost()
		{
			AggregateRepositories["Music"] = new[] { typeof(Album).FullName, typeof(Artist).FullName, typeof(Genre).FullName };
		}
	}
}