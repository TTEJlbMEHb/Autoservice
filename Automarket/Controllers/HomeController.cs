using Automarket.DAL.Interfaces;
using Automarket.Domain.Entity;
using Automarket.Domain.Helpers;
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
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomeController(ILogger<HomeController> logger, IAccountService accountService,
            IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _accountService = accountService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userEmailHelper = new GetUserEmailHelper(_httpContextAccessor);
                string userEmail = userEmailHelper.GetUserUserEmail();

                var response = await _accountService.GetIdByEmail(userEmail);
               
                if (response.StatusCode == Domain.Enum.StatusCode.OK)
                {
                    ViewBag.UserId = response;
                    return View(response.Data);
                }
                else if (response.StatusCode == Domain.Enum.StatusCode.InternalServerError)
                {
                    return RedirectToAction("InternalServerError", "Errors");
                }
                return RedirectToAction("Error", "Errors");
            }

            return View();
        }

        public async Task<IActionResult> About()
        {
            if (User.Identity.IsAuthenticated)
            {
                var userEmailHelper = new GetUserEmailHelper(_httpContextAccessor);
                string userEmail = userEmailHelper.GetUserUserEmail();

                var response = await _accountService.GetIdByEmail(userEmail);

                if (response.StatusCode == Domain.Enum.StatusCode.OK)
                {
                    ViewBag.UserId = response;
                    return View(response.Data);
                }
                else if (response.StatusCode == Domain.Enum.StatusCode.InternalServerError)
                {
                    return RedirectToAction("InternalServerError", "Errors");
                }
                return RedirectToAction("Error", "Errors");
            }

            return View();
        }      

        public IActionResult Privacy()
        {
            return View();
        }
    }
}