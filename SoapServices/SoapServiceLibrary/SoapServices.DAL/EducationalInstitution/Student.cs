using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapServices.DAL.EducationalInstitution
{
    /// <summary>
    /// Student Table
    /// </summary>
    [Table("Student")]
    public class Student
    {
        /// <summary>
        /// Student Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }

        /// <summary>
        /// Name
        /// </summary>
        [Required]
        public string Name { set; get; }

        /// <summary>
        /// Fathers Name
        /// </summary>
        [Required]
        public string FathersName { set; get; }

        /// <summary>
        /// Contact Id
        /// </summary>
        public int ContactId { set; get; }

        /// <summary>
        /// Contact Information
        /// </summary>
        [ForeignKey("ContactId")]
        public ContactInformation ContactInfo { set; get; }

        /// <summary>
        /// Permanent Address Id
        /// </summary>
        [Required]
        public int AddressId { set; get; }

        /// <summary>
        /// Permanent Address
        /// </summary>
        [ForeignKey("AddressId")]
        public Address Address { set; get; }
    }
}
