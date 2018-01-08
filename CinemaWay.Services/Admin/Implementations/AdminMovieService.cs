using CinemaWay.Data;
using System.Threading.Tasks;
using CinemaWay.Data.Models;

namespace CinemaWay.Services.Admin.Implementations
{
    public class AdminMovieService : IAdminMovieService
    {
        private readonly CinemaWayDbContext db;

        public AdminMovieService(CinemaWayDbContext db)
        {
            this.db = db;
        }

        public async Task Create(string name, string description, string imageUrl, string director, Genre genre)
        {
            var movie = new Movie
            {
                Name = name,
                Description = description,
                ImageUrl = imageUrl,
                Director = director,
                Genre = genre
            };

            this.db.Add(movie);

            await this.db.SaveChangesAsync();
        }
    }
}
