using Ecommerce.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
        public string ImageUrl { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; } 
        
        public MovieCategory MovieCategory { get; set; }
        //relationships
        //have list of actors
        public List<Movie_Actor> Movies_Actors { get; set; }
        //cinema one to many relationships
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }
        //producer one to many relationships
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }


}
