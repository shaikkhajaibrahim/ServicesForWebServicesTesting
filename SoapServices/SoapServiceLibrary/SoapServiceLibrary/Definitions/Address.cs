using System.Runtime.Serialization;

namespace SoapServiceLibrary.Definitions
{
    [DataContract]
    public class Address
    {
        /// <summary>
        /// Street Line 1
        /// </summary>
        [DataMember]
        public string StreetLine1 { set; get; }

        /// <summary>
        /// Street Line2
        /// </summary>
        [DataMember]
        public string StreetLine2 { set; get; }

        /// <summary>
        /// City
        /// </summary>
        /// 
        [DataMember]
        public string City { set; get; }

        /// <summary>
        /// State
        /// </summary>
        [DataMember]
        public string State { set; get; }

        /// <summary>
        /// Country
        /// </summary>
        [DataMember]
        public string Country { set; get; }
    }
}