namespace Automaty.Generators.EFCoreRepositories.Sample
{
	public class BaseRepository
	{
		public BaseRepository(IContext context)
		{
			Context = context;
		}

		protected IContext Context { get; }
	}
}