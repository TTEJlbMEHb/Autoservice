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

        public async Task<IActionResult> EngineService()
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

        public async Task<IActionResult> ClutchService()
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

        public async Task<IActionResult> ComputerService()
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

        public async Task<IActionResult> ChassisService()
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

        public async Task<IActionResult> TurbineService()
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

        public async Task<IActionResult> AlignmentService()
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

        public async Task<IActionResult> ElectricityService()
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

        public async Task<IActionResult> RackService()
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
    }
}
