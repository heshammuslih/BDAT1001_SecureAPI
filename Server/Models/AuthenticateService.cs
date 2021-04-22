using Server.Services;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    public class AuthenticateService : IAuthenticateService
    {
        private List<User> users = new List<User>()
        {
        new User{userID =1, username = "nital", password="shah"},
        new User{userID =1, username = "hesham", password="pass"}
        };
        public User Authenticate(string userName, string password)
        {
            var user = users.SingleOrDefault(x => x.username == userName && x.password == password);
            //return null if student not found
            if (user == null)
            {
                return null;
            }
            else
            {
                var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, "some_id"),
                new Claim("granny", "cookie")
            };

                var secretBytes = Encoding.UTF8.GetBytes(Constants.Secret);
                var key = new SymmetricSecurityKey(secretBytes);
                var algorithm = SecurityAlgorithms.HmacSha256;

                var signingCredentials = new SigningCredentials(key, algorithm);

                var token = new JwtSecurityToken(
                    Constants.Issuer,
                    Constants.Audiance,
                    claims,
                    notBefore: DateTime.Now,
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials);

                user.token = new JwtSecurityTokenHandler().WriteToken(token);

                return user;
            }
        }
    }
}
