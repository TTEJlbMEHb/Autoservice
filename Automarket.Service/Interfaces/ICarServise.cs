using Automarket.Domain.Entity;
using Automarket.Domain.Responce;
using Automarket.Domain.ViewModels.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.Service.Interfaces
{
    public interface ICarServise
    {
        BaseResponse<Dictionary<int, string>> GetTypes();

        Task<IBaseResponce<List<Car>>> GetCars();

        //Task<IBaseResponce<List<Car>>> GetCars(string request);

        Task<IBaseResponce<CarViewModel>> GetCar(long id);

        Task<IBaseResponce<Car>> CreateCar(CarViewModel car);

        Task<IBaseResponce<bool>> DeleteCar(long id);

        Task<IBaseResponce<Car>> Edit(long id, CarViewModel model);
    }
}
