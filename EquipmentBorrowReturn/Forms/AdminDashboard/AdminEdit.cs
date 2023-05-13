using EquipmentBorrowReturn.Modules;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EquipmentBorrowReturn.Forms.AdminDashboard
{
    public partial class AdminEdit : UserControl
    {
        private int adminId;

        public AdminEdit()
        {
            InitializeComponent();
            this.adminId = Admin.adminId;
            adminidtxt.Text = adminId.ToString();
            Load_AdminLogIn();
        }

        private void Load_AdminLogIn()
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT firstname, middlename, lastname, address, email, role, username, image FROM admin_info WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", adminId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display the Personnel name and picture on the form
                            firstnametxt.Text = reader.GetString(0);
                            middlenametxt.Text = reader.GetString(1);
                            lastnametxt.Text = reader.GetString(2);
                            addresstxt.Text = reader.GetString(3);
                            emailtxt.Text = reader.GetString(4);
                            roletxt.Text = reader.GetString(5);
                            usernametxt.Text = reader.GetString(6);
                            byte[] imageBytes = (byte[])reader["image"];
                            Image image;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                image = Image.FromStream(ms);
                            }

                            adminpic.Image = image;
                        }
                    }
                }
            }
        }

        private void AdminEdit_Load(object sender, System.EventArgs e)
        {
            Load_AdminLogIn();
        }

        private void updatebtn_Click(object sender, System.EventArgs e)
        {
            string id = adminidtxt.Text;
            string firstName = firstnametxt.Text;
            string middlename = middlenametxt.Text;
            string lastName = lastnametxt.Text;
            string address = addresstxt.Text;
            string email = emailtxt.Text;
            string role = roletxt.Text;
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

            UpdateAdminModule.UpdatePersonnelRecord(id, firstName, middlename, lastName, address, email, role, username, password, isImageUpdated, imageData);
        }
    }
}
