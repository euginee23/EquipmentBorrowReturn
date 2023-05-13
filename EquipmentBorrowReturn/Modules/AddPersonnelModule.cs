using EquipmentBorrowReturn.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentBorrowReturn.Modules;

namespace EquipmentBorrowReturn.Modules
{
    class AddPersonnelModule
    {
        public static void InsertPersonnel(PersonnelDuty personnel, string pictureLocation)
        {
            byte[] images = null;
            FileStream strm = new FileStream(pictureLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(strm);
            images = brs.ReadBytes((int)strm.Length);

            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";

            // Hash the password using SHA256
            byte[] passwordBytes = Encoding.UTF8.GetBytes(personnel.Password);
            SHA256 sha256 = SHA256.Create();
            byte[] hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
            string hashedPassword = Convert.ToBase64String(hashedPasswordBytes);

            string query = "INSERT INTO personnel_info(firstname, middlename, lastname, address, course, yearlevel, username, password, image)" +
                           "VALUES (@FirstName, @MiddleName, @LastName, @Address, @Course, @YearLevel, @Username, @Password, @Image)";

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FirstName", personnel.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", personnel.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", personnel.LastName);
                cmd.Parameters.AddWithValue("@Address", personnel.Address);
                cmd.Parameters.AddWithValue("@Course", personnel.Course);
                cmd.Parameters.AddWithValue("@YearLevel", personnel.YearLevel);
                cmd.Parameters.AddWithValue("@Username", personnel.Username);
                cmd.Parameters.AddWithValue("@Password", hashedPassword); // use the hashed password
                cmd.Parameters.AddWithValue("@Image", images);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Personnel Added Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Personnel not added, Please Try Again.");
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
