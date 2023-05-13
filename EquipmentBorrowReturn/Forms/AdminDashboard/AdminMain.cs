using EquipmentBorrowReturn.Forms.AdminDashboard;
using EquipmentBorrowReturn.Forms.AdminDashboard.Manage_Personnels;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentBorrowReturn
{
    public partial class AdminMain : Form
    {
        private int adminId;

        public AdminMain()
        {
            InitializeComponent();
            this.adminId = Admin.adminId;
            adminidtxt.Text = "Admin ID: " + adminId.ToString();
            Load_AdminLogIn();
        }

        private void Load_AdminLogIn()
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT firstname, image FROM admin_info WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", adminId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display the Personnel name and picture on the form
                            adminnametxt.Text = "Hello, " + reader.GetString(0);
                            byte[] imageBytes = (byte[])reader["image"];
                            Image image;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                image = Image.FromStream(ms); 
                            }
                             
                            adminPic.Image = image;
                        }
                    }
                }
            }
        }

        private void addUserControl (UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        //MANAGE EQUIPMENTS BUTTON
        private void managebtn_Click(object sender, EventArgs e)
        {
            Manage mng = new Manage();
            addUserControl(mng);
        }

        private void transactionsbtn_Click(object sender, EventArgs e)
        {
            Transactions trnsctns = new Transactions();
            addUserControl(trnsctns);
        }

        private void borrowedbtn_Click(object sender, EventArgs e)
        {
            Borrowed brrwd = new Borrowed();
            addUserControl(brrwd);
        }

        private void returnedbtn_Click(object sender, EventArgs e)
        {
            Returned rtrnd = new Returned();
            addUserControl(rtrnd);
        }

        private void personnelsbtn_Click(object sender, EventArgs e)
        {
            ManagePersonnel prsnls = new ManagePersonnel();
            addUserControl(prsnls);
        }

        private void borrowersllistbtn_Click(object sender, EventArgs e)
        {
            BorrowersInfoList BorrInfoList = new BorrowersInfoList();
            addUserControl(BorrInfoList);
        }

        private void logout(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Admin objAdmin = new Admin();
                objAdmin.Show();
                this.Hide();
            }
        }

        private void chartpanelbtn_Click(object sender, EventArgs e)
        {
            Chart chartpanel = new Chart();
            addUserControl(chartpanel);
        }

        private void admineditbtn(object sender, EventArgs e)
        {
            AdminEdit adminedit = new AdminEdit();
            addUserControl(adminedit);
        }
    }
}
