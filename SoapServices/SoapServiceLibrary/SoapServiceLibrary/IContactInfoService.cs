using SoapServiceLibrary.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SoapServiceLibrary
{
    /// <summary>
    /// This service contains the basic information on contact information
    /// </summary>
    [ServiceContract]
    public interface IContactInfoService
    {
        /// <summary>
        /// Adds the contact information
        /// </summary>
        /// <param name="contactInformation"></param>
        /// <returns></returns>
        [OperationContract]
        bool AddContactInfo(ContactInformation contactInformation);

        /// <summary>
        /// Returns all the contact informations
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        ContactInformation[] GetAllContactInformations();

        /// <summary>
        /// Deletes all the contacts of the email id
        /// </summary>
        /// <param name="emailId"></param>
        /// <returns></returns>
        [OperationContract]
        int DeleteContactsByEmailId(string emailId);

    }
}
