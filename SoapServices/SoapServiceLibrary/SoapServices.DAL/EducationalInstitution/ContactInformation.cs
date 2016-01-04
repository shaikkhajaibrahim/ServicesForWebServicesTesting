using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapServices.DAL.EducationalInstitution
{
    [Table("ContactInfo")]
    public class ContactInformation
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        /// <summary>
        /// Primary Contact Number
        /// </summary>
        [Required]
        public string PrimaryContactNumber { set; get; }

        /// <summary>
        /// Secondary Contact Numbers
        /// </summary>
        public string SecondaryContactNumber { set; get; }

        /// <summary>
        /// Email Id
        /// </summary>
        [Required]
        public string EmailId { set; get; }

        /// <summary>
        /// Skype Id
        /// </summary>
        public string SkypeId { set; get; }

        /// <summary>
        /// Linked In Id
        /// </summary>
        public string LinkedInId { set; get; }

        /// <summary>
        /// Facebook Id
        /// </summary>
        public string FacebookId { set; get; }
    }
}
