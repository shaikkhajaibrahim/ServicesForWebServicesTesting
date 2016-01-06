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
    /// Courses
    /// </summary>
    [Table("Course")]
    public class Course
    {
        /// <summary>
        /// Course Id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        /// <summary>
        /// Course Name
        /// </summary>
        [Required]
        [StringLength(255)]
        public string CourseName { set; get; }

        /// <summary>
        /// Course Contents
        /// </summary>
        public string CourseContents { set; get; }
    }
}
