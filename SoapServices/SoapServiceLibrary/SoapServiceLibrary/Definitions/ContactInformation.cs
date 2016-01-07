using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace SoapServiceLibrary.Definitions
{
    [DataContract]
    public class ContactInformation
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ContactInformation()
        {
            CreatedDateTime = DateTime.Now;
             
        }
        /// <summary>
        /// Primary Contact Number
        /// </summary>
        [DataMember]
        public string PrimaryContactNumber { set; get; }

        /// <summary>
        /// Secondary Contact Numbers
        /// </summary>
        [DataMember]
        public string SecondaryContactNumber { set; get; }

        /// <summary>
        /// Email Id
        /// </summary>
        [DataMember]
        public string EmailId { set; get; }

        /// <summary>
        /// Skype Id
        /// </summary>
        [DataMember]
        public string SkypeId { set; get; }

        /// <summary>
        /// Linked In Id
        /// </summary>
        [DataMember]
        public string LinkedInId { set; get; }

        /// <summary>
        /// Facebook Id
        /// </summary>
        [DataMember]
        public string FacebookId { set; get; }


        /// <summary>
        /// Date Time when the Contact Information was created
        /// </summary>
        [DataMember]
        public DateTime CreatedDateTime { set; get; }

        /// <summary>
        /// Overriden for better logs
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(
                CultureInfo.InvariantCulture,
                "{0} PrimaryContactNumber: {1}, SecondaryContactNumber: {2}, EmailId: {3}, SkypeId: {4}, LinkedInId: {5}, FacebookId: {6}",
                System.Environment.NewLine,PrimaryContactNumber, SecondaryContactNumber, EmailId, SkypeId, LinkedInId, FacebookId);
        }
    }
}
