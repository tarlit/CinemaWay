namespace CinemaWay.Web.Areas.Admin.Controllers
{
    using Data.Models;
    using Models.Projections;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using static WebConstants;
    using CinemaWay.Services.Admin;
    using CinemaWay.Web.Infrastructure.Extensions;

    public class ProjectionsController : BaseAdminController
    {
        private readonly UserManager<User> userManager;
        private readonly IAdminProjectionService projections;

        public ProjectionsController(
            UserManager<User> userManager,
            IAdminProjectionService projections)
        {
            this.userManager = userManager;
            this.projections = projections;
        }

        public IActionResult Index() => View();

        public async Task<IActionResult> Create() 
            => View(new AddProjectionFormModel
            {
                Lecturers = await this.GetLecturers()
            });

        [HttpPost]
        public async Task<IActionResult> Create(AddProjectionFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Lecturers = await this.GetLecturers();
                return View(model);
            }

            await this.projections.Create(
                model.Date,
                model.StartTime,
                model.Duration,
                model.LecturerId,
                1,
                1);

            TempData.AddSuccessMessage("Projection created successfully.");

            return RedirectToAction(nameof(Index));
        }

        private async Task<IEnumerable<SelectListItem>> GetLecturers()
        {
            var lecturers = await this.userManager
                .GetUsersInRoleAsync(LecturerRole);

            var lecturerListItems = lecturers
                .Select(l => new SelectListItem
                {
                    Text = l.UserName,
                    Value = l.Id
                })
                .ToList();

            return lecturerListItems;
        }
    }
}
