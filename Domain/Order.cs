using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        private int orderLines = 0;
        private int customerId = 0;
        private int orderId = 0;
        private DateTime orderDate;
        private DateTime deliveryDate;
        private DateTime pickedDate; 

        public int OrderLines { get; set; }
        public int CustomerID { get; set; }
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime PickedDate { get; set; }

        public void AddOrderLine(int productId, int quantity, double price)
        {

        }

        public void RemoveOrderLines(int index)
        {

        }

        public void GetOrderLines(Orderlines orderlines)
        {

        }
    }
}
