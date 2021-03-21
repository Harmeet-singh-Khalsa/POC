using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace POC.Entities
{
    public class OrderItem
    {
        
        public int order_item_id { get; set; }
        public int quantity { get; set; }
        public int order_id { get; set; }   
        public int product_detail_id { get; set; }   
        
        
    }
}



