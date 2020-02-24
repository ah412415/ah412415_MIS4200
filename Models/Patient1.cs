using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ah412415_MIS4200.Models
{
    public class Patient1
    {
        [Display(Name = "ID")]
        [Required(ErrorMessage = "Required")]
        
        public int pateintID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Patient first name is required")]
        
        public string patientFirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Patient last name is required")]
        public string patientLastName { get; set; }


        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$", ErrorMessage = "Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        
        public string patientPhone { get; set; }



       [Display(Name = "Condition")]
       [Required(ErrorMessage ="Required")]
        public string patientCondition { get; set; }


        [Display(Name = "Since")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime patientSince { get; set; }


        public ICollection<Appointment1> Appointment { get; set; }

        [Key]
        public int patientID { get; set; }

    }
}