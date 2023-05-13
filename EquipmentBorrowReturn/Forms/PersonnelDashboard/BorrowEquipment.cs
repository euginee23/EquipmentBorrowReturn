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
    public partial class BorrowEquipment : UserControl
    {
        private int personnelId;

        public BorrowEquipment()
        {
            InitializeComponent();
            this.personnelId = Personnel.personnelId;
            personneltxt.Text = personnelId.ToString();
        }

        public BorrowEquipment(int personnelId)
        {
            personneltxt.Text = this.personnelId.ToString();
        }

        private void Equipment_Grid()
        {
            string mysqlcon = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(mysqlcon);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM equipment_info";
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            equipmentDataGrid.DataSource = dt;
        }

        private void Borrower_Grid()
        {
            string mysqlcon = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(mysqlcon);
            connection.Open();

            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM borrower_info";
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            borrowerDataGrid.DataSource = dt;
        }

        private void borrowbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                MySqlCommand checkCommand = new MySqlCommand("SELECT equipmentquantity FROM equipment_info WHERE id = @id", connection);
                checkCommand.Parameters.AddWithValue("@id", int.Parse(equipmenttxt.Text));

                int quantity = 0;
                using (var reader = checkCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        quantity = reader.GetInt32("equipmentquantity");
                    }
                }

                int requestedQuantity = int.Parse(quantitytxt.Text);

                if (requestedQuantity > quantity)
                {
                    MessageBox.Show("The requested quantity is more than the availability.");
                    connection.Close();
                    return;
                }

                if (quantity == 0)
                {
                    MessageBox.Show("There is no stock left for this equipment.");
                    connection.Close();
                    return;
                }
                else
                {
                    //Insert to borrowed_equipment
                    MySqlCommand borrowCommand = new MySqlCommand("INSERT INTO borrowed_equipment (id, equipment_id, quantity, borrower_id, personnel_id, dateBorrowed, returnSchedule)" +
                                                                  "VALUES (@transactionID, @equipment_id, @quantity, @borrower_id, @personnel_id, @date_borrowed, @return_schedule)", connection);
                    borrowCommand.Parameters.AddWithValue("@transactionID", int.Parse(transactionidtxt.Text));
                    borrowCommand.Parameters.AddWithValue("@equipment_id", int.Parse(equipmenttxt.Text));
                    borrowCommand.Parameters.AddWithValue("@quantity", int.Parse(quantitytxt.Text));
                    borrowCommand.Parameters.AddWithValue("@borrower_id", int.Parse(borrowertxt.Text));
                    borrowCommand.Parameters.AddWithValue("@personnel_id", int.Parse(personneltxt.Text));
                    borrowCommand.Parameters.AddWithValue("@date_borrowed", dateBorrowed.Value);
                    borrowCommand.Parameters.AddWithValue("@return_schedule", dateSchedule.Value);
                    borrowCommand.ExecuteNonQuery();

                    // Decrement the equipment quantity
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE equipment_info SET equipmentquantity = equipmentquantity - @quantityBorrowed WHERE id = @id", connection);
                    updateCommand.Parameters.AddWithValue("@id", int.Parse(equipmenttxt.Text));
                    updateCommand.Parameters.AddWithValue("@quantityBorrowed", int.Parse(quantitytxt.Text));
                    updateCommand.ExecuteNonQuery();

                    //Insert to stockout_equipment
                    MySqlCommand stockoutCommand = new MySqlCommand("INSERT INTO stockout_equipment (equipment_id, equipmentname, equipment_number, stockout_quantity, stockout_type, equipment_condition, equipment_status, last_borrower)" +
                                                              "VALUES (@MarkedEquipmentID, @EquipmentName, @EquipmentNumber, @StockOutQuantity, @StockOutType, @Equipment_Condition, @EquipmentStatus, @LastBorrower)", connection);
                    stockoutCommand.Parameters.AddWithValue("@MarkedEquipmentID", int.Parse(equipmenttxt.Text));
                    stockoutCommand.Parameters.AddWithValue("@EquipmentName", equipmentnametxt.Text);
                    stockoutCommand.Parameters.AddWithValue("@EquipmentNumber", equipmentnumbertxt.Text);
                    stockoutCommand.Parameters.AddWithValue("@StockOutQuantity", quantitytxt.Text);
                    stockoutCommand.Parameters.AddWithValue("@StockOutType", equipmenttypetxt.Text);
                    stockoutCommand.Parameters.AddWithValue("@Equipment_Condition", equipmentconditiontxt.Text);
                    stockoutCommand.Parameters.AddWithValue("@EquipmentStatus", "Borrowed");
                    stockoutCommand.Parameters.AddWithValue("@LastBorrower", borrowertxt.Text);
                    stockoutCommand.ExecuteNonQuery();

                    // Retrieve the auto-generated ID of the newly inserted row
                    int markedEquipmentId = (int)stockoutCommand.LastInsertedId;

                    // Insert the image into the stockout equipment record
                    if (equipmentPicture.Image != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        equipmentPicture.Image.Save(ms, equipmentPicture.Image.RawFormat);
                        byte[] pictureData = ms.ToArray();

                        MySqlCommand updatecmd = new MySqlCommand("UPDATE stockout_equipment SET image = @Image WHERE id = @MarkedEquipmentID", connection);
                        updatecmd.Parameters.AddWithValue("@Image", pictureData);
                        updatecmd.Parameters.AddWithValue("@MarkedEquipmentID", markedEquipmentId);
                        updatecmd.ExecuteNonQuery();
                    }

                    //Insert to transaction_history
                    MySqlCommand historyCommand = new MySqlCommand("INSERT INTO transaction_history (transaction_id, equipment_id, borrower_id, personnel_id, transactiontype, transactiondate, quantityborrowed)" +
                                                              "VALUES (@TransactionID, @Equipment_ID, @Borrower_ID, @Personnel_ID, @TransactionType, @TransactionDate, @QuantityBorrowed)", connection);
                    historyCommand.Parameters.AddWithValue("@TransactionID", int.Parse(transactionidtxt.Text));
                    historyCommand.Parameters.AddWithValue("@Equipment_ID", equipmenttxt.Text);
                    historyCommand.Parameters.AddWithValue("@Borrower_ID", borrowertxt.Text);
                    historyCommand.Parameters.AddWithValue("@Personnel_ID", personneltxt.Text);
                    historyCommand.Parameters.AddWithValue("TransactionType", "Borrowing Equipment");
                    historyCommand.Parameters.AddWithValue("@TransactionDate", dateBorrowed.Text);
                    historyCommand.Parameters.AddWithValue("@QuantityBorrowed", quantitytxt.Text);
                    historyCommand.ExecuteNonQuery();

                    MessageBox.Show("Equipment borrowed successfully!");

                }

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

        private void BorrowEquipment_Load(object sender, EventArgs e)
        {
            Equipment_Grid();
            Borrower_Grid();
        }

        private void EquipmentSelectGrid(object sender, DataGridViewCellEventArgs e)
        {
            EquipmentBorrowSelectModule.EquipmentSelect(equipmentDataGrid, equipmenttxt, equipmentnametxt, equipmentnumbertxt, equipmenttypetxt, equipmentquantitytxt, equipmentconditiontxt, equipmentadminidtxt, equipmentPicture, e);
        }

        private void BorrowerGridSelect(object sender, DataGridViewCellEventArgs e)
        {
            BorrowerBorrowSelectModule.BorrowerSelect(borrowerDataGrid, borrowertxt, borrowernametxt, addresstxt, emailtxt, contactnumbertxt, borrowerPicture, e);
        }

        private void generatetransactionbtn_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            int random = rndm.Next(0, 999999999);
            transactionidtxt.Text = random.ToString();
        }

        private void EquipmentSearch(object sender, EventArgs e)
        {
            string mysqlcon = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(mysqlcon);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM equipment_info WHERE equipmentname LIKE @EquipmentName OR equipmentnumber LIKE @EquipmentNumber OR equipmenttype LIKE @EquipmentType OR id LIKE @EquipmentID";

            command.Parameters.AddWithValue("@EquipmentName", $"%{equipmentsearchtxt.Text}%");
            command.Parameters.AddWithValue("@EquipmentNumber", $"%{equipmentsearchtxt.Text}%");
            command.Parameters.AddWithValue("@EquipmentType", $"%{equipmentsearchtxt.Text}%");
            command.Parameters.AddWithValue("@EquipmentID", $"%{equipmentsearchtxt.Text}%");
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            equipmentDataGrid.DataSource = dt;
        }

        private void BorrowerSearch(object sender, EventArgs e)
        {
            string mysqlcon = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(mysqlcon);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM borrower_info WHERE id LIKE @BorrowerID OR firstname LIKE @FirstName OR middlename LIKE @MiddleName OR LastName LIKE @LastName OR Address LIKE @Address OR contactnumber LIKE @ContactNumber";

            command.Parameters.AddWithValue("@BorrowerID", $"%{borrowersearchtxt.Text}%");
            command.Parameters.AddWithValue("@FirstName", $"%{borrowersearchtxt.Text}%");
            command.Parameters.AddWithValue("@MiddleName", $"%{borrowersearchtxt.Text}%");
            command.Parameters.AddWithValue("@LastName", $"%{borrowersearchtxt.Text}%");
            command.Parameters.AddWithValue("@Address", $"%{borrowersearchtxt.Text}%");
            command.Parameters.AddWithValue("@ContactNumber", $"%{borrowersearchtxt.Text}%");
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            borrowerDataGrid.DataSource = dt;
        }
    }
}

