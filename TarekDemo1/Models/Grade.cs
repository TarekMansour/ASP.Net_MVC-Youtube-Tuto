using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TarekDemo1.Models
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }

        //Navigation propertie
        public ICollection<Student> Students { get; set; }
    }
}