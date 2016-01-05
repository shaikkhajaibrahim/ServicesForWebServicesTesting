using System.Globalization;
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

        /// <summary>
        /// Overriden for log
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format(
                CultureInfo.InvariantCulture,
                "StreetLine1={0}, StreetLine2={1}, City={2}, State={3}, Country={4}",
                StreetLine1, StreetLine2, City, State, Country);
        }
    }
}