using Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace EquipmentBorrowReturn.Modules
{
    class ExportMicrosoftExcelModule
    {
        public static void ExportToExcel(DataGridView dataGridView)
        {
            // Create a new instance of Excel and make it visible
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;

            // Create a new workbook
            Excel.Workbook workbook = excel.Workbooks.Add(Missing.Value);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

            // Add the column headers to the worksheet
            int imageColumnIndex = -1;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (dataGridView.Columns[i].HeaderText != "Image")
                {
                    worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
                }
                else
                {
                    imageColumnIndex = i;
                    worksheet.Cells[1, imageColumnIndex + 1] = "          Image          ";
                    Range imageHeaderRange = worksheet.Cells[1, imageColumnIndex + 1] as Range;
                    imageHeaderRange.EntireColumn.ColumnWidth = 15; // set the width of the image column
                }
            }

            // Add the data to the worksheet
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (j != imageColumnIndex)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    else if (dataGridView.Rows[i].Cells[j].Value != null)
                    {
                        // Get the binary data of the image
                        byte[] imageData = (byte[])dataGridView.Rows[i].Cells[j].Value;

                        // Create a temporary file to save the image
                        string tempFilePath = Path.GetTempFileName();

                        // Write the binary data to the temporary file
                        using (FileStream fileStream = new FileStream(tempFilePath, FileMode.Create))
                        {
                            fileStream.Write(imageData, 0, imageData.Length);
                        }

                        // Insert the image into the worksheet
                        Excel.Pictures pictures = worksheet.Pictures(Missing.Value) as Excel.Pictures;
                        Excel.Picture picture = pictures.Insert(tempFilePath, Missing.Value) as Excel.Picture;

                        // Calculate the position and size of the image
                        int rowIndex = i + 2;
                        int columnIndex = imageColumnIndex + 1;
                        Range cell = worksheet.Cells[rowIndex, columnIndex] as Range;
                        picture.Left = cell.Left + 2;
                        picture.Top = cell.Top + 2;
                        picture.Width = cell.Width - 1;
                        picture.Height = cell.Height - 1;
                        picture.ShapeRange.LockAspectRatio = Microsoft.Office.Core.MsoTriState.msoFalse;
                        picture.ShapeRange.Width = 75; // set the width to 75
                        picture.ShapeRange.Height = 60;

                        // Delete the temporary file
                        File.Delete(tempFilePath);

                        // Adjust the row height of the current row to fit the image
                        Range rowRange = worksheet.Range[worksheet.Cells[rowIndex, 1], worksheet.Cells[rowIndex, dataGridView.Columns.Count]];
                        rowRange.RowHeight = 70;
                    }
                }
            }

            // Autofit the columns in the worksheet
            worksheet.Columns.AutoFit();
        }

    }
}
