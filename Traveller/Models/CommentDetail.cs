using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traveller.Models
{
    public class CommentDetail
    {
        public int Id { get; set; }
        public string comment1 { get; set; }

        public int? postId { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string ImagePath { get; set; }

        public int ? Mark { get; set; }

        public DateTime CreatAt { get; set; }


    }
}