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
    class EquipmentGridSelectModule
    {
        public static void EquipmentSelect(DataGridView equipmentinfoDataGrid, TextBox equipmentidtxt, TextBox equipmentnametxt, TextBox equipmentnumbertxt, ComboBox equipmenttypetxt, TextBox equipmentquantitytxt, ComboBox equipmentconditiontxt, TextBox equipmentadminidtxt, PictureBox equipmentPicture, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            // Get the selected row data
            DataGridViewRow row = equipmentinfoDataGrid.Rows[rowIndex];
            string id = row.Cells["Column1"].Value.ToString();
            string equipmentName = row.Cells["Column2"].Value.ToString();
            string equipmentNumber = row.Cells["Column3"].Value.ToString();
            string equipmentType = row.Cells["Column4"].Value.ToString();
            string equipmentQuantity = row.Cells["Column5"].Value.ToString();
            string equipmentCondition = row.Cells["Column6"].Value.ToString();
            string equipmentAdminID = row.Cells["Column7"].Value.ToString();
            byte[] imageData = (byte[])equipmentinfoDataGrid.CurrentRow.Cells["Column8"].Value;

            // Show the selected row data on the picture box and text box
            equipmentidtxt.Text = id;
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
