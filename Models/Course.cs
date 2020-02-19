using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ck283615_MIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string description { get; set; }

        public string classStartTime { get; set; }



        public ICollection<Student> Student { get; set; }
    }
}