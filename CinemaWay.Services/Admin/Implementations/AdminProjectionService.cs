namespace CinemaWay.Services.Admin.Implementations
{
    using AutoMapper.QueryableExtensions;
    using CinemaWay.Data;
    using CinemaWay.Data.Models;
    using CinemaWay.Services.Admin.Models.Projections;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using static Services.ServicesConstants;

    public class AdminProjectionService : IAdminProjectionService
    {
        private readonly CinemaWayDbContext db;

        public AdminProjectionService(CinemaWayDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<AdminListProjectionsModel>> All(int page = 1)
            => await this.db
                .Projections
                .OrderByDescending(m => m.Date)
                .Skip((page - 1) * MainPageSize)
                .Take(MainPageSize)
                .ProjectTo<AdminListProjectionsModel>()
                .ToListAsync();

        public async Task<int> Total()
            => await this.db.Projections.CountAsync();

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
