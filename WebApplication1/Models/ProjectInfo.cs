using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProjectInfo
    {

        public int ID { get; set; }
        public int userId { get; set; }
        public string projectTitle { get; set; }
        public DateTime dateCreated { get; set; }
        public string genre { get; set; }
        public string type { get; set; }
        public string progress { get; set; }
        public string wordCount { get; set; }
        public string triggerWs { get; set; }
        public string charasInvolved { get; set; }

    }
}