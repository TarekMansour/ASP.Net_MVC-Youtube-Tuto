using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TarekDemo1.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        [Range (2,4)]
        public int CourseCredit { get; set; }

        //Navigation propertie
        public ICollection<Student> Students { get; set; } //many_to_many
    }
}