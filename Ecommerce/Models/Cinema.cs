using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; } 
        public string CinemaName { get; set; }
    
        public string Logo { get; set; }

        public string Description { get; set; } 
        //relationships , one to many, a cinema can have a list of movies
        public List<Movie> Movies { get; set; }
    }
}
