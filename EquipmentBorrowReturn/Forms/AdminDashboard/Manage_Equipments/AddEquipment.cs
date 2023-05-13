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
using EquipmentBorrowReturn.Models;
using EquipmentBorrowReturn.Modules;
using System.ComponentModel.DataAnnotations;

namespace EquipmentBorrowReturn.Forms.AdminDashboard.Manage_Equipments
{
    public partial class AddEquipment : UserControl
    {
        private int adminId;
        private string pictureLocation;

        public AddEquipment()
        {
            InitializeComponent();
            this.adminId = Admin.adminId;
            equipmentadminidtxt.Text = adminId.ToString();
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

        private void browsepicbtn_Click(object sender, EventArgs e)
        {
            pictureLocation = PictureBrowseModule.SelectPictureFile();

            if (pictureLocation != null)
            {
                equipmentPicture.ImageLocation = pictureLocation;
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            var Equipment_Model = new Equipment
            {
                EquipmentName = equipmentnametxt.Text,
                EquipmentNumber = equipmentnumbertxt.Text,
                EquipmentQuantity = equipmentquantitytxt.Text,
                EquipmentType = equipmenttypetxt.Text,
                EquipmentCondition = equipmentconditiontxt.Text,
                AdminID = equipmentadminidtxt.Text,
                EquipmentImage = null
            };

            ValidationContext context = new ValidationContext(Equipment_Model);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(Equipment_Model, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage} \n");
                MessageBox.Show(errorMsg.ToString(), "Validation Error");
                return;
            }

            else
            {
                AddEquipmentModule.InsertEquipment(Equipment_Model, pictureLocation);
                Load_Equipment();
            }
        }

        private void AddEquipment_Load(object sender, EventArgs e)
        {
            Load_Equipment();
            equipmentinfoDataGrid.RowTemplate.Height = 50;
            equipmentinfoDataGrid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void generatenumberbtn_Click(object sender, EventArgs e)
        {
            Random rndm = new Random();
            int random = rndm.Next(0, 9999999);
            equipmentnumbertxt.Text = random.ToString();
        }
    }
}
