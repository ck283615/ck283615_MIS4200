using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ck283615_MIS4200.Models
{
    public class Operation
    {
        public int operationID { get; set; }

        [Display(Name = "What is the date of the operation?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public string operationDate { get; set;}

        [Display(Name = "Operation Description")]
        [Required(ErrorMessage = "Provide a brief explanation of the operation.")]
        [StringLength(40)]
        public string operationDescription { get; set; }

        public ICollection<PatientDetail> PatientDetail { get; set; }
    }
}