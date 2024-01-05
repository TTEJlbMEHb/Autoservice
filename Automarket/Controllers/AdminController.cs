using Automarket.Domain.Entity;
using Automarket.Domain.Helpers;
using Automarket.Domain.ViewModels.Account;
using Automarket.Service.Implementations;
using Automarket.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Automarket.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AdminController(IAccountService accountService, IHttpContextAccessor httpContextAccessor)
        {
            _accountService = accountService;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IActionResult> Adminpanel()
        {
            var userEmailHelper = new GetUserEmailHelper(_httpContextAccessor);
            string userEmail = userEmailHelper.GetUserUserEmail();
            ViewBag.UserId = await _accountService.GetIdByEmail(userEmail);

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Forbidden", "Errors");
            }

            var response = await _accountService.GetUsers();

            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            else if (response.StatusCode == Domain.Enum.StatusCode.InternalServerError)
            {
                return RedirectToAction("InternalServerError", "Errors");
            }

            return RedirectToAction("Error", "Errors");
        }

        [HttpGet]
        public async Task<IActionResult> CreateAccount()
        {
            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Forbidden", "Errors");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccount(AccountViewModel user)
        {
            if (User.IsInRole("Admin"))
            {
                if (ModelState.IsValid)
                {
                    var response = await _accountService.CreateAccount(user);

                    if (response.StatusCode == Domain.Enum.StatusCode.OK)
                    {
                        TempData["AlertMessage"] = response.Description;
                        TempData["ResponseStatus"] = response.StatusCode.ToString();
                        ModelState.AddModelError("", response.Description);
                        return RedirectToActionPermanent("Profile", "Account", new { id = response.Data.Id });
                    }

                    TempData["AlertMessage"] = response.Description;
                    TempData["ResponseStatus"] = "Error";
                }
                return View(user);
            }
            else
            {
                return RedirectToAction("Forbidden", "Errors");
            }
        }

        public async Task<IActionResult> DeleteAccount(long id)
        {
            if (User.IsInRole("Admin"))
            {
                var response = await _accountService.DeleteAccount(id);                              

                if (response.StatusCode == Domain.Enum.StatusCode.OK)
                {
                    TempData["AlertMessage"] = response.Description;
                    TempData["ResponseStatus"] = response.StatusCode.ToString();
                    return RedirectToAction("Adminpanel", "Admin");
                }
                else
                {
                    var referer = Request.Headers["Referer"].ToString();
                    TempData["AlertMessage"] = response.Description;
                    TempData["ResponseStatus"] = "Error";
                    return Redirect(referer);
                }
            }

            return RedirectToAction("Forbidden", "Errors");
        }

    }
}
