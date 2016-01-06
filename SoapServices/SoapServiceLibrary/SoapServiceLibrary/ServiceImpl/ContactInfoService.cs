using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoapServiceLibrary.Definitions;
using log4net;
using SoapServices.DAL.EducationalInstitution;

namespace SoapServiceLibrary.ServiceImpl
{
    /// <summary>
    /// Contact Info Service 
    /// </summary>
    public class ContactInfoService : IContactInfoService
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(ContactInfoService));

        /// <summary>
        /// This method will be used to add the contact information
        /// </summary>
        /// <param name="contactInformation"></param>
        /// <returns></returns>
        public bool AddContactInfo(Definitions.ContactInformation contactInformation)
        {
            Log.DebugFormat("Recived Request to AddContactInfo with ContactInformation:{0}", contactInformation);

            using (EducationalInstitutionDbContext context = new EducationalInstitutionDbContext())
            {
                context.ContactInformations.Add(new SoapServices.DAL.EducationalInstitution.ContactInformation
                {
                    EmailId = contactInformation.EmailId,
                    FacebookId = contactInformation.FacebookId,
                    LinkedInId = contactInformation.LinkedInId,
                    PrimaryContactNumber = contactInformation.PrimaryContactNumber,
                    SecondaryContactNumber = contactInformation.SecondaryContactNumber,
                    SkypeId = contactInformation.SkypeId
                });
                context.SaveChanges();
            }
            Log.Debug("Addition Succesful & sending response as true");
            return true;
            
        }
        /// <summary>
        /// Deletes Contact By email id
        /// </summary>
        /// <param name="emailId"></param>
        /// <returns>number of records deleted</returns>
        public int DeleteContactsByEmailId(string emailId)
        {
            Log.DebugFormat(" Received Request to DeleteContactsByEmailId with emailid: {0}", emailId);
            int count = 0;
            using (EducationalInstitutionDbContext context = new EducationalInstitutionDbContext())
            {
                var items=context.ContactInformations.Where(item => item.EmailId.Equals(emailId, StringComparison.OrdinalIgnoreCase));
                Parallel.ForEach(items, item =>
                {
                    Log.DebugFormat("Removing record with contactInformation {0}", item);
                });
                count = items.Count();
                context.ContactInformations.RemoveRange(items);
                context.SaveChanges();
            }
            Log.Debug("Processed Request DeleteContactsByEmailId");
            return count;
        }

        /// <summary>
        /// This method returns all the contact information
        /// </summary>
        /// <returns></returns>
        public Definitions.ContactInformation[] GetAllContactInformations()
        {
            Log.Debug("Received Request for the GetAllContactInformations");
            using (EducationalInstitutionDbContext context = new EducationalInstitutionDbContext())
            {
                Definitions.ContactInformation[] contacts=  context.ContactInformations.Select(item => new Definitions.ContactInformation
                {
                    EmailId = item.EmailId,
                    FacebookId = item.FacebookId,
                    LinkedInId = item.LinkedInId,
                    PrimaryContactNumber = item.FacebookId,
                    SecondaryContactNumber = item.SecondaryContactNumber,
                    SkypeId = item.SkypeId
                }).ToArray();
                //Logging the contacts
                Parallel.ForEach(contacts, item =>{Log.Debug(item);});
                return contacts;
            }
        }
    }
}
