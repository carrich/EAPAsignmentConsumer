using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Traveller.Models
{
    public class Travel
    {
        public string firstname { get; set; }
        public string lastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public int RoleId { get; set; }
    }
}