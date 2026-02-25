using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewDemo.Classes
{
    public class Product
    {
        // Values
        public string article { get; set; }
        public string productName { get; set; }
        public string unit { get; set; }
        public int price { get; set; }
        public string supplier { get; set; }
        public string producer { get; set; }
        public string category { get; set; }
        public int discount { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }
        public string picture { get; set; }
        
        // Ids
        public int categoryId { get; set; }
        public int producerId { get; set; }
        public int supplierId { get; set; }
        public int productNameId { get; set; }
    }
}
