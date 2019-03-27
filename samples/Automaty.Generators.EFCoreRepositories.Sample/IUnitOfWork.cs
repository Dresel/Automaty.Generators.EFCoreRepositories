namespace Automaty.Generators.EFCoreRepositories.Sample
{
	using System.Threading;
	using System.Threading.Tasks;

	public interface IUnitOfWork
	{
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
	}
}