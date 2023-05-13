using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace EquipmentBorrowReturn.Modules
{
    class ExportMicrosoftWordModule
    {
        public static void ExportToWord(DataGridView dataGridView, string headerText, string footerText, float leftMargin = 0.5f, float rightMargin = 0.5f, float topMargin = 0.5f, float bottomMargin = 0.5f)
        {
            
            // Create a new instance of Word and make it visible
            Word.Application word = new Word.Application();
            word.Visible = true;
            word.ShowMe();
            // Create a new document
            Word.Document document = word.Documents.Add();

            // Add a header to the document
            Word.Range headerRange = document.Sections[1].Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
            headerRange.Text = headerText;
            headerRange.Font.Name = "Arial";
            headerRange.Font.Size = 14;
            headerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            // Add a footer to the document
            Word.Range footerRange = document.Sections[1].Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
            footerRange.Text = footerText;
            footerRange.Font.Name = "Arial";
            footerRange.Font.Size = 10;
            footerRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            // Add a table to the document
            int rowCount = dataGridView.Rows.Count;
            int columnCount = dataGridView.Columns.Count - 1;
            Word.Table table = document.Tables.Add(document.Range(0, 0), rowCount + 1, columnCount);

            // Add border to table and cells
            table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            table.Borders.InsideLineWidth = Word.WdLineWidth.wdLineWidth050pt;
            table.Borders.OutsideLineWidth = Word.WdLineWidth.wdLineWidth050pt;

            //Margins
            document.PageSetup.LeftMargin = word.InchesToPoints(leftMargin);
            document.PageSetup.RightMargin = word.InchesToPoints(rightMargin);
            document.PageSetup.TopMargin = word.InchesToPoints(topMargin);
            document.PageSetup.BottomMargin = word.InchesToPoints(bottomMargin);

            // Add the column headers to the table
            int imageColumnIndex = -1;
            for (int j = 0; j < columnCount; j++)
            {
                if (dataGridView.Columns[j].HeaderText != "Image")
                {
                    table.Cell(1, j + 1).Range.Text = dataGridView.Columns[j].HeaderText;
                }
                else
                {
                    imageColumnIndex = j;
                    table.Cell(1, j + 1).Range.Text = "Image";
                    table.Columns[j + 1].Width = 75; // set the width of the image column
                }
            }

            // Add the data to the table
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (j != imageColumnIndex)
                    {
                        table.Cell(i + 2, j + 1).Range.Text = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    else if (dataGridView.Rows[i].Cells[j].Value != null)
                    {
                        // Get the binary data of the image
                        byte[] imageData = (byte[])dataGridView.Rows[i].Cells[j].Value;

                        // Save the binary data as a temporary file
                        string imagePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".png");
                        File.WriteAllBytes(imagePath, imageData);

                        // Add the image to the table
                        Word.Range range = table.Cell(i + 2, j + 1).Range;
                        range.InlineShapes.AddPicture(imagePath);
                        range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

                        // Delete the temporary file
                        File.Delete(imagePath);
                    }
                }
            }

            // Autofit the columns
            table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);
        }
    }
}
