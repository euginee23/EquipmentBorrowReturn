using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EquipmentBorrowReturn.Modules;
using System.IO;

namespace EquipmentBorrowReturn
{
    public partial class Borrowed : UserControl
    {
        public Borrowed()
        {
            InitializeComponent();
        }

        private void Load_BorrowedEquipment()
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Open the database connection
                connection.Open();

                // Create a data adapter to retrieve data from the borrowed_equipment table
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM borrowed_equipment", connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "borrowed_equipment");

                // Bind the data to a DataGridView
                borrowedequipmentdatagrid.DataSource = dataSet.Tables["borrowed_equipment"];

            }

            catch (Exception ex)
            {
                // Display an error message if the operation fails due to an exception
                MessageBox.Show("Error: " + ex.Message);
            }

            finally
            {
                // Close the database connection
                connection.Close();
            }
        }

        private void Borrowed_Load(object sender, EventArgs e)
        {
            Load_BorrowedEquipment();
            markequipmentbtn.Enabled = false;
        }


        private void markequipmentbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                MySqlCommand markCommand = new MySqlCommand("INSERT INTO stockout_equipment (equipment_id, equipmentname, equipment_number, stockout_quantity, stockout_type, equipment_condition, equipment_status, last_borrower)" +
                                                              "VALUES (@MarkedEquipmentID, @EquipmentName, @EquipmentNumber, @StockOutQuantity, @StockOutType, @Equipment_Condition, @EquipmentStatus, @LastBorrower)", connection);
                markCommand.Parameters.AddWithValue("@MarkedEquipmentID", int.Parse(equipmenttxt.Text));
                markCommand.Parameters.AddWithValue("@EquipmentName", equipmentnametxt.Text);
                markCommand.Parameters.AddWithValue("@EquipmentNumber", equipmentnumbertxt.Text);
                markCommand.Parameters.AddWithValue("@StockOutQuantity", quantitytxt.Text);
                markCommand.Parameters.AddWithValue("@StockOutType", equipmenttypetxt.Text);
                markCommand.Parameters.AddWithValue("@Equipment_Condition", equipmentconditiontxt.Text);
                markCommand.Parameters.AddWithValue("@EquipmentStatus", equipmentstatustxt.Text);
                markCommand.Parameters.AddWithValue("@LastBorrower", borrowertxt.Text);
                markCommand.ExecuteNonQuery();

                // Retrieve the auto-generated ID of the newly inserted row
                int markedEquipmentId = (int)markCommand.LastInsertedId;

                // Insert the image into the stockout equipment record
                if (equipmentPicture.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    equipmentPicture.Image.Save(ms, equipmentPicture.Image.RawFormat);
                    byte[] pictureData = ms.ToArray();

                    MySqlCommand updateCommand = new MySqlCommand("UPDATE stockout_equipment SET image = @Image WHERE id = @MarkedEquipmentID", connection);
                    updateCommand.Parameters.AddWithValue("@Image", pictureData);
                    updateCommand.Parameters.AddWithValue("@MarkedEquipmentID", markedEquipmentId);
                    updateCommand.ExecuteNonQuery();
                }

                MySqlCommand returnCommand = new MySqlCommand("DELETE FROM borrowed_equipment WHERE id = @transactionID", connection);
                returnCommand.Parameters.AddWithValue("@transactionID", int.Parse(TransactionID.Text));
                returnCommand.ExecuteNonQuery();

                Load_BorrowedEquipment();

                MessageBox.Show("Equipment MARKED!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void EquipmentStatusButtonControl(object sender, EventArgs e)
        {
            if (equipmentstatustxt.SelectedItem.ToString() == "Lost" || equipmentstatustxt.SelectedItem.ToString() == "Damaged")
            {
                markequipmentbtn.Enabled = true;
            }
            else if (equipmentstatustxt.SelectedItem.ToString() == "OK")
            {
                markequipmentbtn.Enabled = false;
            }
        }

        private void ClickContent(object sender, DataGridViewCellEventArgs e)
        {
            EquipmentSelectBorrowedAdminModule.EquipmentBorrowSelect(borrowedequipmentdatagrid, TransactionID, equipmenttxt, quantitytxt, borrowertxt, personneltxt, dateborrowedtxt, scheduletxt, e);
        }

        private void Load_Equipment(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Open the database connection
                connection.Open();

                // Retrieve the picture and name of the equipment from the equipment_info table
                MySqlCommand command = new MySqlCommand("SELECT equipmentname, equipmentnumber, equipmentquantity, equipmenttype, equipmentcondition, admin_id, image FROM equipment_info WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(equipmenttxt.Text));

                // Execute the query and retrieve the results
                MySqlDataReader reader = command.ExecuteReader();

                // Display the equipment name and picture in the appropriate controls
                if (reader.Read())
                {
                    equipmentnametxt.Text = reader.GetString("equipmentname");
                    equipmentnumbertxt.Text = reader.GetString("equipmentnumber");
                    equipmenttypetxt.Text = reader.GetString("equipmenttype");
                    equipmenttypetxt.Text = reader.GetString("equipmenttype");
                    equipmentconditiontxt.Text = reader.GetString("equipmentcondition");
                    equipmentadminidtxt.Text = reader.GetString("admin_id");

                    // Retrieve the picture as a byte array
                    byte[] pictureData = (byte[])reader["image"];

                    // Convert the byte array to an Image object and display it in the PictureBox
                    MemoryStream ms = new MemoryStream(pictureData);
                    equipmentPicture.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("Equipment not found!");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Display an error message if the operation fails due to an exception
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }
        }

    }
}
