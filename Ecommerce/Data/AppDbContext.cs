using Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class AppDbContext :DbContext
    {

        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Movie_Actor> movies_Actors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adding some information for many to may relationships  (joining tables )
            modelBuilder.Entity<Movie_Actor>().HasKey(am =>
            new
            {
                am.ActorId,
                am.MovieId
            });
            //define one to many relatoinships
            modelBuilder.Entity<Movie_Actor>().HasOne(m =>
            m.Movie).WithMany(am => am.Movies_Actors).HasForeignKey(m => m.MovieId);

            modelBuilder.Entity<Movie_Actor>().HasOne(m =>
            m.Actor).WithMany(am => am.Movies_Actors).HasForeignKey(m => m.ActorId);


            base.OnModelCreating(modelBuilder);




        }


        //defining our tables names for each model
      

    }

}
