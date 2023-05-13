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
    class PersonnelDataGridSelectModule
    {
        public static void PersonnelSelect(DataGridView personnelinfoDataGrid, TextBox personnelidtxt, TextBox firstnametxt, TextBox middlenametxt, TextBox lastnametxt, TextBox addresstxt, ComboBox coursetxt, ComboBox yearleveltxt, TextBox usernametxt, TextBox passwordtxt, PictureBox personnelPicture, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0) return;

            // Get the selected row data
            DataGridViewRow row = personnelinfoDataGrid.Rows[rowIndex];
            string id = row.Cells["Column1"].Value.ToString();
            string firstName = row.Cells["Column2"].Value.ToString();
            string middleName = row.Cells["Column3"].Value.ToString();
            string lastName = row.Cells["Column4"].Value.ToString();
            string address = row.Cells["Column5"].Value.ToString();
            string course = row.Cells["Column6"].Value.ToString();
            string yearLevel = row.Cells["Column7"].Value.ToString();
            string username = row.Cells["Column8"].Value.ToString();
            string password = row.Cells["Column9"].Value.ToString();
            byte[] imageData = (byte[])personnelinfoDataGrid.CurrentRow.Cells[9].Value;

            // Show the selected row data on the picture box and text box
            personnelidtxt.Text = id;
            firstnametxt.Text = firstName;
            middlenametxt.Text = middleName;
            lastnametxt.Text = lastName;
            addresstxt.Text = address;
            coursetxt.Text = course;
            yearleveltxt.Text = yearLevel;
            usernametxt.Text = username;
            passwordtxt.Text = password;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                personnelPicture.Image = Image.FromStream(ms);
            }

        }
    }
}
