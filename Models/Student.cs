using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ck283615_MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string email { get; set; }
        public string phone { get; set; }
        public int graduationYear { get; set; }


        public ICollection<Course> Course { get; set; }
    }
}