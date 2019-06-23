using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Porto.Models
{
    public class Setting
    {
        public int Id{ get; set; }
        public string Photo { get; set; }
        public string FullName{ get; set; }
        public string Job { get; set; }
        public string PrevJob{ get; set; }
        public string Education { get; set; }
        public string AboutText { get; set; }
        public DateTime Birthday{ get; set; }
        public string Marital { get; set; }
        public string Nationality { get; set; }
        public string Skype { get; set; }
        public string Phone { get; set; }
        public string Email{ get; set; }
    }
}