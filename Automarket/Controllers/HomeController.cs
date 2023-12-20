using Automarket.DAL.Interfaces;
using Automarket.Domain.Entity;
using Automarket.Models;
using Automarket.Service.Implementations;
using Automarket.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Automarket.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccountService _accountService;

        public HomeController(ILogger<HomeController> logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        public async Task<IActionResult> Index()
        {
            string userEmail = GetUserUserEmail();
            var response = await _accountService.GetIdByEmail(userEmail);
            ViewBag.UserId = response;
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            else if (response.StatusCode == Domain.Enum.StatusCode.ObjectNotFound)
            {
                return View();
            }
            return RedirectToAction("Error", "Home");
        }

        private string GetUserUserEmail()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                var UserEmail = User.Identity.Name;

                if (UserEmail != null)
                {
                    return UserEmail;
                }
            }

            return 0.ToString();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}