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
using System.ComponentModel.DataAnnotations;
using EquipmentBorrowReturn.Forms.AdminDashboard.Manage_Equipments;

namespace EquipmentBorrowReturn
{
    public partial class Manage : UserControl
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            managepanelcontainer.Controls.Clear();
            managepanelcontainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addequipmentpanel_Click(object sender, EventArgs e)
        {
            AddEquipment addEquipment = new AddEquipment();
            addUserControl(addEquipment);
        }

        private void editequipmentpanel_Click(object sender, EventArgs e)
        {
            EditEquipment editEquipment = new EditEquipment();
            addUserControl(editEquipment);
        }
    }
}
