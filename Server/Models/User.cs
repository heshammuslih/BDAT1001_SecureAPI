using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class User
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string token { get; set; }
    }
}
