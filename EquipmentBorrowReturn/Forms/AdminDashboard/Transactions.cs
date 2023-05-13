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
using System.Drawing.Printing;
using Excel = Microsoft.Office.Interop.Excel;
using EquipmentBorrowReturn.Modules;

namespace EquipmentBorrowReturn
{
    public partial class Transactions : UserControl
    {
        private DataTable transactionTable;

        public Transactions()
        {
            InitializeComponent();
        }

        private void transaction_dgv()
        {
            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";

            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT transaction_history.transaction_id, transaction_history.transactiontype, transaction_history.quantityborrowed, transaction_history.transactiondate, equipment_info.equipmentname, " +
                               "CONCAT(personnel_info.firstname, ' ', personnel_info.middlename, ' ', personnel_info.lastname) AS personnel_name, " +
                               "CONCAT(borrower_info.firstname, ' ', borrower_info.middlename, ' ', borrower_info.lastname) AS borrower_name, borrower_info.contactnumber, borrower_info.address, borrower_info.email " +
                               "FROM transaction_history " +
                               "INNER JOIN equipment_info ON transaction_history.equipment_id = equipment_info.id " +
                               "INNER JOIN personnel_info ON transaction_history.personnel_id = personnel_info.id " +
                               "INNER JOIN borrower_info ON transaction_history.borrower_id = borrower_info.id";


                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    transactionTable = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(transactionTable);
                    }
                    transactionHistory.DataSource = transactionTable;
                }
            }
        }
        private void Transactions_Load(object sender, EventArgs e)
        {
            transaction_dgv();
            transactionHistory.RowTemplate.Height = 40;
            transactionHistory.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void TransctionFilter(object sender, EventArgs e)
        {
            string selectedTransactionType = transactiontypefilter.SelectedItem?.ToString();

            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT transaction_history.transaction_id, transaction_history.transactiontype, transaction_history.quantityborrowed, transaction_history.transactiondate, equipment_info.equipmentname, " +
                               "CONCAT(personnel_info.firstname, ' ', personnel_info.middlename, ' ', personnel_info.lastname) AS personnel_name, " +
                               "CONCAT(borrower_info.firstname, ' ', borrower_info.middlename, ' ', borrower_info.lastname) AS borrower_name, borrower_info.contactnumber, borrower_info.address, borrower_info.email " +
                               "FROM transaction_history " +
                               "INNER JOIN equipment_info ON transaction_history.equipment_id = equipment_info.id " +
                               "INNER JOIN personnel_info ON transaction_history.personnel_id = personnel_info.id " +
                               "INNER JOIN borrower_info ON transaction_history.borrower_id = borrower_info.id " +
                               (selectedTransactionType != null ? $"WHERE transaction_history.transactiontype = '{selectedTransactionType}'" : "");


                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                    transactionHistory.DataSource = table;
                }
            }
        }

        private void RefreshClick(object sender, EventArgs e)
        {
            transactiontypefilter.SelectedItem = null;
            TransctionFilter(null, null);
        }

        private void export_Click(object sender, EventArgs e)
        {
            ExportMicrosoftExcelModule.ExportToExcel(transactionHistory);
        }

        private void exportword_Click(object sender, EventArgs e)
        {
            string headerText = "TRANSACTION HISTORY REPORT";
            string footerText = "Generated by Equipment Borrow and Return";
            ExportMicrosoftWordModule.ExportToWord(transactionHistory, headerText, footerText);
        }
    }
}
