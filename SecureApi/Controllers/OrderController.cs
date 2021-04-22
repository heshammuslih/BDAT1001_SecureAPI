using SecureApi.DataStorage;
using SecureApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace SecureApi.Controllers
{
    public class OrderController : Controller
    {
        [Authorize]
        public List<Order> GetAll()
        {
            OrderData orderData = new OrderData();
            return orderData.orders;
        }

        [Authorize]
        public Order Get(int order_id)
        {
            OrderData orderData = new OrderData();
            var order = orderData.orders.SingleOrDefault(x => x.OrderID == order_id);
            return order;
        }
    }
}
