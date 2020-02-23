using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ah412415_MIS4200.Models
{
    public class Doctor1
    {
        [Display (Name ="First Name")]
        public string doctorFirstName { get; set; }
        [Display (Name = "Last Name")]
        public string doctorLastName { get; set; }
        [Display (Name = "Since")]
        public string doctorSince { get; set; }
        [Display (Name ="Specialty")]
        public string doctorSpecialty { get; set; }
        [Display (Name = "Email")]
        public string doctorEmail { get; set; }
        [Display (Name = "Phone")]
        public string doctorPhone { get; set; }
        public ICollection<Appointment1> Appointment { get; set; }

        [Key]
        public int doctorID { get; set; }

    }
}