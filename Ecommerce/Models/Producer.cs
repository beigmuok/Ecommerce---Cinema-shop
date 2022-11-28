using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string Bio { get; set; }

        //relationships
        //one to many relationships, Producer can handle multiple movies
        public List<Movie> Movies { get; set; } 
    }
}
