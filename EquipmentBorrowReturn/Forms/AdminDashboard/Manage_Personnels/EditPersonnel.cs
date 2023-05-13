using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EquipmentBorrowReturn.Modules;
using System.IO;

namespace EquipmentBorrowReturn.Forms.AdminDashboard.Manage_Personnels
{
    public partial class EditPersonnel : UserControl
    {
        public EditPersonnel()
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

        private void EditPersonnel_Load(object sender, EventArgs e)
        {
            Load_Personnel();
            personnelinfoDataGrid.RowTemplate.Height = 50;
            personnelinfoDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void SelectPersonnelGrid(object sender, DataGridViewCellEventArgs e)
        {
            PersonnelDataGridSelectModule.PersonnelSelect(personnelinfoDataGrid, personnelidtxt, firstnametxt, middlenametxt, lastnametxt, addresstxt, coursetxt, yearleveltxt, usernametxt, passwordtxt, personnelPicture, e);
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string id = personnelidtxt.Text;
            string firstName = firstnametxt.Text;
            string middlename = middlenametxt.Text;
            string lastName = lastnametxt.Text;
            string address = addresstxt.Text;
            string course = coursetxt.Text;
            string yearLevel = yearleveltxt.Text;
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            byte[] imageData = null;

            bool isImageUpdated = checkupdatePic.Checked;
            if (isImageUpdated)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageData = File.ReadAllBytes(openFileDialog.FileName);
                }
            }

            UpdatePersonnelModule.UpdatePersonnelRecord(id, firstName, middlename, lastName, address, course, yearLevel, username, password, isImageUpdated, imageData);
            Load_Personnel();
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(personnelidtxt.Text);
            bool success = DeletePersonnelModule.DeletePersonnel(id);
            try
            {
                if (success)
                {
                    MessageBox.Show("Personnel record deleted successfully.");
                    Load_Personnel();
                }
                else
                {
                    MessageBox.Show("Failed to delete personnel record.");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
