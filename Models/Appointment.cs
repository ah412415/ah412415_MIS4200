using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ah412415_MIS4200.Models
{
    public class Appointment
    {
        public int appointmentID { get; set; }
        public int DateTime { get; set; }
        public decimal roomNumber { get; set; }
        public string condition { get; set; }

        [Key]
        public int appointment { get; set; }
        public virtual Patient Patient { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor Doctor { get; set; }
    


    }
}