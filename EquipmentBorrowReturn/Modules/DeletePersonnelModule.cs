using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentBorrowReturn.Modules
{
    class DeletePersonnelModule
    {
        public static bool DeletePersonnel(int id)
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("DELETE FROM personnel_info WHERE id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
