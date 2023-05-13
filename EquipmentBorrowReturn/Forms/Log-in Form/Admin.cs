using EquipmentBorrowReturn.Forms.Registration;
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
    public partial class Admin : Form
    {
        public static int adminId;

        public Admin()
        {
            InitializeComponent();
        }


        //LOG IN BUTTON
        private void AdminLoginbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            string query = "SELECT * FROM admin_info WHERE username=@Username";

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
                            adminId = reader.GetInt32(0);
                            AdminMain adminForm = new AdminMain();
                            adminForm.ShowDialog();
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

        //BACK TO PERSONNEL LOG IN BUTTON
        private void backbtn_Click(object sender, EventArgs e)
        {
            Personnel objPersonnel = new Personnel();
            objPersonnel.Show();
            this.Hide();
        }
        //Open Registration Form
        private void registerbtn_Click(object sender, EventArgs e)
        {
            AdminRegistration objRgstr = new AdminRegistration();
            objRgstr.Show();
            this.Hide();
        }
    }
}
