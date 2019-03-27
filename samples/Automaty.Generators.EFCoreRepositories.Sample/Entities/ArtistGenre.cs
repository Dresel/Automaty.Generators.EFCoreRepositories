namespace Automaty.Generators.EFCoreRepositories.Sample.Entities
{
	public class ArtistGenre
	{
		public virtual Artist Artist { get; set; }

		public int ArtistId { get; set; }

		public virtual Genre Genre { get; set; }
	}
}