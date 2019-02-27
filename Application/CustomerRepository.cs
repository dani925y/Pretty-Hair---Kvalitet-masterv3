using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Application
{
    public class CustomerRepository
    {
        private new List<Customer> customers = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void RemoveCustomer(Customer customer)
        {
            customers.Remove(customer);
        }

        public void EditProduct(Customer customer)
        {

        }

        public void GetProduct(Customer customer)
        {

        }
    }
}
