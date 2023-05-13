using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentBorrowReturn.Modules
{
    class ReturnedEquipmentGridSelectModule
    {
        public static void InformationSelect(DataGridView returnequipmentDataGrid, TextBox transactionidtxt, TextBox equipmentidtxt, TextBox quantitytxt, TextBox borroweridtxt, TextBox personnelidtxt, TextBox dateborrowedtxt, TextBox returnscheduletxt, TextBox datereturnedtxt, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            // Get the selected row data
            DataGridViewRow row = returnequipmentDataGrid.Rows[rowIndex];
            string transactionid = row.Cells["Column1"].Value.ToString();
            string equipmentid = row.Cells["Column2"].Value.ToString();
            string quantity = row.Cells["Column3"].Value.ToString();
            string borrowerid = row.Cells["Column4"].Value.ToString();
            string personnelid = row.Cells["Column5"].Value.ToString();
            string dateborrowed = row.Cells["Column6"].Value.ToString();
            string retrunschedule = row.Cells["Column7"].Value.ToString();
            string datereturned = row.Cells["Column8"].Value.ToString();


            // Show the selected row data on the picture box and text box
            transactionidtxt.Text = transactionid;
            equipmentidtxt.Text = equipmentid;
            quantitytxt.Text = quantity;
            borroweridtxt.Text = borrowerid;
            personnelidtxt.Text = personnelid;
            dateborrowedtxt.Text = dateborrowed;
            returnscheduletxt.Text = retrunschedule;
            datereturnedtxt.Text = datereturned;

        }
    }
}
