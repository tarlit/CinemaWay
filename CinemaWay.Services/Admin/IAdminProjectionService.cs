using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWay.Services.Admin
{
    public interface IAdminProjectionService
    {
        Task Create(
            DateTime date,
            int startTime,
            int duration,
            string lecturerId,
            int movieId,
            int themeId);
    }
}
