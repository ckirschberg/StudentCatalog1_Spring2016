namespace StudentCatalog3.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentCatalog3.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "StudentCatalog3.Models.ApplicationDbContext";
        }

        protected override void Seed(StudentCatalog3.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //context.People.AddOrUpdate(
            //  p => p.FullName,
            //  new Person { FullName = "Andrew Peters" },
            //  new Person { FullName = "Brice Lambson" },
            //  new Person { FullName = "Rowan Miller" }
            //);


            context.Students.AddOrUpdate(
                  p => p.Email, new Student[] {
                    new Student
                    { Firstname = "Andrew", Lastname="Something",
                        Email ="fkja@jdkfa.dk", MobilePhone="13212321" },

                      new Student { Firstname = "Claus", Lastname="Bové",
                          Email ="clbo@kea.dk", MobilePhone="313212321" },
                });


        }
    }
}
