using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using movie.Data.Base;
using movie.Data.Enums;

namespace movie.Models
{
    public class Movie : IEntityBase
    {
		[Key]
		public int Id { get; set; }

		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string ImageURL { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public MovieCategory MovieCategory { get; set; }

		//Relationships M:N
		public List<Actor_Movie> Actors_Movies { get; set; }

		//Cinema 1:N
		public int CinemaId { get; set; }
		[ForeignKey("CinemaId")]
		public Cinema Cinema { get; set; }

		//Producer 1:N
		public int ProducerId { get; set; }
		[ForeignKey("ProducerId")]
		public Producer Producer { get; set; }
	}
}
