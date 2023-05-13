using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentBorrowReturn.Modules;
using MySql.Data.MySqlClient;
using EquipmentBorrowReturn.Models;
using System.ComponentModel.DataAnnotations;

namespace EquipmentBorrowReturn.Forms.PersonnelDashboard.Manage_Borrower
{
    public partial class AddBorrower : UserControl
    {
        private string pictureLocation;

        public AddBorrower()
        {
            InitializeComponent();
        }

        private void Load_Borrower()
        {
            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT * FROM borrower_info";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                    borrowerinfoDataGrid.DataSource = table;
                }
            }
        }

        private void browsepicbtn_Click(object sender, EventArgs e)
        {
            pictureLocation = PictureBrowseModule.SelectPictureFile();

            if (pictureLocation != null)
            {
                borrowerPicture.ImageLocation = pictureLocation;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var Borrower_Model = new Borrower
            {
                FirstName = firstnametxt.Text,
                MiddleName = middlenametxt.Text,
                LastName = lastnametxt.Text,
                Address = addresstxt.Text,
                ContactNumber = contactnumbertxt.Text,
                Email = emailtxt.Text,
                EquipmentImage = null
            };

            ValidationContext context = new ValidationContext(Borrower_Model);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(Borrower_Model, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage} \n");
                MessageBox.Show(errorMsg.ToString(), "Validation Error");
                return;
            }

            else
            {
                AddBorrowerModule.InsertBorrower(Borrower_Model, pictureLocation);
            }
        }

        private void AddBorrower_Load(object sender, EventArgs e)
        {
            Load_Borrower();
            borrowerinfoDataGrid.RowTemplate.Height = 50;
            borrowerinfoDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }
}
