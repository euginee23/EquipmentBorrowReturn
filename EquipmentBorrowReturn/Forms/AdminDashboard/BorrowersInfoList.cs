using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentBorrowReturn.Modules;
using MySql.Data.MySqlClient;

namespace EquipmentBorrowReturn
{
    public partial class BorrowersInfoList : UserControl
    {
        public BorrowersInfoList()
        {
            InitializeComponent();
        }

        private void Load_Borrower()
        {
            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT * FROM borrower_info";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                    borrowerinfoDataGrid.DataSource = table;
                }
            }
        }

        private void GetBorrowerInfo(object sender, DataGridViewCellEventArgs e)
        {
            BorrowerEditSelectModule.BorrowerSelect(borrowerinfoDataGrid, borroweridtxt, firstnametxt, middlenametxt, lastnametxt, addresstxt, contactnumbertxt, emailtxt, borrowerPicture, e);
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(borroweridtxt.Text);
            bool success = DeleteBorrowerModule.DeleteEquipment(id);
            try
            {
                if (success)
                {
                    MessageBox.Show("Borrower record deleted successfully.");
                    Load_Borrower();
                }
                else
                {
                    MessageBox.Show("Failed to delete borrower record.");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void BorrowersInfoList_Load(object sender, EventArgs e)
        {
            Load_Borrower();
        }

        private void SearchBorrower(object sender, EventArgs e)
        {
            string mysqlcon = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(mysqlcon);
            connection.Open();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM borrower_info WHERE id LIKE @BorrowerID OR firstname LIKE @FirstName OR middlename LIKE @MiddleName OR LastName LIKE @LastName OR Address LIKE @Address OR contactnumber LIKE @ContactNumber";

            command.Parameters.AddWithValue("@BorrowerID", $"%{searchtxt.Text}%");
            command.Parameters.AddWithValue("@FirstName", $"%{searchtxt.Text}%");
            command.Parameters.AddWithValue("@MiddleName", $"%{searchtxt.Text}%");
            command.Parameters.AddWithValue("@LastName", $"%{searchtxt.Text}%");
            command.Parameters.AddWithValue("@Address", $"%{searchtxt.Text}%");
            command.Parameters.AddWithValue("@ContactNumber", $"%{searchtxt.Text}%");
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            borrowerinfoDataGrid.DataSource = dt;
        }
    }
}
