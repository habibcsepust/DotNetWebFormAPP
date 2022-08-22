using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotNetWebFormAPP.Models
{
    public class Doctor
    {
        public int d_id { get; set; }
        public string d_name { get; set; }
        public string d_contact { get; set; }
        public string d_email { get; set; }
        public DateTime d_dateofbirth { get; set; }
    }
}