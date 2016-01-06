using log4net;
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
        private ILog Log = LogManager.GetLogger(typeof(EducationalInstitutionDbContext));
        /// <summary>
        /// Construction of the db context using the app config
        /// </summary>
        public EducationalInstitutionDbContext():base("name=SoapServiceDbConnection")
        {
            Database.Log += WriteLog;  
        }

        /// <summary>
        /// Writes the Sql Statements to the log
        /// </summary>
        /// <param name="log"></param>
        private void WriteLog(string log)
        {
            Log.Debug(log);
        }

        /// <summary>
        /// Students
        /// </summary>
        public DbSet<Student> Students { set; get; }

        /// <summary>
        /// Courses
        /// </summary>
        public DbSet<Course> Courses { set; get; }

        /// <summary>
        /// Address
        /// </summary>
        public DbSet<Address> Addresses { set; get; }

        /// <summary>
        /// Contact Information
        /// </summary>
        public DbSet<ContactInformation> ContactInformations { set; get; }

    }
}
