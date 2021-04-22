using System;
using System.Collections.Generic;
using System.Linq;
using SecureApi.Models;

namespace SecureApi.DataStorage
{
    public class OrderData
    {
        public List<Order> orders = new List<Order>()
        {
            new Order{OrderID = 1, CreationData = DateTime.Now.Date.AddDays(-61), StoreName="Costco", CustomerName="Prof. Nital", Total = 159.65},
            new Order{OrderID = 2, CreationData = DateTime.Now.Date.AddDays(-59), StoreName="Wallmart", CustomerName="Hesham", Total = 225},
            new Order{OrderID = 3, CreationData = DateTime.Now.Date.AddDays(-55), StoreName="Food Baisc", CustomerName="Jhon", Total = 129},
            new Order{OrderID = 4, CreationData = DateTime.Now.Date.AddDays(-51), StoreName="Value Mart", CustomerName="Smith", Total = 163},
            new Order{OrderID = 5, CreationData = DateTime.Now.Date.AddDays(-47), StoreName="Value Mart", CustomerName="Dana", Total = 55.9},
            new Order{OrderID = 6, CreationData = DateTime.Now.Date.AddDays(-44), StoreName="Costco", CustomerName="Catarena", Total = 741},
            new Order{OrderID = 7, CreationData = DateTime.Now.Date.AddDays(-38), StoreName="Freshcoo", CustomerName="Sophy", Total = 81.5},
            new Order{OrderID = 8, CreationData = DateTime.Now.Date.AddDays(-27), StoreName="Wallmart", CustomerName="Mariam", Total = 96},
            new Order{OrderID = 9, CreationData = DateTime.Now.Date.AddDays(-16), StoreName="Costco", CustomerName="Jan", Total = 74.81},
            new Order{OrderID = 10, CreationData = DateTime.Now.Date, StoreName="Lowblas", CustomerName="Natasha", Total = 154.4}
        };
    }

}
