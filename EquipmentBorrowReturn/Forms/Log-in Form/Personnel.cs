using EquipmentBorrowReturn.Modules;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentBorrowReturn
{
    public partial class Personnel : Form
    {
        public static int personnelId;

        public Personnel()
        {
            InitializeComponent();
        }

        private void AdminBTN_Click(object sender, EventArgs e)
        {
            Admin objAdmin = new Admin();
            objAdmin.Show();
            this.Hide();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginPersonnel_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            string query = "SELECT * FROM personnel_info WHERE username=@Username";

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);

                try
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Get the hashed password from the database
                        string hashedPassword = reader.GetString("password");

                        // Hash the entered password using the same algorithm used during registration
                        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                        SHA256 sha256 = SHA256.Create();
                        byte[] hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
                        string hashedEnteredPassword = Convert.ToBase64String(hashedPasswordBytes);

                        if (hashedEnteredPassword == hashedPassword)
                        {
                            // Login successful
                            MessageBox.Show("Login Successful!");
                            personnelId = reader.GetInt32(0);
                            PersonnelMain objPersonnelMain = new PersonnelMain();
                            objPersonnelMain.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            // Login failed
                            MessageBox.Show("Invalid Username or Password!");
                        }
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid Username or Password!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
