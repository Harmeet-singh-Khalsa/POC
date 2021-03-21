using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.DTOs
{
    public class ProductsDTO
    {
        public int product_id { get; set; }
        public string product_name { get; set; }
        public string product_description { get; set; }
        public string product_image { get; set; }
        public int product_amount { get; set; }
        public bool category_id { get; set; }
    }
}
