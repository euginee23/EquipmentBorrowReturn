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
    class BorrowerEditSelectModule
    {
        public static void BorrowerSelect(DataGridView borrowerinfoDataGrid, TextBox borroweridtxt, TextBox firstnametxt, TextBox middlenametxt, TextBox lastnametxt, TextBox addresstxt, TextBox contactnumbertxt, TextBox emailtxt, PictureBox borrowerPicture, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            // Get the selected row data
            DataGridViewRow row = borrowerinfoDataGrid.Rows[rowIndex];
            string id = row.Cells["Column1"].Value.ToString();
            string firstName = row.Cells["Column2"].Value.ToString();
            string middleName = row.Cells["Column3"].Value.ToString();
            string lastName = row.Cells["Column4"].Value.ToString();
            string address = row.Cells["Column5"].Value.ToString();
            string contactNumber = row.Cells["Column6"].Value.ToString();
            string email = row.Cells["Column7"].Value.ToString();
            byte[] imageData = (byte[])borrowerinfoDataGrid.CurrentRow.Cells["Column8"].Value;

            // Show the selected row data on the picture box and text box
            borroweridtxt.Text = id;
            firstnametxt.Text = firstName;
            middlenametxt.Text = middleName;
            lastnametxt.Text = lastName;
            addresstxt.Text = address;
            contactnumbertxt.Text = contactNumber;
            emailtxt.Text = email;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                borrowerPicture.Image = Image.FromStream(ms);
            }

        }
    }
}
