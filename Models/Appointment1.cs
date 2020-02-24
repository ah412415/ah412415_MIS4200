using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ah412415_MIS4200.Models
{
    public class Appointment1
    {
        [Display(Name = "Appointment")]
        [Required(ErrorMessage = "Required")]
        public int appointmentID { get; set; }


        [Display(Name = "Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public int DateTime { get; set; }


        [Display(Name = "Room Number")]
        [Required(ErrorMessage ="Required")]
       
        public int roomNumber { get; set; }



        [Display(Name = "Condition")]
        [Required(ErrorMessage = "Required")]
        [StringLength(30)]
        public string condition { get; set; }

        [Key]
        public int appointment { get; set; }
        public virtual Patient1 Patient { get; set; }
        public int doctorID { get; set; }
        public virtual Doctor1 Doctor { get; set; }




    }
}