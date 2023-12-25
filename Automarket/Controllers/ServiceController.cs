using Automarket.Domain.Helpers;
using Automarket.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Automarket.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAccountService _accountService;

        public ServiceController(IHttpContextAccessor httpContextAccessor, IAccountService accountService)
        {
            _httpContextAccessor = httpContextAccessor;
            _accountService = accountService;
        }

        public async Task<IActionResult> Services()
        {
            var userEmailHelper = new GetUserEmailHelper(_httpContextAccessor);
            string userEmail = userEmailHelper.GetUserUserEmail();

            var response = await _accountService.GetIdByEmail(userEmail);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                ViewBag.UserId = response;
                return View();
            }
            else if (response.StatusCode == Domain.Enum.StatusCode.InternalServerError)
            {
                return RedirectToAction("InternalServerError", "Errors");
            }
            return RedirectToAction("Error", "Errors");
        }

        public async Task<IActionResult> EngineService()
        {
            var userEmailHelper = new GetUserEmailHelper(_httpContextAccessor);
            string userEmail = userEmailHelper.GetUserUserEmail();

            var response = await _accountService.GetIdByEmail(userEmail);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                ViewBag.UserId = response;
                return View();
            }
            else if (response.StatusCode == Domain.Enum.StatusCode.InternalServerError)
            {
                return RedirectToAction("InternalServerError", "Errors");
            }
            return RedirectToAction("Error", "Errors");
        }

        public async Task<IActionResult> ClutchService()
        {
            var userEmailHelper = new GetUserEmailHelper(_httpContextAccessor);
            string userEmail = userEmailHelper.GetUserUserEmail();

            var response = await _accountService.GetIdByEmail(userEmail);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                ViewBag.UserId = response;
                return View();
            }
            else if (response.StatusCode == Domain.Enum.StatusCode.InternalServerError)
            {
                return RedirectToAction("InternalServerError", "Errors");
            }
            return RedirectToAction("Error", "Errors");
        }

        public async Task<IActionResult> ComputerService()
        {
            var userEmailHelper = new GetUserEmailHelper(_httpContextAccessor);
            string userEmail = userEmailHelper.GetUserUserEmail();

            var response = await _accountService.GetIdByEmail(userEmail);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                ViewBag.UserId = response;
                return View();
            }
            else if (response.StatusCode == Domain.Enum.StatusCode.InternalServerError)
            {
                return RedirectToAction("InternalServerError", "Errors");
            }
            return RedirectToAction("Error", "Errors");
        }

        public async Task<IActionResult> ChassisService()
        {
            var userEmailHelper = new GetUserEmailHelper(_httpContextAccessor);
            string userEmail = userEmailHelper.GetUserUserEmail();

            var response = await _accountService.GetIdByEmail(userEmail);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                ViewBag.UserId = response;
                return View();
            }
            else if (response.StatusCode == Domain.Enum.StatusCode.InternalServerError)
            {
                return RedirectToAction("InternalServerError", "Errors");
            }
            return RedirectToAction("Error", "Errors");
        }

        public async Task<IActionResult> TurbineService()
        {
            var userEmailHelper = new GetUserEmailHelper(_httpContextAccessor);
            string userEmail = userEmailHelper.GetUserUserEmail();

            var response = await _accountService.GetIdByEmail(userEmail);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                ViewBag.UserId = response;
                return View();
            }
            else if (response.StatusCode == Domain.Enum.StatusCode.InternalServerError)
            {
                return RedirectToAction("InternalServerError", "Errors");
            }
            return RedirectToAction("Error", "Errors");
        }

        public async Task<IActionResult> AlignmentService()
        {
            var userEmailHelper = new GetUserEmailHelper(_httpContextAccessor);
            string userEmail = userEmailHelper.GetUserUserEmail();

            var response = await _accountService.GetIdByEmail(userEmail);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                ViewBag.UserId = response;
                return View();
            }
            else if (response.StatusCode == Domain.Enum.StatusCode.InternalServerError)
            {
                return RedirectToAction("InternalServerError", "Errors");
            }
            return RedirectToAction("Error", "Errors");
        }

        public async Task<IActionResult> ElectricityService()
        {
            var userEmailHelper = new GetUserEmailHelper(_httpContextAccessor);
            string userEmail = userEmailHelper.GetUserUserEmail();

            var response = await _accountService.GetIdByEmail(userEmail);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                ViewBag.UserId = response;
                return View();
            }
            else if (response.StatusCode == Domain.Enum.StatusCode.InternalServerError)
            {
                return RedirectToAction("InternalServerError", "Errors");
            }
            return RedirectToAction("Error", "Errors");
        }

        public async Task<IActionResult> RackService()
        {
            var userEmailHelper = new GetUserEmailHelper(_httpContextAccessor);
            string userEmail = userEmailHelper.GetUserUserEmail();

            var response = await _accountService.GetIdByEmail(userEmail);

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                ViewBag.UserId = response;
                return View();
            }
            else if (response.StatusCode == Domain.Enum.StatusCode.InternalServerError)
            {
                return RedirectToAction("InternalServerError", "Errors");
            }
            return RedirectToAction("Error", "Errors");
        }
    }
}
