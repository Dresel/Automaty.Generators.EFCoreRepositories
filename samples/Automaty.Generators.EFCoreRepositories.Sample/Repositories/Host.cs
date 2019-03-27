namespace Automaty.Generators.EFCoreRepositories.Sample.Repositories
{
	using Automaty.Generators.EFCoreRepositories.Sample.Entities;

	// Automaty IncludeFiles ../MusicStoreContext.cs;../IContext.cs;../IUnitOfWork.cs
	// Automaty IncludeDirectory ../Entities
	public class Host : BaseHost<MusicStoreContext>
	{
		public Host()
		{
			GenerateAsyncFunctions = true;

			AggregateRepositories["Music"] = new[] { typeof(Album).FullName, typeof(Artist).FullName, typeof(Genre).FullName };
		}
	}
}