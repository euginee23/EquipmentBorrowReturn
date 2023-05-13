using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentBorrowReturn.Forms.AdminDashboard.Manage_Personnels
{
    public partial class ManagePersonnel : UserControl
    {
        public ManagePersonnel()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            managepersonnelpanelcontainer.Controls.Clear();
            managepersonnelpanelcontainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void addpersonnelpanelbtn_Click(object sender, EventArgs e)
        {
            AddPersonnel addPersonnel = new AddPersonnel();
            addUserControl(addPersonnel);
        }

        private void editequipmentpanelbtn_Click(object sender, EventArgs e)
        {
            EditPersonnel editPersonnel = new EditPersonnel();
            addUserControl(editPersonnel);
        }
    }
}
