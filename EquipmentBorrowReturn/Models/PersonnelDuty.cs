using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentBorrowReturn.Models
{
    class PersonnelDuty
    {
        [Required(ErrorMessage = "Please Enter First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter Course")]
        public string Course { get; set; }

        [Required(ErrorMessage = "Please Enter Year level")]
        public string YearLevel { get; set; }

        [Required(ErrorMessage = "Please Enter Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }

        public byte[] ImageData { get; set; }
    }
}
