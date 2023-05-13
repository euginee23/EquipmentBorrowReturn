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

namespace EquipmentBorrowReturn.Forms.AdminDashboard.Manage_Equipments
{
    public partial class EditEquipment : UserControl
    {
        public EditEquipment()
        {
            InitializeComponent();
        }

        private void Load_Equipment()
        {
            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                string query = "SELECT * FROM equipment_info";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable table = new DataTable();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                    equipmentinfoDataGrid.DataSource = table;
                }
            }
        }

        private void EditEquipment_Load(object sender, EventArgs e)
        {
            Load_Equipment();
            equipmentinfoDataGrid.RowTemplate.Height = 50;
            equipmentinfoDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void GetEquipmentInfoGridClick(object sender, DataGridViewCellEventArgs e)
        {
            EquipmentGridSelectModule.EquipmentSelect(equipmentinfoDataGrid, equipmentidtxt, equipmentnametxt, equipmentnumbertxt, equipmenttypetxt, equipmentquantitytxt, equipmentconditiontxt, equipmentadminidtxt, equipmentPicture, e);
        }

        private void removeequipmentbtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(equipmentidtxt.Text);
            bool success = DeleteEquipmentModule.DeleteEquipment(id);
            try
            {
                if (success)
                {
                    MessageBox.Show("Equipment record deleted successfully.");
                    Load_Equipment();
                }
                else
                {
                    MessageBox.Show("Failed to delete personnel record.");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void updateequipmentbtn_Click(object sender, EventArgs e)
        {
            string id = equipmentidtxt.Text;
            string equipmentname = equipmentnametxt.Text;
            string equipmentnumber = equipmentnumbertxt.Text;
            string equipmentquantity = equipmentquantitytxt.Text;
            string equipmenttype = equipmenttypetxt.Text;
            string equipmentcondition = equipmentconditiontxt.Text;
            string equipmentAdminID = equipmentadminidtxt.Text;


            byte[] imageData = null;

            bool isImageUpdated = updatepicCheck.Checked;
            if (isImageUpdated)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageData = File.ReadAllBytes(openFileDialog.FileName);
                }
            }

            UpdateEquipmentModule.UpdateEquipmentRecord(id, equipmentname, equipmentnumber, equipmentquantity, equipmenttype, equipmentcondition, equipmentAdminID, isImageUpdated, imageData);
            Load_Equipment();

        }
    }
}

