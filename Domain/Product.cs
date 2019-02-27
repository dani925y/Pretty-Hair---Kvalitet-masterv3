using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        private int productId = 0;
        private string productName = null;
        private string productDescription = null;
        private double productPrice = 0;
        private int productMinInStock = 0;
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public int ProductMinInStock { get; set; }
    }
}
