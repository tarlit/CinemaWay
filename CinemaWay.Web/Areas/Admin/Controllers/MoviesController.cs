namespace CinemaWay.Web.Areas.Admin.Controllers
{
    using CinemaWay.Services.Admin;
    using CinemaWay.Web.Areas.Admin.Models.Movies;
    using CinemaWay.Web.Infrastructure.Extensions;
    using CinemaWay.Web.Infrastructure.Filters;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class MoviesController : BaseAdminController
    {
        private readonly IAdminMovieService movies;

        public MoviesController(IAdminMovieService movies)
        {
            this.movies = movies;
        }

        public IActionResult Index() => View();

        public IActionResult Create() => View();

        [HttpPost]
        [ValidateModelState]
        public async Task<IActionResult> Create(AddMovieFormModel model)
        {
            await this.movies.Create(
                model.Name,
                model.Description,
                model.ImageUrl,
                model.Director, 
                model.Genre);

            TempData.AddSuccessMessage("Movie created successfully.");

            return RedirectToAction(nameof(Index));
        }
    }
}
