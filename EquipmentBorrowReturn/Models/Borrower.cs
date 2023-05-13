using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentBorrowReturn.Models
{
    class Borrower
    {
        [Required(ErrorMessage = "Please Enter First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Middle Name")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter Contact Number")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Email")]
        public string Email { get; set; }

        public byte[] EquipmentImage { get; set; }
    }
}
