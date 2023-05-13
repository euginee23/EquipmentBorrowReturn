using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentBorrowReturn.Modules
{
    class UpdateEquipmentModule
    {
        public static void UpdateEquipmentRecord(string id, string equipmentname, string equipmentnumber, string equipmentquantity, string equipmenttype, string equipmentcondition, string equipmentAdminID, bool isImageUpdated, byte[] imageData)
        {
            // Update the personnel record in the database
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE equipment_info SET equipmentname = @equipmentName, equipmentnumber = @equipmentNumber, equipmentquantity = @equipmentQuantity, equipmenttype = @equipmentType, equipmentcondition = @equipmentCondition, admin_id = @equipmentAdminID" +
                                                        (isImageUpdated ? ", image = @ImageData" : "") +
                                                        " WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@equipmentName", equipmentname);
                command.Parameters.AddWithValue("@equipmentNumber", equipmentnumber);
                command.Parameters.AddWithValue("@equipmentQuantity", equipmentquantity);
                command.Parameters.AddWithValue("@equipmentType", equipmenttype);
                command.Parameters.AddWithValue("@equipmentCondition", equipmentcondition);
                command.Parameters.AddWithValue("@equipmentAdminID", equipmentAdminID);

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
