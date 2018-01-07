namespace CinemaWay.Services.Admin.Implementations
{
    using CinemaWay.Data;
    using CinemaWay.Data.Models;
    using System;
    using System.Threading.Tasks;

    public class AdminProjectionService : IAdminProjectionService
    {
        private readonly CinemaWayDbContext db;

        public AdminProjectionService(CinemaWayDbContext db)
        {
            this.db = db;
        }

        public async Task Create(DateTime date, int startTime, int duration, string lecturerId, int movieId, int themeId)
        {
            var projection = new Projection
            {
                Date = date,
                StartTime = startTime,
                Duration = duration,
                LecturerId = lecturerId,
                MovieId = movieId,
                ThemeId = themeId
            };

            this.db.Add(projection);

            await this.db.SaveChangesAsync();
        }
    }
}
