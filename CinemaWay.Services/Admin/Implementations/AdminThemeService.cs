using CinemaWay.Data;
using CinemaWay.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWay.Services.Admin.Implementations
{
    public class AdminThemeService : IAdminThemeService
    {
        private readonly CinemaWayDbContext db;

        public AdminThemeService(CinemaWayDbContext db)
        {
            this.db = db;
        }

        public async Task Create(string title, DateTime startDate, DateTime endDate)
        {
            var theme = new Theme
            {
                Title = title,
                StartDate = startDate,
                EndDate = endDate
            };

            this.db.Add(theme);

            await this.db.SaveChangesAsync();
        }
    }
}
