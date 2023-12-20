using Automarket.DAL.Interfaces;
using Automarket.Domain.Entity;
using Automarket.Domain.Enum;
using Automarket.Domain.ViewModels.Car;
using Automarket.Service.Implementations;
using Automarket.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Automarket.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly IAccountService _accountService;

        public CarController(ICarService carService, IAccountService accountService)
        {
            _carService = carService;
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            string userEmail = GetUserUserEmail();
            ViewBag.UserId = await _accountService.GetIdByEmail(userEmail);

            var response = await _carService.GetCars();           
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

        //[HttpGet]
        //public async Task<IActionResult> GetCars(string request)
        //{
        //    var response = await _carService.GetCars();
        //    if (response.StatusCode == Domain.Enum.StatusCode.OK)
        //    {
        //        return View(response.Data.ToList());
        //    }
        //    return RedirectToAction("Error");
        //}

        [HttpGet]
        public async Task<IActionResult> GetCar(long id)
        {
            string userEmail = GetUserUserEmail();
            ViewBag.UserId = await _accountService.GetIdByEmail(userEmail);

            var response = await _carService.GetCar(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Error", "Home");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete (long id)
        {
            var response = await _carService.DeleteCar(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("GetCars");
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Save(long id)
        {
            if (id == 0)
            {
                return View();
            }
            var response = await _carService.GetCar(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Save(CarViewModel carViewModel)
        {
            if (!ModelState.IsValid)
            {
                if (carViewModel.Id == 0)
                {
                    await _carService.CreateCar(carViewModel);
                }
                else
                {
                    await _carService.Edit(carViewModel.Id, carViewModel);
                }
            }
            return RedirectToAction("GetCars");
        }

        [HttpPost]
        public JsonResult GetTypes()
        {
            var types = _carService.GetTypes();
            return Json(types.Data);
        }
    }
}
