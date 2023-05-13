using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentBorrowReturn.Modules
{
    class EquipmentBorrowSelectModule
    {
        public static void EquipmentSelect(DataGridView equipmentDataGrid, TextBox equipmenttxt, TextBox equipmentnametxt, TextBox equipmentnumbertxt, TextBox equipmenttypetxt, TextBox equipmentquantitytxt, TextBox equipmentconditiontxt, TextBox equipmentadminidtxt, PictureBox equipmentPicture, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            // Get the selected row data
            DataGridViewRow row = equipmentDataGrid.Rows[rowIndex];
            string id = row.Cells["id"].Value.ToString();
            string equipmentName = row.Cells["equipmentname"].Value.ToString();
            string equipmentNumber = row.Cells["equipmentnumber"].Value.ToString();
            string equipmentType = row.Cells["equipmenttype"].Value.ToString();
            string equipmentQuantity = row.Cells["equipmentquantity"].Value.ToString();
            string equipmentCondition = row.Cells["equipmentcondition"].Value.ToString();
            string equipmentAdminID = row.Cells["admin_id"].Value.ToString();
            byte[] imageData = (byte[])equipmentDataGrid.CurrentRow.Cells["image"].Value;

            // Show the selected row data on the picture box and text box
            equipmenttxt.Text = id;
            equipmentnametxt.Text = equipmentName;
            equipmentnumbertxt.Text = equipmentNumber;
            equipmenttypetxt.Text = equipmentType;
            equipmentquantitytxt.Text = equipmentQuantity;
            equipmentconditiontxt.Text = equipmentCondition;
            equipmentadminidtxt.Text = equipmentAdminID;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                equipmentPicture.Image = Image.FromStream(ms);
            }

        }
    }
}
