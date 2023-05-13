using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentBorrowReturn.Models;
using System.ComponentModel.DataAnnotations;
using EquipmentBorrowReturn.Modules;
using MySql.Data.MySqlClient;

namespace EquipmentBorrowReturn.Forms.AdminDashboard.Manage_Personnels
{
    public partial class AddPersonnel : UserControl
    {
        private string pictureLocation;

        public AddPersonnel()
        {
            InitializeComponent();
        }

        private void Load_Personnel()
        {
            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT * FROM personnel_info";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                    personnelinfoDataGrid.DataSource = table;
                }
            }
        }

        private void addregisterbtn_Click(object sender, EventArgs e)
        {
            var Personnel_Model = new PersonnelDuty
            {
                FirstName = firstnametxt.Text,
                MiddleName = middlenametxt.Text,
                LastName = lastnametxt.Text,
                Address = addresstxt.Text,
                Course = coursetxt.Text,
                YearLevel = yearleveltxt.Text,
                Username = usernametxt.Text,
                Password = passwordtxt.Text,
                ImageData = null
            };

            ValidationContext context = new ValidationContext(Personnel_Model);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(Personnel_Model, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage} \n");
                MessageBox.Show(errorMsg.ToString(), "Validation Error");
                return;
            }

            else
            {
                AddPersonnelModule.InsertPersonnel(Personnel_Model, pictureLocation);
                Load_Personnel();
            }
        }

        private void browsepicbtn_Click(object sender, EventArgs e)
        {
            pictureLocation = PictureBrowseModule.SelectPictureFile();

            if (pictureLocation != null)
            {
                personnelPicture.ImageLocation = pictureLocation;
            }
        }

        private void AddPersonnel_Load(object sender, EventArgs e)
        {
            Load_Personnel();
            personnelinfoDataGrid.RowTemplate.Height = 50;
            personnelinfoDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
    }
}
