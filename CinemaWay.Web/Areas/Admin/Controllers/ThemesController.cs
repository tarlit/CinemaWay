namespace CinemaWay.Web.Areas.Admin.Controllers
{
    using CinemaWay.Services.Admin;
    using CinemaWay.Web.Areas.Admin.Models.Themes;
    using CinemaWay.Web.Infrastructure.Extensions;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class ThemesController : BaseAdminController
    {
        private readonly IAdminThemeService themes;

        public ThemesController(IAdminThemeService themes)
        {
            this.themes = themes;
        }

        public IActionResult Index() => View();

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(AddThemeFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.themes.Create(
                model.Title,
                model.StartDate,
                model.EndDate);

            TempData.AddSuccessMessage("Theme created successfully.");

            return RedirectToAction(nameof(Index));
        }
    }
}
