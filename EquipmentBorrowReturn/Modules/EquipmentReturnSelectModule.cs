using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentBorrowReturn.Modules
{
    class EquipmentReturnSelectModule
    {
        public static void EquipmentReturnSelect(DataGridView returnequipmentDataGrid, TextBox transactionID, TextBox equipmenttxt, TextBox quantitytxt, TextBox borrowertxt, TextBox personneltxt, TextBox dateborrowedtxt, TextBox scheduletxt, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            // Get the selected row data
            DataGridViewRow row = returnequipmentDataGrid.Rows[rowIndex];
            string id = row.Cells["Column1"].Value.ToString();
            string equipmentid = row.Cells["Column2"].Value.ToString();
            string quantity = row.Cells["Column3"].Value.ToString();
            string borrowerid = row.Cells["Column4"].Value.ToString();
            string personnelid = row.Cells["Column5"].Value.ToString();
            string dateBorrowed = row.Cells["Column6"].Value.ToString();
            string dateReturned = row.Cells["Column7"].Value.ToString();

            // Show the selected row data on the picture box and text box
            transactionID.Text = id;
            equipmenttxt.Text = equipmentid;
            quantitytxt.Text = quantity;
            borrowertxt.Text = borrowerid;
            personneltxt.Text = personnelid;
            dateborrowedtxt.Text = dateBorrowed;
            scheduletxt.Text = dateReturned;
            

        }
    }
}
