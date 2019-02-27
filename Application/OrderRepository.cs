using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public class OrderRepository
    {
        private new List<Order> orders = new List<Order>();

        public void AddProduct(Order order)
        {
            orders.Add(order);
        }

        public void RemoveProduct(Order order)
        {
            orders.Remove(order);
        }

        public void EditProduct(Order order)
        {

        }

        public void GetProduct(Order order)
        {

        }
    }
}
