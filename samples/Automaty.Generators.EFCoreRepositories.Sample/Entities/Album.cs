namespace Automaty.Generators.EFCoreRepositories.Sample.Entities
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Album
	{
		public Album()
		{
			OrderDetails = new List<OrderDetail>();
			Created = DateTime.UtcNow;
		}

		[Display(Name = "Album Art URL")]
		[StringLength(1024)]
		public string AlbumArtUrl { get; set; }

		[ScaffoldColumn(false)]
		public int AlbumId { get; set; }

		public virtual Artist Artist { get; set; }

		public int ArtistId { get; set; }

		[Required]
		public DateTime Created { get; set; }

		public virtual Genre Genre { get; set; }

		public int GenreId { get; set; }

		public virtual List<OrderDetail> OrderDetails { get; set; }

		[Required]
		[Range(0.01, 100.00)]
		[DataType(DataType.Currency)]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }

		[Required]
		[StringLength(160, MinimumLength = 2)]
		public string Title { get; set; }
	}
}