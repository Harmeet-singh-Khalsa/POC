using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POC.DTOs
{
    public class DiscountDTO
    {
        public int discount_id { get; set; }
        public int discount_amount { get; set; }
        public bool isdeleted { get; set; }
        public DateTime start_time { get; set; }
        public string discount_name { get; set; }
        public DateTime end_time { get; set; }
        public bool isDeleted { get; set; }
    }
}
