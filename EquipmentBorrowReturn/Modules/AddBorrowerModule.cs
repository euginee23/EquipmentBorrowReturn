using EquipmentBorrowReturn.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentBorrowReturn.Modules
{
    class AddBorrowerModule
    {
        public static void InsertBorrower(Borrower borrower, string pictureLocation)
        {
            byte[] images = null;
            FileStream strm = new FileStream(pictureLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(strm);
            images = brs.ReadBytes((int)strm.Length);

            string conString = "Server=localhost;Database=equipmentborrowreturn;Uid=root;Pwd=";
            string query = "INSERT INTO borrower_info(firstname, middlename, lastname, address, contactnumber, email, image)" +
                           "VALUES (@FirstName, @MiddleName, @LastName, @Address, @ContactNumber, @Email, @Image)";

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FirstName", borrower.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", borrower.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", borrower.LastName);
                cmd.Parameters.AddWithValue("@Address", borrower.Address);
                cmd.Parameters.AddWithValue("@ContactNumber", borrower.ContactNumber);
                cmd.Parameters.AddWithValue("@Email", borrower.Email);
                cmd.Parameters.AddWithValue("@Image", images);

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Borrower Added Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Borrower not added, Please Try Again.");
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

                finally
                {
                    con.Close();
                }
            }
        }
    }
}
