using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace POC.DTOs
{
    public class UsersCreationDTO
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
        [Required]
        public string pwd { get; set; }

    }
}
