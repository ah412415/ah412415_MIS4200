using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ah412415_MIS4200.Models
{
    public class Patient1
    {
        [Display(Name = "ID")]
        public int pateintID { get; set; }
        [Display(Name = "First Name")]
        public string patientFirstName { get; set; }
        [Display(Name = "Last Name")]
        public string patientLastName { get; set; }
        [Display(Name = "Phone")]
        public string patientPhone { get; set; }
        [Display(Name = "Condition")]
        public string patientCondition { get; set; }
        [Display(Name = "Since")]
        public DateTime patientSince { get; set; }


        public ICollection<Appointment1> Appointment { get; set; }

        [Key]
        public int patientID { get; set; }

    }
}