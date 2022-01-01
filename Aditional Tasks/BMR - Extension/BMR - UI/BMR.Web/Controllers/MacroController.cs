namespace BMR.Web.Controllers
{
    using BMR.Service.Contracts;
    using BMR.Web.Extensions;

    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class MacroController : Controller
    {
        private readonly IMacroService macroService;

        public MacroController(IMacroService macroService)
        {
            this.macroService = macroService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await this.macroService.GetMacros(User.GetEmail()));
        }
    }
}
