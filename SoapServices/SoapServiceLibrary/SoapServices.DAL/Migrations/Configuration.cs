namespace SoapServices.DAL.Migrations
{
    using EducationalInstitution;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SoapServices.DAL.EducationalInstitution.EducationalInstitutionDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());
        }

        protected override void Seed(SoapServices.DAL.EducationalInstitution.EducationalInstitutionDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Addresses.AddOrUpdate(new Address()
            {
                City = "Hyderabad",
                Country = "India",
                State = "Telangana",
                StreetLine1 = "Near Abhiruchi tiffins",
                StreetLine2 = "SR Nagar"
            },
            new Address()
            {
                City = "Vijayawada",
                Country = "India",
                State = "Andhra Pradesh",
                StreetLine1 = "Near Sai Convention Center"
            }
            );

            context.ContactInformations.AddOrUpdate(
                new ContactInformation
                {
                    PrimaryContactNumber = "999999999",
                    EmailId = "soaptest1@mytrails.in"
                },
                new ContactInformation
                {
                    PrimaryContactNumber = "8888888888",
                    EmailId = "soaptest2@mytrails.in"
                }
                );
        }
    }
}
