using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Porto.Models
{
    public class Education
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Uni { get; set; }
        public string Subject { get; set; }
        public string Year { get; set; }
    }
}