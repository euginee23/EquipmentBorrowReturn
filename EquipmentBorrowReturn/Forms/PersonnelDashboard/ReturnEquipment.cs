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
    public partial class ReturnEquipment : UserControl
    {
        public ReturnEquipment()
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
                returnequipmentDataGrid.DataSource = dataSet.Tables["borrowed_equipment"];

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
        private void ReturnEquipment_Load(object sender, EventArgs e)
        {
            Load_BorrowedEquipment();
            returnequipmentbtn.Enabled = false;
            markequipmentbtn.Enabled = false;
        }

        private void EquipmentReturnSelectGrid(object sender, DataGridViewCellEventArgs e)
        {
            EquipmentReturnSelectModule.EquipmentReturnSelect(returnequipmentDataGrid, TransactionID, equipmenttxt, quantitytxt, borrowertxt, personneltxt, dateborrowedtxt, scheduletxt, e);
        }

        private void GetEquipmentInfo(object sender, EventArgs e)
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
                    equipmentquantitytxt.Text = reader.GetString("equipmentquantity");
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

        private void GetBorrowerInfo(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Open the database connection
                connection.Open();

                // Retrieve the picture and name of the borrower from the borrower_info table
                MySqlCommand command = new MySqlCommand("SELECT firstname, middlename, lastname, address, contactnumber, email, image FROM borrower_info WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(borrowertxt.Text));

                // Execute the query and retrieve the results
                MySqlDataReader reader = command.ExecuteReader();

                // Display the borrower name and picture in the appropriate controls
                if (reader.Read())
                {
                    borrowernametxt.Text = reader.GetString("firstname") + " " + reader.GetString("middlename") + " " + reader.GetString("lastname");
                    addresstxt.Text = reader.GetString("address");
                    emailtxt.Text = reader.GetString("email");
                    contactnumbertxt.Text = reader.GetString("contactnumber");

                    // Retrieve the picture as a byte array
                    byte[] pictureData = (byte[])reader["image"];

                    // Convert the byte array to an Image object and display it in the PictureBox
                    MemoryStream ms = new MemoryStream(pictureData);
                    borrowerPicture.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("Borrower not found!");
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

        private void GetPersonnelInfo(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Open the database connection
                connection.Open();

                // Retrieve the picture and name of the borrower from the borrower_info table
                MySqlCommand command = new MySqlCommand("SELECT firstname, middlename, lastname, address, course, yearlevel, image FROM personnel_info WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(personneltxt.Text));

                // Execute the query and retrieve the results
                MySqlDataReader reader = command.ExecuteReader();

                // Display the borrower name and picture in the appropriate controls
                if (reader.Read())
                {
                    personnelnametxt.Text = reader.GetString("firstname") + " " + reader.GetString("middlename") + " " + reader.GetString("lastname");
                    personneladdresstxt.Text = reader.GetString("address");
                    personnelcoursetxt.Text = reader.GetString("course");
                    personnelyearleveltxt.Text = reader.GetString("yearlevel");

                    // Retrieve the picture as a byte array
                    byte[] pictureData = (byte[])reader["image"];

                    // Convert the byte array to an Image object and display it in the PictureBox
                    MemoryStream ms = new MemoryStream(pictureData);
                    personnelPicture.Image = Image.FromStream(ms);
                }
                else
                {
                    MessageBox.Show("Personnel not found!");
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

        private void returnequipmentbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Open the database connection
                connection.Open();

                // Return the equipment

                // Add to the returned_equipment table
                MySqlCommand borrowCommand = new MySqlCommand("INSERT INTO returned_equipment (id, equipment_id, quantity, borrower_id, personnel_id, dateBorrowed, returnSchedule, dateReturned, equipmentstatus)" +
                                                              "VALUES (@transactionID, @equipment_id, @quantity, @borrower_id, @personnel_id, @date_borrowed, @return_schedule, @dateReturned, @equipmentStatus)", connection);
                borrowCommand.Parameters.AddWithValue("@transactionID", int.Parse(TransactionID.Text));
                borrowCommand.Parameters.AddWithValue("@equipment_id", int.Parse(equipmenttxt.Text));
                borrowCommand.Parameters.AddWithValue("@quantity", int.Parse(quantitytxt.Text));
                borrowCommand.Parameters.AddWithValue("@borrower_id", int.Parse(borrowertxt.Text));
                borrowCommand.Parameters.AddWithValue("@personnel_id", int.Parse(personneltxt.Text));
                borrowCommand.Parameters.AddWithValue("@date_borrowed", dateborrowedtxt.Text);
                borrowCommand.Parameters.AddWithValue("@return_schedule", scheduletxt.Text);
                borrowCommand.Parameters.AddWithValue("@dateReturned", dateReturned.Value);
                borrowCommand.Parameters.AddWithValue("@equipmentStatus", equipmentstatustxt.Text);

                borrowCommand.ExecuteNonQuery();

                // Remove the information from the borrowed upon return
                MySqlCommand returnCommand = new MySqlCommand("DELETE FROM borrowed_equipment WHERE id = @transactionID", connection);
                returnCommand.Parameters.AddWithValue("@transactionID", int.Parse(TransactionID.Text));
                returnCommand.ExecuteNonQuery();
                Load_BorrowedEquipment();

                //Insert to transaction_history
                MySqlCommand historyCommand = new MySqlCommand("INSERT INTO transaction_history (transaction_id, equipment_id, borrower_id, personnel_id, transactiontype, transactiondate, quantityborrowed)" +
                                                          "VALUES (@TransactionID, @Equipment_ID, @Borrower_ID, @Personnel_ID, @TransactionType, @TransactionDate, @QuantityBorrowed)", connection);
                historyCommand.Parameters.AddWithValue("@TransactionID", int.Parse(TransactionID.Text));
                historyCommand.Parameters.AddWithValue("@Equipment_ID", equipmenttxt.Text);
                historyCommand.Parameters.AddWithValue("@Borrower_ID", borrowertxt.Text);
                historyCommand.Parameters.AddWithValue("@Personnel_ID", personneltxt.Text);
                historyCommand.Parameters.AddWithValue("TransactionType", "Returning of Equipment");
                historyCommand.Parameters.AddWithValue("@TransactionDate", DateTime.Now.ToString("dddd, MMMM dd, yyyy"));
                historyCommand.Parameters.AddWithValue("@QuantityBorrowed", quantitytxt.Text);
                historyCommand.ExecuteNonQuery();
                
                MessageBox.Show("Equipment returned successfully!");
            }
            catch (Exception ex)
            {
                // Display an error message if the returning fails due to an exception
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the database connection
                connection.Close();
            }
        }

        private void EquipmentStatus(object sender, EventArgs e)
        {
            // Enable/disable buttons based on selected value
            if (equipmentstatustxt.SelectedItem.ToString() == "Lost" || equipmentstatustxt.SelectedItem.ToString() == "Damaged")
            {
                returnequipmentbtn.Enabled = false;
                markequipmentbtn.Enabled = true;
            }
            else if (equipmentstatustxt.SelectedItem.ToString() == "OK")
            {
                returnequipmentbtn.Enabled = true;
                markequipmentbtn.Enabled = false;
            }
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
    }
}
