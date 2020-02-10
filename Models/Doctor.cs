using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ah412415_MIS4200.Models
{
    public class Doctor
    {
        public int doctorID { get; set; }
        public string doctorFirstName { get; set; }
        public string doctorLastName { get; set; }
        public string doctorSince { get; set; }
        public string doctorSpecialty { get; set; }
        public string doctorEmail { get; set; }
        public string doctorPhone { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        [Key]
        public int doctor { get; set; }
    }
}