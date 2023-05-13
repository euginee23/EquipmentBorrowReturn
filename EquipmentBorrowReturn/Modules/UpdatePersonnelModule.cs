using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentBorrowReturn.Modules
{
    class UpdatePersonnelModule
    {
        public static void UpdatePersonnelRecord(string id, string firstName, string middlename, string lastName, string address, string course, string yearLevel, string username, string password, bool isImageUpdated, byte[] imageData)
        {
            // Update the personnel record in the database
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";

            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            SHA256 sha256 = SHA256.Create();
            byte[] hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
            string hashedPassword = Convert.ToBase64String(hashedPasswordBytes);


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE personnel_info SET firstname = @FirstName, middlename = @MiddleName, lastname = @LastName, address = @Address, course = @Course, yearlevel = @YearLevel, username = @Username, password = @Password" +
                                                        (isImageUpdated ? ", image = @ImageData" : "") +
                                                        " WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@MiddleName", middlename);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Course", course);
                command.Parameters.AddWithValue("@YearLevel", yearLevel);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Password", hashedPassword);
                if (isImageUpdated && imageData != null)
                {
                    command.Parameters.AddWithValue("@ImageData", imageData);
                }
                command.Parameters.AddWithValue("@Id", id);
                int rowsAffected = command.ExecuteNonQuery();
                try
                {

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Personnel record updated successfully.");
                    }

                }

                catch (Exception)
                {
                    MessageBox.Show("Failed to update personnel record.");
                }

                finally
                {
                    connection.Close();
                }

            }
        }
    }
}
