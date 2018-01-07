namespace CinemaWay.Services.Admin.Implementations
{
    using CinemaWay.Data;
    using CinemaWay.Data.Models;
    using System.Threading.Tasks;

    public class AdminActorService : IAdminActorService
    {
        private readonly CinemaWayDbContext db;

        public AdminActorService(CinemaWayDbContext db)
        {
            this.db = db;
        }

        public async Task Create(string firstName, string lastName, string imageUrl, string filmography)
        {
            var actor = new Actor
            {
                FirstName = firstName,
                LastName = lastName,
                ImageUrl = imageUrl,
                Filmography = filmography
            };

            this.db.Add(actor);

            await this.db.SaveChangesAsync();
        }
    }
}
