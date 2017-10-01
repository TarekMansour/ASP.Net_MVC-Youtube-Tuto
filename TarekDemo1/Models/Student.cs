using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TarekDemo1.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }

        public int Grade_FK { get; set; }

        //Navigation properties
        public ICollection<Course> Courses { get; set; }
        [ForeignKey ("Grade_FK")]
        public Grade Grade { get; set; }
    }
}