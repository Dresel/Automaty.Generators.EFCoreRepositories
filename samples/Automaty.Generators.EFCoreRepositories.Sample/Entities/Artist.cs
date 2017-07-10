namespace Automaty.Generators.EFCoreRepositories.Sample.Entities
{
	using System.ComponentModel.DataAnnotations;

	public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}