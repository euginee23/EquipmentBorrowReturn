using EquipmentBorrowReturn.Forms.PersonnelDashboard;
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
    public partial class PersonnelMain : Form
    {
        private int personnelId;

        public PersonnelMain()
        {
            InitializeComponent();
            this.personnelId = Personnel.personnelId;
            personnelidtxt.Text = "Personnel ID: " + personnelId.ToString();
            Load_PersonnelLogin();

        }

        private void Load_PersonnelLogin()
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Create a MySqlCommand object to retrieve the Personnel name and picture based on the Personnel ID
                using (MySqlCommand command = new MySqlCommand("SELECT firstname, image FROM personnel_info WHERE id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", personnelId);

                    // Execute the command and get the Personnel name and picture
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Display the Personnel name and picture on the form
                            personnelnametxt.Text = "Hello, " + reader.GetString(0);
                            byte[] imageBytes = (byte[])reader["image"];
                            Image image;
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                image = Image.FromStream(ms);
                            }
                            personnelPic.Image = image;
                        }
                    }
                }
            }
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            StockIn stckn = new StockIn();
            addUserControl(stckn);
        }

        private void borrowbtn_Click(object sender, EventArgs e)
        {
            BorrowEquipment brwquip = new BorrowEquipment();
            addUserControl(brwquip);
        }

        private void returnbtn_Click(object sender, EventArgs e)
        {
            ReturnEquipment rtrnequip = new ReturnEquipment();
            addUserControl(rtrnequip);
        }

        private void borrowedequipbtn_Click(object sender, EventArgs e)
        {
            ManageBorrower mngbrrw = new ManageBorrower();
            addUserControl(mngbrrw);
        }

        private void stockoutbtn_Click(object sender, EventArgs e)
        {
            StockOut stckn = new StockOut();
            addUserControl(stckn);
        }

        private void LogOutClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Close the current form and show the login form
                Personnel loginForm = new Personnel();
                loginForm.Show();
                this.Close();
            }       
            else
            {
                this.Hide();
                PersonnelMain perso = new PersonnelMain();
                perso.Show();
            }
        }
    }
}
