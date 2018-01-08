using CinemaWay.Services.Admin.Models;
using CinemaWay.Services.Admin.Models.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWay.Services.Admin
{
    public interface IAdminThemeService
    {
        Task Create(
            string title,
            DateTime startDate,
            DateTime endDate);

        Task<IEnumerable<AdminListThemesModel>> All(int page = 1);

        Task<int> Total();

        Task<IEnumerable<ShortThemeModel>> AllTitles();
    }
}
