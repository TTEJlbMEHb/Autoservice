using Automarket.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.Domain.Responce
{
    public class BaseResponse<T> : IBaseResponce<T>
    {
        public string Description { get; set; }

        public StatusCode StatusCode { get; set; }

        public T Data { get; set; }
    }

    public interface IBaseResponce<T>
    {
        T Data { get; set; }
        StatusCode StatusCode { get; set; }
        string Description { get; }
    }
}
