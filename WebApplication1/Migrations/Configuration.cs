namespace WebApplication1.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Data.WebApplication1Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplication1.Data.WebApplication1Context";
        }

        protected override void Seed(WebApplication1.Data.WebApplication1Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var campuses = new List<UniversityCampus>
            {
                new UniversityCampus { Name = "HebutNorth" },
                new UniversityCampus { Name = "HebutSourth" },
                new UniversityCampus { Name = "HebutWest" },
                new UniversityCampus { Name = "HebutEast" }
            };
           
            campuses.ForEach(c => context.UniversityCampus.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var students = new List<Student>
            {
                new Student{Name="Boy", Address="Address1", CampusID=campuses.Single( c => c.Name == "HebutNorth").ID},
                new Student{Name="Gril", Address="Address2", CampusID=campuses.Single( c => c.Name == "HebutSourth").ID},
                new Student{Name="Tom", Address="Address3", CampusID=campuses.Single( c => c.Name == "HebutWest").ID},
                new Student{Name="Jerry", Address="Address4", CampusID=campuses.Single( c => c.Name == "HebutEast").ID},
                new Student{Name="Mike", Address="Address5", CampusID=campuses.Single( c => c.Name == "HebutNorth").ID},
                new Student{Name="Mary", Address="Address6", CampusID=campuses.Single( c => c.Name == "HebutSourth").ID}
            };
            students.ForEach(s => context.Students.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

        }
    }
}
