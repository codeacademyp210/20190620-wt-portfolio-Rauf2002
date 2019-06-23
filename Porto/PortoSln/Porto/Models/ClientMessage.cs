using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Porto.Models
{
    public class ClientMessage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SentTime { get; set; }
    }
}