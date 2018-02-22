using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserInfo
    {

        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string age { get; set; }
        public string nickname { get; set; }
        public string shortBio { get; set; }
        public string location { get; set; }
        public string numberProjects { get; set; }
        public string yearsExp { get; set; }
        public DateTime dateCreated { get; set; }
        public string totalWC { get; set; }

    }
}