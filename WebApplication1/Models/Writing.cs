using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Writing
    {

        public int ID { get; set; }
        public string UserID { get; set; }
        public string text { get; set; }
        public string tags { get; set; }
        public string projectName { get; set; }

    }
}