using Microsoft.EntityFrameworkCore;

namespace VideoGameApi.Data
{
    public class VideoGameDbContext(DbContextOptions<VideoGameDbContext> options) : DbContext(options)
    {
        public DbSet<VideoGame> videoGames => Set<VideoGame>();   //videoGames is our table name

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGame>().HasData(


                  new VideoGame
                  {
                      Id = 1,
                      Title = "title 1",
                      Platform = "Platform 1",
                      Developer = "Developer 1",
                      Publisher = "Publisher 1"
                  },

             new VideoGame
             {
                 Id = 2,
                 Title = "title 2",
                 Platform = "Platform 2",
                 Developer = "Developer 2",
                 Publisher = "Publisher 2"
             },

              new VideoGame
              {
                  Id = 3,
                  Title = "title 3",
                  Platform = "Platform 3",
                  Developer = "Developer 3",
                  Publisher = "Publisher 3"
              }

             );

        }
    }
}
