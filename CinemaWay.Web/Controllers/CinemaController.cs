using CinemaWay.Services.Cinema;
using CinemaWay.Web.Models.Cinema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaWay.Web.Controllers
{
    public class CinemaController : Controller
    {
        private readonly ICinemaService cinema;

        public CinemaController(ICinemaService cinema)
        {
            this.cinema = cinema;
        }

        public async Task<IActionResult> Index(int page = 1)
            => View(new ListProjectionWithMovieViewModel
            {
                ActiveProjections = await this.cinema.Active(page),
                TotalProjections = await this.cinema.TotalActive(),
                CurrentPage = page
            });

        //public async Task<IActionResult> Details(int id)
        //    => this.ViewOrNotFound(await this.stories.ById(id));
    }
}
