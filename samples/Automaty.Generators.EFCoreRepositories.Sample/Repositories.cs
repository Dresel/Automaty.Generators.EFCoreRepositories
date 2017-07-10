namespace Automaty.Generators.EFCoreRepositories.Sample
{
	using Automaty.Generators.EFCoreRepositories.Sample.Entities;

	// Automaty IncludeFiles MusicStoreContext.cs; IUnitOfWork.cs
	// Automaty IncludeDirectory ./Entities
	public class RepositoriesHost : Host<MusicStoreContext>
	{
		public RepositoriesHost()
		{
			AggregateRepositories["Music"] = new[] { typeof(Album).FullName, typeof(Artist).FullName, typeof(Genre).FullName };
		}
	}
}