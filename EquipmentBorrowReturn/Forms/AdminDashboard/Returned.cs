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
    public partial class Returned : UserControl
    {
        private int adminId;

        public Returned()
        {
            InitializeComponent();
            this.adminId = Admin.adminId;
            adminidtxt.Text = adminId.ToString();
        }

        private void Load_ReturnedEquipments()
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                // Open the database connection
                connection.Open();

                // Create a data adapter to retrieve data from the borrowed_equipment table
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM returned_equipment", connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "returned_equipment");

                // Bind the data to a DataGridView
                returnequipmentDataGrid.DataSource = dataSet.Tables["returned_equipment"];

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

        private void Returned_Load(object sender, EventArgs e)
        {
            Load_ReturnedEquipments();
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
                // Update the equipment information upon admin finished checking
                MySqlCommand updateCommand = new MySqlCommand("UPDATE equipment_info SET equipmentquantity = equipmentquantity + @quantityReturned WHERE id = @equipmentID", connection);
                updateCommand.Parameters.AddWithValue("@equipmentID", int.Parse(equipmentidtxt.Text));
                updateCommand.Parameters.AddWithValue("@quantityReturned", int.Parse(quantitytxt.Text));
                updateCommand.ExecuteNonQuery();

                // Remove the information from the returned upon admin finshed checking
                MySqlCommand returnCommand = new MySqlCommand("DELETE FROM returned_equipment WHERE id = @transactionID", connection);
                returnCommand.Parameters.AddWithValue("@transactionID", int.Parse(transactionidtxt.Text));
                returnCommand.ExecuteNonQuery();

                // Remove the information from the borrowed upon return
                MySqlCommand stockoutremoveCommand = new MySqlCommand("DELETE FROM stockout_equipment WHERE equipment_status = @equipmentstatus", connection);
                stockoutremoveCommand.Parameters.AddWithValue("@equipmentstatus", "Borrowed");
                stockoutremoveCommand.ExecuteNonQuery();

                //Insert to transaction_history
                MySqlCommand historyCommand = new MySqlCommand("INSERT INTO transaction_history (transaction_id, equipment_id, borrower_id, personnel_id, transactiontype, transactiondate, quantityborrowed)" +
                                                          "VALUES (@TransactionID, @Equipment_ID, @Borrower_ID, @Personnel_ID, @TransactionType, @TransactionDate, @QuantityBorrowed)", connection);
                historyCommand.Parameters.AddWithValue("@TransactionID", int.Parse(transactionidtxt.Text));
                historyCommand.Parameters.AddWithValue("@Equipment_ID", equipmentidtxt.Text);
                historyCommand.Parameters.AddWithValue("@Borrower_ID", borroweridtxt.Text);
                historyCommand.Parameters.AddWithValue("@Personnel_ID", personnelidtxt.Text);
                historyCommand.Parameters.AddWithValue("TransactionType", "Checking of Equipment");
                historyCommand.Parameters.AddWithValue("@TransactionDate", DateTime.Now.ToString("dddd, MMMM dd, yyyy"));
                historyCommand.Parameters.AddWithValue("@QuantityBorrowed", quantitytxt.Text);
                historyCommand.ExecuteNonQuery();
                
                Load_ReturnedEquipments();

                MessageBox.Show("Equipment checked and have been updated successfully!");
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

        private void DataGridClick(object sender, DataGridViewCellEventArgs e)
        {
            ReturnedEquipmentGridSelectModule.InformationSelect(returnequipmentDataGrid, transactionidtxt, equipmentidtxt, quantitytxt, borroweridtxt, personnelidtxt, dateborrowedtxt, returnscheduletxt, datereturnedtxt, e);
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
                MySqlCommand command = new MySqlCommand("SELECT equipmentname, equipmentnumber, equipmentquantity, equipmenttype, equipmentcondition, image FROM equipment_info WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", int.Parse(equipmentidtxt.Text));

                // Execute the query and retrieve the results
                MySqlDataReader reader = command.ExecuteReader();

                // Display the equipment name and picture in the appropriate controls
                if (reader.Read())
                {
                    equipmentnametxt.Text = reader.GetString("equipmentname");
                    equipmentnumbertxt.Text = reader.GetString("equipmentnumber");
                    equipmentquantitytxt.Text = reader.GetString("equipmentquantity");
                    equipmenttypetxt.Text = reader.GetString("equipmenttype");
                    equipmentconditiontxt.Text = reader.GetString("equipmentcondition");

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
                command.Parameters.AddWithValue("@id", int.Parse(borroweridtxt.Text));

                // Execute the query and retrieve the results
                MySqlDataReader reader = command.ExecuteReader();

                // Display the borrower name and picture in the appropriate controls
                if (reader.Read())
                {
                    borrowernametxt.Text = reader.GetString("firstname") + " " + reader.GetString("middlename") + " " + reader.GetString("lastname");
                    borroweraddresstxt.Text = reader.GetString("address");
                    borrowercontactnumbertxt.Text = reader.GetString("contactnumber");
                    borroweremailtxt.Text = reader.GetString("email");

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
                command.Parameters.AddWithValue("@id", int.Parse(personnelidtxt.Text));

                // Execute the query and retrieve the results
                MySqlDataReader reader = command.ExecuteReader();

                // Display the borrower name and picture in the appropriate controls
                if (reader.Read())
                {
                    personnelnametxt.Text = reader.GetString("firstname") + " " + reader.GetString("middlename") + " " + reader.GetString("lastname");
                    personneladdresstxt.Text = reader.GetString("address");
                    personnelcourseyeartxt.Text = reader.GetString("course") + " " + reader.GetString("yearlevel");

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
    }
}
