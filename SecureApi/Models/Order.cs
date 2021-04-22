using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecureApi.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime CreationData { get; set; }
        public string StoreName { get; set; }
        public string CustomerName { get; set; }
        public Double Total { get; set; }
    }
}
