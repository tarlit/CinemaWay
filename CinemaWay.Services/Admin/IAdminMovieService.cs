using CinemaWay.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWay.Services.Admin
{
    public interface IAdminMovieService
    {
        Task Create(
            string name,
            string description,
            string imageUrl,
            string director,
            Genre genre);
    }
}
