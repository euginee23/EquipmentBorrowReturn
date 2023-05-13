using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentBorrowReturn.Models
{
    class Equipment
    {
        [Required(ErrorMessage = "Please Enter Equipment Name")]
        public string EquipmentName { get; set; }

        [Required(ErrorMessage = "Please Enter Equipment Number")]
        public string EquipmentNumber { get; set; }

        [Required(ErrorMessage = "Please Enter Quantity")]
        public string EquipmentQuantity { get; set; }

        [Required(ErrorMessage = "Please Enter Equipment Type")]
        public string EquipmentType { get; set; }

        [Required(ErrorMessage = "Please Enter Equipment Condition")]
        public string EquipmentCondition { get; set; }

        public string AdminID { get; set; }

        public byte[] EquipmentImage { get; set; }
    }
}
