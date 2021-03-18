using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace POC.Entities
{
    public class User
    {
        public string fname { get; set; }
        public string lname { get; set; }      

        public int user_id { get; set; }

        public int phone { get; set; }

        public string password { get; set; }
    }
}
