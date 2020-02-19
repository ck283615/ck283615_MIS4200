using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ck283615_MIS4200.Models
{
    public class Operation
    {
        public int operationID { get; set; }
        public string operationDate { get; set; }
        public string operationDescription { get; set; }

        public ICollection<PatientDetail> PatientDetail { get; set; }
    }
}