using BMR.Models.Service.Models.Request.BMR;
using BMR.Models.Service.Models.Response.BMR;
using BMR.Service.Contracts;
using BMR.Web.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BMR.Web.Controllers
{
    public class BMRController : Controller
    {
        private readonly IBMRService BMRService;
        private readonly IActivityService activityService;

        public BMRController(IBMRService BMRService,
                             IActivityService activityService)
        {
            this.BMRService = BMRService;
            this.activityService = activityService;
        }

        public async Task<IActionResult> Index()
        {
            this.ViewBag.Activities = new SelectList(await this.activityService.GetActivities(), "Id" ,"Name");
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Calculate(CalculateBMRRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Index");
            }

            var result = await this.BMRService.CalculateBMR(model, User.GetEmail());

            return this.RedirectToAction("GetBMR",result);
        }

        public IActionResult GetBMR(CalculateBMRResponseModel model)
        {
            return this.View(model);
        }
    }
}
