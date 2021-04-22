using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Services
{
    public interface IAuthenticateService
    {
        User Authenticate(String UserName, String Password);
    }
}
