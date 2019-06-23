namespace Porto.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Porto.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Porto.DAL.PortoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Porto.DAL.PortoContext context)
        {
            context.Admins.AddOrUpdate(a => a.Id,
                new Admin() { Id = 1, Username = "admin", Password = "21232F297A57A5A743894A0E4A801FC3", Name = "Rauf", Surname = "Allahverdiyev" });

            context.Settings.AddOrUpdate(s => s.Id,
                new Setting() { Id = 1, Photo = "me.jpg", FullName = "Rauf Allahverdiyev", Job = "Developer", PrevJob = "Businessman", Education = "UC Davis", AboutText = "Lorem ipsum dolor sit lorem ipsum dolor sit dolor lorem", Birthday = Convert.ToDateTime("03-09-2002"), Marital = "Single", Nationality = "Azerbaijani", Skype = "MySkype", Phone = "+994 50 850 75 75", Email = "raufsa@code.edu.az" });

            context.AboutNav.AddOrUpdate(a => a.Id,
                new AboutNav() { Id = 1, Icon = "earphones-alt", Name = "Contact Information" },
               new AboutNav() { Id = 2, Icon = "envelope-open", Name = "Send  Email" },
               new AboutNav() { Id = 3, Icon = "cloud-download", Name = "Download Resume" });

            context.Blogs.AddOrUpdate(b => b.Id,
                new Blog() { Id = 1, Photo = "blog-1.jpg", Title = "Design Driven", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapib...", Date = "12 June 2016" },
                new Blog() { Id = 2, Photo = "blog-2.jpg", Title = "UI/UX Concepts", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapib...", Date = "14 June 2019" });

            context.Education.AddOrUpdate(e => e.Id,
                new Education() { Id = 1, Icon = "graduation", Uni = "UC Davis", Subject = "Computer Science", Year = "2019-2023" },
                new Education() { Id = 2, Icon = "graduation", Uni = "UCLA", Subject = "Computer Engineering", Year = "2016-2020" },
                new Education() { Id = 3, Icon = "graduation", Uni = "CALTECH", Subject = "Mechanic Engineering", Year = "2010-2014" },
                new Education() { Id = 4, Icon = "graduation", Uni = "UC Davis", Subject = "Computer Science", Year = "2019-2023" },
                new Education() { Id = 5, Icon = "graduation", Uni = "UCLA", Subject = "Computer Engineering", Year = "2016-2020" },
                new Education() { Id = 6, Icon = "graduation", Uni = "CALTECH", Subject = "Mechanic Engineering", Year = "2010-2014" });

            context.Experiences.AddOrUpdate(e => e.Id,
                new Experience() { Id = 1, From = "3 September", To = "Present", NYC = "Okler Themes", Title = "Chief Product Officer", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu." },
                 new Experience() { Id = 2, From = "3 September", To = "Present", NYC = "Okler Themes", Title = "Chief Product Officer", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu." },
                  new Experience() { Id = 3, From = "3 September", To = "Present", NYC = "Okler Themes", Title = "Chief Product Officer", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu." });

            context.Languages.AddOrUpdate(l => l.Id,
                new Language() { Id = 1, Flag = "blank.gif", Name = "English", Level = "Advanced" },
                new Language() { Id = 2, Flag = "blank.gif", Name = "Spanish", Level = "Advanced" },
                new Language() { Id = 3, Flag = "blank.gif", Name = "French", Level = "Advanced" });

            context.PorButtons.AddOrUpdate(b => b.Id,
                new PorButton() { Id = 1, Name = "SHOW ALL" },
                new PorButton() { Id = 2, Name = "WEBSITES" },
                new PorButton() { Id = 3, Name = "LOGOS" },
                new PorButton() { Id = 4, Name = "BRANDS" });

            context.PorPhotos.AddOrUpdate(p => p.Id,
                new PorPhoto() { Id = 1, Photo = "portfolio-1.jpg" },
                new PorPhoto() { Id = 2, Photo = "portfolio-2.jpg" },
                new PorPhoto() { Id = 3, Photo = "portfolio-3.jpg" },
                new PorPhoto() { Id = 4, Photo = "portfolio-4.jpg" },
                new PorPhoto() { Id = 5, Photo = "portfolio-5.jpg" },
                new PorPhoto() { Id = 6, Photo = "portfolio-6.jpg" },
                new PorPhoto() { Id = 7, Photo = "portfolio-7.jpg" },
                new PorPhoto() { Id = 8, Photo = "portfolio-8.jpg" });

            context.Recommendations.AddOrUpdate(r => r.Id,
                new Recommendation() { Id = 1, Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu. Praesent aliquam velit vel libero dictum, non sollicitudin lectus mollis. Morbi sollicitudin auctor gravida.", Name = "Gigi Hadid", Position = "Manager Partner" },
                new Recommendation() { Id = 2, Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu. Praesent aliquam velit vel libero dictum, non sollicitudin lectus mollis. Morbi sollicitudin auctor gravida.", Name = "Kendall Jenner", Position = "CEO" });

            context.Skills.AddOrUpdate(s => s.Id,
                new Skill() { Id = 1, Name = "START UP", Percentage = 50 },
                new Skill() { Id = 2, Name = "INNOVATION", Percentage = 63 },
                new Skill() { Id = 3, Name = "CSS", Percentage = 20 },
                new Skill() { Id = 4, Name = "JAVASCRIPT", Percentage = 70 },
                new Skill() { Id = 5, Name = "PRODUCTS", Percentage = 77 },
                new Skill() { Id = 6, Name = "BUSINESS", Percentage = 99 },
                new Skill() { Id = 7, Name = "C#", Percentage = 75 },
                new Skill() { Id = 8, Name = "CREATIVE", Percentage = 33 });
        }
    }
}
