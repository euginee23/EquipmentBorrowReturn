using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentBorrowReturn.Modules
{
    class UpdateBorrowerModule
    {
        public static void UpdateBorrowerRecord(string id, string firstname, string middlename, string lastname, string address, string contactnumber, string email, bool isImageUpdated, byte[] imageData)
        {
            // Update the personnel record in the database
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE borrower_info SET firstname = @FirstName, middlename = @MiddleName, lastname = @Lastname, address = @Address, contactnumber = @ContactNumber, email = @Email" +
                                                        (isImageUpdated ? ", image = @ImageData" : "") +
                                                        " WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@FirstName", firstname);
                command.Parameters.AddWithValue("@MiddleName", middlename);
                command.Parameters.AddWithValue("@Lastname", lastname);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@ContactNumber", contactnumber);
                command.Parameters.AddWithValue("@Email", email);

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
                        MessageBox.Show("Borrower record updated successfully.");
                    }

                }

                catch (Exception)
                {
                    MessageBox.Show("Failed to update borrower record.");
                }

                finally
                {
                    connection.Close();
                }

            }
        }
    }
}
