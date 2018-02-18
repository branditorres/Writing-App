using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserProfile
    {

        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nickName { get; set; }
        public DateTime DateCreated { get; set; }
        public string exp { get; set; }
        public int wordCount { get; set; }


    }
}