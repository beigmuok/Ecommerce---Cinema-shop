using Ecommerce.Models;

namespace Ecommerce.Data
{
    public class AppDbInitializer
    {

        public readonly AppDbContext _context;

        //public AppDbInitializer(AppDbContext context)
        //{
        //      _context = context;
        //}
        //WE need to add application scope to this
        /// <summary>
        /// /and use that to create reference ot db context
        /// </summary>
        /// <param name="applicationBuilder"></param>
        public static void Seeding(IApplicationBuilder applicationBuilder)
        {

            
            using (var serviceScop = applicationBuilder.ApplicationServices.CreateScope())
            {

                var context =serviceScop.ServiceProvider.GetService<AppDbContext>();
                //before we start adding item, lets check to ensure the database exists
                context.Database.EnsureCreated();
                
                //add our data if there is noe in any db
                //cinemakk
                if(!context.Cinemas.Any())
                {
                    //adding using a range

                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            CinemaName = "Cinema 1",
                            Description = "Lion The beast Black American",
                            Logo = "https://panel.freehosting.com:2222/CMD_FILE_MANAGER/EcommerceImages/Actors/Rock.jpg"
                            
                        }
                        ,
                        new Cinema()
                        {
                            CinemaName = "Cinema  2",
                            Description = "Cinema 2 2022",
                             Logo = "https://panel.freehosting.com:2222/CMD_FILE_MANAGER/EcommerceImages/Actors/dolph_lundgreen.jpg"
                        }
                    });

                    context.SaveChanges();

                }
                //actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "DYENE JASON",
                            Bio = "STRONG MOVIE ACTOR",
                            ProfilePictureUrl = "https://panel.freehosting.com:2222/CMD_FILE_MANAGER/EcommerceImages/Actors/Rock.jpg"
                        },
                        new Actor()
                        {
                            FullName = "IKO UWAIS",
                            Bio = "MARTIAL ARTIST ACTOR",
                            ProfilePictureUrl = "https://panel.freehosting.com:2222/CMD_FILE_MANAGER/EcommerceImages/Actors/iko_uiwais.jpg"
                        },
                        new Actor()
                        {
                            FullName = "TONNY JAA",
                            Bio = "MARTIAL ARTIST THAILAND ACTOR",
                            ProfilePictureUrl = "https://panel.freehosting.com:2222/CMD_FILE_MANAGER/EcommerceImages/Actors/tonny_jaa.jpg"
                        },
                        new Actor()
                        {
                            FullName = "DON YEN",
                            Bio = "MARTIAL ARTIST CHINESE ACTOR",
                            ProfilePictureUrl = "https://panel.freehosting.com:2222/CMD_FILE_MANAGER/EcommerceImages/Actors/donyen.jpg"
                       }


                    });
                    context.SaveChanges();
                }
                //producers
                if (!context.Producers.Any())
                {
                    context.AddRange(new List<Producer>()  
                        {
                        new Producer()
                        {
                            FullName = "Test Producer",
                            Bio = "Test Bio",
                            ProfilePictureUrl = "https://panel.freehosting.com:2222/CMD_FILE_MANAGER/EcommerceImages/Actors/sylvesterstalloneexpendables3workoutarms.jpg"
                        },
                         new Producer()
                        {
                            FullName = "Test Producer 2",
                            Bio = "Test Bio 2",
                            ProfilePictureUrl = "https://panel.freehosting.com:2222/CMD_FILE_MANAGER/EcommerceImages/Actors/donyen.jpg"
                        }

                        });

                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Fist Full Of vegence",
                            ImageUrl = "https://panel.freehosting.com:2222/CMD_FILE_MANAGER/EcommerceImages/Movies/fistful_of_vegeance.jpg",
                            StartDate = DateTime.Now.AddDays(-2),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 1,
                            ProducerId =1,
                            MovieCategory = Enums.MovieCategory.Action,
                            Price = 340.00,
                            Description = "Termed as part 2 of wu assasion series"
                        },
                         new Movie()
                        {
                            Name = "Ek the Tiger",
                            ImageUrl = "https://panel.freehosting.com:2222/CMD_FILE_MANAGER/EcommerceImages/Movies/ek_the_tiger.jpg",
                            StartDate = DateTime.Now.AddDays(10),
                            EndDate = DateTime.Now.AddDays(100),
                            CinemaId = 1,
                            ProducerId =1,
                            MovieCategory = Enums.MovieCategory.Drama,
                            Price = 900.00,
                            Description = "Two main and international investigation servies based on hiden truth (girl based)"
                        },
                          new Movie()
                        {
                            Name = "Kill Zone",
                            ImageUrl = "https://panel.freehosting.com:2222/CMD_FILE_MANAGER/EcommerceImages/Movies/kill_zone.jpg",
                            StartDate = DateTime.Now.AddDays(-20),
                            EndDate = DateTime.Now.AddDays(-10),
                            CinemaId = 2,
                            ProducerId =2,
                            MovieCategory = Enums.MovieCategory.Drama,
                            Price = 579.00,
                            Description = "Tonny Jaa's Daughter Rescued from illness death by Wu Jing , conflict of body organ"
                        }


                    }); ;
                    context.SaveChanges();
                }
                //Actors & movies
                if (!context.movies_Actors.Any())
                {
                    context.AddRange(new List<Movie_Actor>()
                    { 
                        new Movie_Actor()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },
                        new Movie_Actor()
                        {
                            ActorId = 3,
                            MovieId = 2
                        }
                    });



                    context.SaveChanges();
                }

                

            
            }
        }

    }
}
