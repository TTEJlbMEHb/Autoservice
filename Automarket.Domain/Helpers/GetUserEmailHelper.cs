using Automarket.Domain.Entity;
using Microsoft.AspNetCore.Http;
using System;

namespace Automarket.Domain.Helpers
{
    public class GetUserEmailHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public GetUserEmailHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public string GetUserUserEmail()
        {
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                var user = _httpContextAccessor.HttpContext.User;
                var UserEmail = user.Identity.Name;

                if (UserEmail != null)
                {
                    return UserEmail;
                }
            }

            return "0";
        }
    }
}
