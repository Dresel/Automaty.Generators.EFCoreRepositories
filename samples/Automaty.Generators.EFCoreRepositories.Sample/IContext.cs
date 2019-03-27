namespace Automaty.Generators.EFCoreRepositories.Sample
{
	using Microsoft.EntityFrameworkCore;

	public interface IContext
	{
		DbSet<T> Set<T>() where T : class;
	}
}