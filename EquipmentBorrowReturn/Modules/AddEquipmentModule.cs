using EquipmentBorrowReturn.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentBorrowReturn.Modules
{
    class AddEquipmentModule
    {
        public static void InsertEquipment(Equipment equipment, string pictureLocation)
        {
            byte[] images = null;
            FileStream strm = new FileStream(pictureLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(strm);
            images = brs.ReadBytes((int)strm.Length);

            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            string query = "INSERT INTO equipment_info(equipmentname, equipmentnumber, equipmentquantity, equipmenttype, equipmentcondition, image, admin_id)" +
                           "VALUES (@EquipmentName, @EquipmentNumber, @EquipmentQuantity, @EquipmentType, @EquipmentCondition, @Image, @AdminID)";

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@EquipmentName", equipment.EquipmentName);
                cmd.Parameters.AddWithValue("@EquipmentNumber", equipment.EquipmentNumber);
                cmd.Parameters.AddWithValue("@EquipmentQuantity", equipment.EquipmentQuantity);
                cmd.Parameters.AddWithValue("@EquipmentType", equipment.EquipmentType);
                cmd.Parameters.AddWithValue("@EquipmentCondition", equipment.EquipmentCondition);
                cmd.Parameters.AddWithValue("@Image", images);
                cmd.Parameters.AddWithValue("@AdminID", equipment.AdminID);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Equipment Added Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Equipment not added, Please Try Again.");
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
