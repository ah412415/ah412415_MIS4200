using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ah412415_MIS4200.Models
{
    public class Appointment1
    {
        public int appointmentID { get; set; }
        public decimal DateTime { get; set; }
        public int roomNumber { get; set; }
        public string condition { get; set; }

        [Key]
        public int appointment { get; set; }
        public virtual Patient1 Patient { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor1 Doctor { get; set; }




    }
}