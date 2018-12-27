using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Traveller.Models
{
    public class PostComment
    {
        public int Id { get; set; }
        public string comment1 { get; set; }

        public int? postId { get; set; }

        public int? UserId { get; set; }

        public int? Vote { get; set; }

       

        public DateTime CreatAt { get; set; }
    }
}