using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDemo.Classes
{
    public class Order
    {
        public string article { get; set; }

        public DateTime deliveryDate {  get; set; }
        public DateTime orderDate { get; set; }
        public string address { get; set; }
        public string status { get; set; }

        //Ids
        public int statusId { get; set; }
        public int itemId { get; set; }
        public int userId { get; set; }
        public int orderId { get; set; }
        public int addressId { get; set; }
        public int quantity { get; set; }

        public List<OrderItem> items = new List<OrderItem>();
    }
    public class OrderItem
    {
        public string Article { get; set; }
        public int quantity { get; set; }
    }

}
