using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ah412415_MIS4200.Models
{
    public class Appointment1
    {
        [Display(Name = "ID")]
        public int appointmentID { get; set; }
        [Display(Name = "Date")]
        public decimal DateTime { get; set; }
        [Display(Name = "Room Number")]
        public int roomNumber { get; set; }
        [Display(Name = "Condition")]
        public string condition { get; set; }

        [Key]
        public int appointment { get; set; }
        public virtual Patient1 Patient { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor1 Doctor { get; set; }




    }
}