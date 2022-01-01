namespace BMR.Web.Controllers
{
    using BMR.Models.Service.Models.Request;
    using BMR.Service.Contracts;
    using BMR.Web.Models;
    using BMR.Web.Models.ViewModels;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authentication.Cookies;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Diagnostics;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class HomeController : Controller
    {
        private readonly IUserService userService;

        public HomeController(IUserService userService)
        {
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult About()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromForm] UserRequestModel requestModel)
        {
            var result = await this.userService.LoginAsync(requestModel);

            if (result.IsSuccess)
            {
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                identity.AddClaim(new Claim(ClaimTypes.Email, requestModel.Email));

                var principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return this.RedirectToAction("Index","BMR");
            }
            else
            {
                throw new Exception("Server error!");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromForm] UserRequestModel requestModel)
        {
            var result = await userService.RegisterAsync(requestModel);

            if (result.IsSuccess)
            {
                return this.RedirectToAction("Index");
            }
            else
            {
                throw new Exception("Server error!");
            }
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return this.RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(HttpErrorViewModel errorViewModel)
        {
            if (errorViewModel.StatusCode == 404)
            {
                return this.View(
                "Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
            }

            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }

        public IActionResult HttpError(HttpErrorViewModel errorViewModel)
        {
            if (errorViewModel.StatusCode == 404)
            {
                return this.View(errorViewModel);
            }

            return this.View(
                "Error", new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
