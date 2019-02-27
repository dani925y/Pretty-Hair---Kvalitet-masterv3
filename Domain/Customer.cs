using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Customer
    {
        private int customerId = 0;
        private string customerName = null;
        private string customerAddress = null;
        private string customerZip = null;
        private string customerTown = null;
        private string customerTelephone = null;
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerZip { get; set; }
        public string CustomerTown { get; set; }
        public string CustomerTelephone { get; set; }
    }
}
