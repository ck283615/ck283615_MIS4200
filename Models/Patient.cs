using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ck283615_MIS4200.Models
{
    public class Patient
    {
        [Key]
        public int patientID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Patient first name is required.")]
        [StringLength(20)]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Patient last name is required.")]
        [StringLength(20)]
        public string lastName { get; set; }

        [Display(Name = "Most used email address")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your most frequently used email address.")]
        public string email { get; set; }

        [Display(Name = "Mobile Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$")]
        public string phone { get; set; }

        [Display(Name = "How long have you been a patient?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime patientSince { get; set; }

        public ICollection<Operation> Operation { get; set; }


        public int doctorID { get; set; }


        public virtual Doctor Doctor { get; set; }


    }
}