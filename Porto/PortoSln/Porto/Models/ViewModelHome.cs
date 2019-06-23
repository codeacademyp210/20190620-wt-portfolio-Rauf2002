using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Porto.Models
{
    public class ViewModelHome
    {
        public List<AboutNav> AboutNav { get; set; }
        public List<Admin> Admin { get; set; }
        public List<Blog> Blog { get; set; }
        public List<ClientMessage> ClientMessage { get; set; }
        public List<Education> Education{ get; set; }
        public List<Experience> Experience { get; set; }
        public List<Language> Language{ get; set; }
        public List<PorButton> PorButton { get; set; }
        public List<PorPhoto> PorPhoto { get; set; }
        public List<Recommendation> Recommendation { get; set; }
        public Setting Setting { get; set; }

        public List<Skill> Skill { get; set; }

    }
}