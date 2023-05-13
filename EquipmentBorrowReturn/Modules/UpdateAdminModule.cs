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
    class UpdateAdminModule
    {
        public static void UpdatePersonnelRecord(string id, string firstName, string middlename, string lastName, string address, string email, string role, string username, string password, bool isImageUpdated, byte[] imageData)
        {
            // Update the personnel record in the database
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";

            // Hash the password using SHA256
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            SHA256 sha256 = SHA256.Create();
            byte[] hashedPasswordBytes = sha256.ComputeHash(passwordBytes);
            string hashedPassword = Convert.ToBase64String(hashedPasswordBytes);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE admin_info SET firstname = @FirstName, middlename = @MiddleName, lastname = @LastName, address = @Address, email = @Email, role = @Role, username = @Username, password = @Password" +
                                                        (isImageUpdated ? ", image = @ImageData" : "") +
                                                        " WHERE id = @Id", connection);

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@MiddleName", middlename);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Role", role);
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
                        MessageBox.Show("Your profile have been updated successfully.");
                    }

                }

                catch (Exception)
                {
                    MessageBox.Show("Failed to update record.");
                }

                finally
                {
                    connection.Close();
                }

            }
        }
    }
}
