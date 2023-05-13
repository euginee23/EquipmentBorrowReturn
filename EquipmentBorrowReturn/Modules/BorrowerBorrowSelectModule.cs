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
    class BorrowerBorrowSelectModule
    {
        public static void BorrowerSelect(DataGridView borrowerDataGrid, TextBox borrowertxt, TextBox borrowernametxt, TextBox addresstxt, TextBox emailtxt, TextBox contactnumbertxt, PictureBox borrowerPicture, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            // Get the selected row data
            DataGridViewRow row = borrowerDataGrid.Rows[rowIndex];
            string id = row.Cells["id"].Value.ToString();
            string borrowerFirstName = row.Cells["firstname"].Value.ToString();
            string borrowerMiddleName = row.Cells["middlename"].Value.ToString();
            string borrowerLastName = row.Cells["lastname"].Value.ToString();
            string borrowerAddress = row.Cells["address"].Value.ToString();
            string borrowerContactNumber = row.Cells["contactnumber"].Value.ToString();
            string borrowerEmail = row.Cells["email"].Value.ToString();
            byte[] imageData = (byte[])borrowerDataGrid.CurrentRow.Cells["image"].Value;

            // Show the selected row data on the picture box and text box
            borrowertxt.Text = id;
            borrowernametxt.Text = borrowerFirstName + " " + borrowerMiddleName + " " + borrowerLastName;
            addresstxt.Text = borrowerAddress;
            contactnumbertxt.Text = borrowerContactNumber;
            emailtxt.Text = borrowerEmail;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                borrowerPicture.Image = Image.FromStream(ms);
            }

        }
    }
}
