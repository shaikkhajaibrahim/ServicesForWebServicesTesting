using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoapServices.DAL.EducationalInstitution
{
    [Table("Address")]
    public class Address
    {
        /// <summary>
        /// Id for the address
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        /// <summary>
        /// Street Line 1
        /// </summary>
        public string StreetLine1 { set; get; }

        /// <summary>
        /// Street Line2
        /// </summary>
        public string StreetLine2 { set; get; }

        /// <summary>
        /// City
        /// </summary>
        public string City { set; get; }

        /// <summary>
        /// State
        /// </summary>
        public string State { set; get; }

        /// <summary>
        /// Country
        /// </summary>
        public string Country { set; get; }

    }
}
