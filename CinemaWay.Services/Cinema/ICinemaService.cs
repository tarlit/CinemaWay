using CinemaWay.Services.Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWay.Services.Cinema
{
    public interface ICinemaService
    {
        Task<IEnumerable<ListProjectionWithMovieModel>> Active(int page = 1);

        Task<int> TotalActive();

        Task<ProjectionDetailsModel> ById(int id);
    }
}
