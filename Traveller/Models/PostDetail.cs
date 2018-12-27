using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Traveller.Models
{
    public class PostDetail
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        [DataType(DataType.Date)]
        public DateTime? CreatedAt { get; set; }

        public string ImagePath { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        

    }
}