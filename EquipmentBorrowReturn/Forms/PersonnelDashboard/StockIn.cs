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
    public partial class StockIn : UserControl
    {
        public StockIn()
        {
            InitializeComponent();
        }

        private void stockIN_Equipment()
        {
            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT equipment_info.equipmentnumber, equipment_info.equipmentname, equipment_info.equipmentquantity, equipment_info.equipmenttype, equipment_info.equipmentcondition, equipment_info.image, CONCAT(admin_info.firstname, ' ', admin_info.middlename, ' ', admin_info.lastname) AS addedby_admin  " +
                               "FROM equipment_info " +
                               "INNER JOIN admin_info on equipment_info.admin_id = admin_info.id";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                    stockINDataGrid.DataSource = table;
                }
            }
        }

        private void StockIn_Load(object sender, EventArgs e)
        {
            stockIN_Equipment();
            stockINDataGrid.RowTemplate.Height = 50;
            stockINDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void EquipmentType_Filter(object sender, EventArgs e)
        {
            string selectedEquipmentType = equipmenttypefilter.SelectedItem?.ToString();
            string selectedEquipmentCondition = equipmentconditionfilter.SelectedItem?.ToString();

            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT equipment_info.equipmentnumber, equipment_info.equipmentname, equipment_info.equipmentquantity, equipment_info.equipmenttype, equipment_info.equipmentcondition, equipment_info.image, CONCAT(admin_info.firstname, ' ', admin_info.middlename, ' ', admin_info.lastname) AS addedby_admin  " +
                               "FROM equipment_info " +
                               "INNER JOIN admin_info on equipment_info.admin_id = admin_info.id " +
                               (selectedEquipmentType != null ? $"WHERE equipment_info.equipmenttype = '{selectedEquipmentType}'" : "");

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                    stockINDataGrid.DataSource = table;
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

                string query = "SELECT equipment_info.equipmentnumber, equipment_info.equipmentname, equipment_info.equipmentquantity, equipment_info.equipmenttype, equipment_info.equipmentcondition, equipment_info.image, CONCAT(admin_info.firstname, ' ', admin_info.middlename, ' ', admin_info.lastname) AS addedby_admin  " +
                               "FROM equipment_info " +
                               "INNER JOIN admin_info on equipment_info.admin_id = admin_info.id " +
                               (selectedEquipmentCondition != null ? $"WHERE equipment_info.equipmentcondition = '{selectedEquipmentCondition}'" : "");

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                    stockINDataGrid.DataSource = table;
                }
            }
        }

        private void EquipmentConditionClick(object sender, EventArgs e)
        {
            equipmentconditionfilter.SelectedItem = null;
            EquipmentCondition_Filter(null, null);
        }

        private void EquipmentTypeClick(object sender, EventArgs e)
        {
            equipmenttypefilter.SelectedItem = null;
            EquipmentType_Filter(null, null);
        }

        private void exportwordbtn_Click(object sender, EventArgs e)
        {
            string headerText = "AVAILABLE EQUIPMENT LIST";
            string footerText = "Generated by Equipment Borrow and Return";
            ExportMicrosoftWordModule.ExportToWord(stockINDataGrid, headerText, footerText);
        }

        private void exportexcelbtn_Click(object sender, EventArgs e)
        {
            ExportMicrosoftExcelModule.ExportToExcel(stockINDataGrid);
        }
    }
}
