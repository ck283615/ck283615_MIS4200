using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ck283615_MIS4200.Models
{
    public class Schedule
    {
        public int scheduleID { get; set; }
        public int numberOfClasses { get; set; }

        public int courseID { get; set; }
        public virtual Course Course { get; set; }

        public int studentID { get; set; }
        public virtual Course Student { get; set; }

    }
}