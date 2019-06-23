using Porto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Porto.DAL
{
    public class PortoContext : DbContext
    {
        public PortoContext() : base("PortoContextCN")
        {
        }

        public DbSet<AboutNav> AboutNav { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ClientMessage> ClientMessages { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PorButton> PorButtons { get; set; }
        public DbSet<PorPhoto> PorPhotos { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}