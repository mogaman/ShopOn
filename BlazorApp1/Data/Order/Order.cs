using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data.Order
{
    public class Order
    {
        public int userID { get; set; }
        public int orderID { get; set; }
        public DateTime orderDate { get; set; }
        public int productID { get; set; }
        public int cardNumber { get; set; }
    }
}
