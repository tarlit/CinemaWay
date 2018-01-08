namespace CinemaWay.Services.Cinema.Implementations
{
    using AutoMapper.QueryableExtensions;
    using CinemaWay.Data;
    using CinemaWay.Services.Cinema.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using static ServicesConstants;

    public class CinemaService : ICinemaService
    {
        private readonly CinemaWayDbContext db;

        public CinemaService(CinemaWayDbContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<ListProjectionWithMovieModel>> Active(int page = 1)
            => await this.db
                .Projections
                .OrderBy(p => p.Date)
                .Where(p => p.Date >= DateTime.UtcNow)
                .Skip((page - 1) * StoriesPageSize)
                .Take(StoriesPageSize)
                .ProjectTo<ListProjectionWithMovieModel>()
                .ToListAsync();

        public Task<ProjectionDetailsModel> ById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> TotalActive()
            => await this.db.Projections
            .Where(p => p.Date >= DateTime.UtcNow)
            .CountAsync();
    }
}
