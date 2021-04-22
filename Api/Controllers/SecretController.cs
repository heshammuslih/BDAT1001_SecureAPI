using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SecureApi.Controllers
{
    public class SecretController : Controller
    {
        [Authorize]
        public string Index()
        {
            return "secret message";
        }

        [Authorize]
        public string GetAllOrders()
        {
            return "Get All Orders order by creation date";
        }
    }
}
