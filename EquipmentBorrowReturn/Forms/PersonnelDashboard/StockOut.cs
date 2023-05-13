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

namespace EquipmentBorrowReturn.Forms.PersonnelDashboard
{
    public partial class StockOut : UserControl
    {
        public StockOut()
        {
            InitializeComponent();
        }

        private void StockOut_Equipments()
        {
            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT stockout_equipment.equipment_number, stockout_equipment.equipmentname, stockout_equipment.stockout_quantity, stockout_equipment.stockout_type, stockout_equipment.equipment_condition, stockout_equipment.equipment_status, CONCAT(borrower_info.firstname, ' ', borrower_info.middlename, ' ', borrower_info.lastname) AS lastborrower_name " +
                               "FROM stockout_equipment " +
                               "INNER JOIN borrower_info ON stockout_equipment.last_borrower = borrower_info.id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                    stockOutDataGrid.DataSource = table;
                }
            }
        }

        private void StockOut_Load(object sender, EventArgs e)
        {
            StockOut_Equipments();
            stockOutDataGrid.RowTemplate.Height = 40;
            stockOutDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void EquipmentStatus_Filter(object sender, EventArgs e)
        {
            string selectedEquipmentStatus = equipmentstatusfilter.SelectedItem?.ToString();

            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT stockout_equipment.equipment_number, stockout_equipment.equipmentname, stockout_equipment.stockout_quantity, stockout_equipment.stockout_type, stockout_equipment.equipment_condition, stockout_equipment.equipment_status, CONCAT(borrower_info.firstname, ' ', borrower_info.middlename, ' ', borrower_info.lastname) AS lastborrower_name, stockout_equipment.image " +
                               "FROM stockout_equipment " +
                               "INNER JOIN borrower_info ON stockout_equipment.last_borrower = borrower_info.id " +
                               (selectedEquipmentStatus != null ? $"WHERE stockout_equipment.equipment_status = '{selectedEquipmentStatus}'" : "");

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                    stockOutDataGrid.DataSource = table;
                }
            }
        }

        private void EquipmentCondition_Filter(object sender, EventArgs e)
        {
            string selectedEquipmentCondition = equipmentconditionfilter.SelectedItem?.ToString();

            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT stockout_equipment.equipment_number, stockout_equipment.equipmentname, stockout_equipment.stockout_quantity, stockout_equipment.stockout_type, stockout_equipment.equipment_condition, stockout_equipment.equipment_status, CONCAT(borrower_info.firstname, ' ', borrower_info.middlename, ' ', borrower_info.lastname) AS lastborrower_name, stockout_equipment.image " +
                               "FROM stockout_equipment " +
                               "INNER JOIN borrower_info ON stockout_equipment.last_borrower = borrower_info.id " +
                               (selectedEquipmentCondition != null ? $"WHERE stockout_equipment.equipment_condition = '{selectedEquipmentCondition}'" : "");

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                    stockOutDataGrid.DataSource = table;
                }
            }
        }

        private void EquipmentType_Filter(object sender, EventArgs e)
        {
            string selectedEquipmentType = equipmenttypefilter.SelectedItem?.ToString();

            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT stockout_equipment.equipment_number, stockout_equipment.equipmentname, stockout_equipment.stockout_quantity, stockout_equipment.stockout_type, stockout_equipment.equipment_condition, stockout_equipment.equipment_status, CONCAT(borrower_info.firstname, ' ', borrower_info.middlename, ' ', borrower_info.lastname) AS lastborrower_name, stockout_equipment.image " +
                               "FROM stockout_equipment " +
                               "INNER JOIN borrower_info ON stockout_equipment.last_borrower = borrower_info.id " +
                               (selectedEquipmentType != null ? $"WHERE stockout_equipment.stockout_type = '{selectedEquipmentType}'" : "");

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                    stockOutDataGrid.DataSource = table;
                }
            }
        }

        private void EquipmentStatus_Click(object sender, EventArgs e)
        {
            equipmentstatusfilter.SelectedItem = null;
            EquipmentStatus_Filter(null, null);
        }

        private void EquipmentCondition_Click(object sender, EventArgs e)
        {
            equipmentconditionfilter.SelectedItem = null;
            EquipmentCondition_Filter(null, null);
        }

        private void EquipmentType_Click(object sender, EventArgs e)
        {
            equipmenttypefilter.SelectedItem = null;
            EquipmentType_Filter(null, null);
        }

        private void exportexcelbtn_Click(object sender, EventArgs e)
        {
            ExportMicrosoftExcelModule.ExportToExcel(stockOutDataGrid);
        }

        private void exportwordbtn_Click(object sender, EventArgs e)
        {
            string headerText = "UNAVAILABLE EQUIPMENTS";
            string footerText = "Generated by Equipment Borrow and Return";
            ExportMicrosoftWordModule.ExportToWord(stockOutDataGrid, headerText, footerText);
        }
    }
}
