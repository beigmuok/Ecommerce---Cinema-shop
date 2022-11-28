using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string Bio { get; set; }  
        
        //relationships

        public List<Movie_Actor> Movies_Actors { get; set; }
    }
}
