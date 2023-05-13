using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace EquipmentBorrowReturn.Forms.AdminDashboard
{
    public partial class Chart : UserControl
    {
        public Chart()
        {
            InitializeComponent();
            DrawChartStockIN();
            DrawChartStockOUT();
        }

        private void Chart_Load(object sender, EventArgs e)
        {

        }

        private void DrawChartStockOUT()
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT equipmentname, stockout_quantity as Quantity FROM stockout_equipment";
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                chartEquipmentOUT.Series.Clear();

                Series series = new Series();
                series.Name = "Equipment";
                series.ChartType = SeriesChartType.Pie;
                series.BorderWidth = 1;
                series.Color = Color.Red;
                series.IsValueShownAsLabel = true;
                series.Font = new Font("Arial", 12, FontStyle.Bold);

                while (reader.Read())
                {
                    string equipmentStatus = reader.GetString("equipmentname");
                    int quantity = reader.GetInt32("quantity");

                    series.Points.AddXY(equipmentStatus, quantity);
                }

                chartEquipmentOUT.Series.Add(series);

                chartEquipmentOUT.ChartAreas[0].AxisX.Title = "Equipment Name";
                chartEquipmentOUT.ChartAreas[0].AxisY.Title = "Out Quantity";
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

        private void DrawChartStockIN()
        {
            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT equipmentname, equipmentquantity FROM equipment_info";
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                chartEquipmentIN.Series.Clear();

                Series series = new Series();
                series.Name = "Equipment";
                series.ChartType = SeriesChartType.Pie;
                series.BorderWidth = 1;
                series.Color = Color.Green;
                series.IsValueShownAsLabel = true;
                series.Font = new Font("Arial", 12, FontStyle.Bold);

                while (reader.Read())
                {
                    string equipmentName = reader.GetString("equipmentname");
                    int quantity = reader.GetInt32("equipmentquantity");

                    series.Points.AddXY(equipmentName, quantity);
                }

                chartEquipmentIN.Series.Add(series);

                chartEquipmentIN.ChartAreas[0].AxisX.Title = "Equipment Name";
                chartEquipmentIN.ChartAreas[0].AxisY.Title = "Available Quantity";
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

        private void EquipmentType_Filter(object sender, EventArgs e)
        {
            string selectedTransactionType = equipmenttypecmb.SelectedItem?.ToString();

            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT equipmentname, equipmentquantity FROM equipment_info " +
                (selectedTransactionType != null ? $"WHERE equipmenttype = '{selectedTransactionType}'" : "");
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                chartEquipmentIN.Series.Clear();

                Series series = new Series();
                series.Name = "Equipment";
                series.ChartType = SeriesChartType.Pie;
                series.BorderWidth = 1;
                series.Color = Color.Green;
                series.IsValueShownAsLabel = true;
                series.Font = new Font("Arial", 12, FontStyle.Bold);

                while (reader.Read())
                {
                    string equipmentName = reader.GetString("equipmentname");
                    int quantity = reader.GetInt32("equipmentquantity");

                    series.Points.AddXY(equipmentName, quantity);
                }

                chartEquipmentIN.Series.Add(series);

                chartEquipmentIN.ChartAreas[0].AxisX.Title = "Equipment Name";
                chartEquipmentIN.ChartAreas[0].AxisY.Title = "Available Quantity";
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

        private void EquipmentCondition_Filter(object sender, EventArgs e)
        {
            string selectedCondition = equipmentconditioncmd.SelectedItem?.ToString();

            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT equipmentname, equipmentquantity FROM equipment_info " +
                (selectedCondition != null ? $"WHERE equipmentcondition = '{selectedCondition}'" : "");
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                chartEquipmentIN.Series.Clear();

                Series series = new Series();
                series.Name = "Equipment";
                series.ChartType = SeriesChartType.Pie;
                series.BorderWidth = 1;
                series.Color = Color.Green;
                series.IsValueShownAsLabel = true;
                series.Font = new Font("Arial", 12, FontStyle.Bold);

                while (reader.Read())
                {
                    string equipmentName = reader.GetString("equipmentname");
                    int quantity = reader.GetInt32("equipmentquantity");

                    series.Points.AddXY(equipmentName, quantity);
                }

                chartEquipmentIN.Series.Add(series);

                chartEquipmentIN.ChartAreas[0].AxisX.Title = "Equipment Name";
                chartEquipmentIN.ChartAreas[0].AxisY.Title = "Available Quantity";
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

        private void TypeRefreshClick(object sender, EventArgs e)
        {
            equipmenttypecmb.SelectedItem = null;
            EquipmentType_Filter(null, null);
        }

        private void ConditionRefresh_Click(object sender, EventArgs e)
        {
            equipmentconditioncmd.SelectedItem = null;
            EquipmentCondition_Filter(null, null);
        }

        private void EquipmentStatus_Filter(object sender, EventArgs e)
        {
            string selectedStatus = equipmentstatuscmd.SelectedItem?.ToString();

            string connectionString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                string query = "SELECT equipmentname, stockout_quantity FROM stockout_equipment " +
                 (selectedStatus != null ? $"WHERE equipment_status = '{selectedStatus}'" : "");
                MySqlCommand command = new MySqlCommand(query, connection);

                MySqlDataReader reader = command.ExecuteReader();

                chartEquipmentOUT.Series.Clear();

                Series series = new Series();
                series.Name = "Equipment";
                series.ChartType = SeriesChartType.Pie;
                series.BorderWidth = 1;
                series.Color = Color.Red;
                series.IsValueShownAsLabel = true;
                series.Font = new Font("Arial", 12, FontStyle.Bold);

                while (reader.Read())
                {
                    string equipmentStatus = reader.GetString("equipmentname");
                    int quantity = reader.GetInt32("stockout_quantity");

                    series.Points.AddXY(equipmentStatus, quantity);
                }

                chartEquipmentOUT.Series.Add(series);

                chartEquipmentOUT.ChartAreas[0].AxisX.Title = "Equipment Name";
                chartEquipmentOUT.ChartAreas[0].AxisY.Title = "Out Quantity";
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

        private void StatusRefresh_Click(object sender, EventArgs e)
        {
            equipmentstatuscmd.SelectedItem = null;
            EquipmentStatus_Filter(null, null);
        }
    }
}

