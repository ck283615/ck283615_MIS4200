using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ck283615_MIS4200.Models
{
    public class PatientDetail
    {
        public int patientdetailID { get; set; }
        public string insuranceCompany { get; set; }
        public decimal amountOwed { get; set; }
        // the next two properties link the orderDetail to the Order
        public int patientID { get; set; }
        public virtual Patient Patient { get; set; }
        // the next two properties link the orderDetail to the Product
        public int operationID { get; set; }
        public virtual Operation Operation { get; set; }
    }
}