﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ah412415_MIS4200.Models
{
    public class Patient1
    {
        public int pateintID { get; set; }
        public string patientFirstName { get; set; }
        public string patientLastName { get; set; }
        public string patientPhone { get; set; }
        public string patientCondition { get; set; }
        public DateTime patientSince { get; set; }


        public ICollection<Appointment1> Appointment { get; set; }

        [Key]
        public int patientID { get; set; }

    }
}