using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentBorrowReturn.Models;
using EquipmentBorrowReturn.Modules;

namespace EquipmentBorrowReturn.Forms.Registration
{
    public partial class AdminRegistration : Form
    {
        private string pictureLocation;

        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            pictureLocation = PictureBrowseModule.SelectPictureFile();

            if (pictureLocation != null)
            {
                adminpic.ImageLocation = pictureLocation;
            }
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            var Admin_Model = new Administrator
            {
                FirstName = firstnametxt.Text,
                MiddleName = middlenametxt.Text,
                LastName = lastnametxt.Text,
                Address = addresstxt.Text,
                Email = emailtxt.Text,
                Role = roletxt.Text,
                Username = usernametxt.Text,
                Password = passwordtxt.Text,
                ImageData = null
            };

            ValidationContext context = new ValidationContext(Admin_Model);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(Admin_Model, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage} \n");
                MessageBox.Show(errorMsg.ToString(), "Validation Error");
                return;
            }

            else
            {
                if (reenterpasswordtxt.Text != passwordtxt.Text)
                {
                    MessageBox.Show("Password do not match");
                    return;
                }
                else
                {
                    RegisterAdminModule.RegisterAdmin(Admin_Model, pictureLocation); 
                }
                
            }
            
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close(); 
        }

    }
}
