using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Actor
    {
        //https://panel.freehosting.com:2222/CMD_FILE_MANAGER/EcommerceImages/Actors/Rock.jpg
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string Bio { get; set; }  
        
        //relationships

        public List<Movie_Actor> Movies_Actors { get; set; }
    }
}
