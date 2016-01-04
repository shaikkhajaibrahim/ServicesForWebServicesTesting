using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapServices.DAL.EducationalInstitution
{
    /// <summary>
    /// Context Object for Educational Institution
    /// </summary>
    public class EducationalInstitutionDbContext:DbContext
    {
        public EducationalInstitutionDbContext():base("name=SoapServiceDbConnection")
        {
                
        }
        public DbSet<Student> Students { set; get; }

        public DbSet<Course> Courses { set; get; }

        public DbSet<Address> Addresses { set; get; }

        public DbSet<ContactInformation> ContactInformations { set; get; }

    }
}
