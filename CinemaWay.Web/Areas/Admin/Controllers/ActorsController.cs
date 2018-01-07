namespace CinemaWay.Web.Areas.Admin.Controllers
{
    using CinemaWay.Services.Admin;
    using CinemaWay.Web.Areas.Admin.Models.Actors;
    using CinemaWay.Web.Infrastructure.Extensions;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class ActorsController : BaseAdminController
    {
        private readonly IAdminActorService actors;

        public ActorsController(IAdminActorService actors)
        {
            this.actors = actors;
        }

        public IActionResult Index() => View();

        public IActionResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(AddActorFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.actors.Create(
                model.FirstName,
                model.LastName,
                model.ImageUrl,
                model.Filmography);

            TempData.AddSuccessMessage("Actor created successfully.");

            return RedirectToAction(nameof(Index));
        }
    }
}
