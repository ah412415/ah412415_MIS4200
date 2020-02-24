using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ah412415_MIS4200.Models
{
    public class Doctor1
    {

        [Display (Name ="First Name")]
        [Required(ErrorMessage ="Doctor first name is required")]
        [StringLength(20)]

        public string doctorFirstName { get; set; }
        [Display (Name = "Last Name")]
        [Required(ErrorMessage = "Doctor last name is required")]
        [StringLength(20)]
        public string doctorLastName { get; set; }


        [Display (Name = "Since")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode = true)]
       
        public string doctorSince { get; set; }


        [Display (Name ="Specialty")]
        [Required(ErrorMessage = "Required")]
        [StringLength(20)]
        public string doctorSpecialty { get; set; }

         [Display (Name = "Email")]
        [Required(ErrorMessage = "Required")]
        [StringLength(100)]
        public string doctorEmail { get; set; }


        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]

        public string doctorPhone { get; set; }

        public ICollection<Appointment1> Appointment { get; set; }

        [Key]

        [Display(Name = "Doctor Name")]
        public int doctorID { get; set; }

    }
}