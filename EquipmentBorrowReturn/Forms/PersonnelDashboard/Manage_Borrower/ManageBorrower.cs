using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EquipmentBorrowReturn.Forms.PersonnelDashboard.Manage_Borrower;

namespace EquipmentBorrowReturn.Forms.PersonnelDashboard
{
    public partial class ManageBorrower : UserControl
    {
        public ManageBorrower()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            manageborrowerpanelcontainer.Controls.Clear();
            manageborrowerpanelcontainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addequipmentpanel_Click(object sender, EventArgs e)
        {
            AddBorrower addborrower = new AddBorrower();
            addUserControl(addborrower);
        }

        private void editequipmentpanel_Click(object sender, EventArgs e)
        {
            EditBorrower editborrower = new EditBorrower();
            addUserControl(editborrower);
        }
    }
}
