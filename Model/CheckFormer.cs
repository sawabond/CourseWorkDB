using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Microsoft.Office.Interop;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CourseWorkDB
{
    public class CheckFormer : IReportSaver
    {
        private string _checkText = String.Empty;
        private DataSet _checkDataSet = new DataSet();
        private SaveCheckForm _saveCheckForm;
        private SaveFileDialog _sfd;
        public CheckFormer(SaveCheckForm saveCheckForm, SaveFileDialog sfd)
        {
            _saveCheckForm = saveCheckForm;
            _sfd = sfd;
        }
        public void SaveReport()
        {
            Document doc = new Document();

            using (var conn = new SqlConnection(Main.CONNECTION_STRING))
            {
                conn.Open();
                var ds = new DataSet();

                string id = _saveCheckForm.GetAllPurchasesDataGridView.SelectedRows[0].Cells["айді"].Value.ToString();

                var da = new SqlDataAdapter(
                    "SELECT DESSERTS.dessert_name назва, DESSERT_PURCHASE.dessert_amount кількість, " +
                    "DESSERTS.wholesale_price * DESSERT_PURCHASE.dessert_amount сума, " +
                    "PURCHASE.purchase_adress адреса, PURCHASE.purchase_type тип_покупки " +
                    "FROM DESSERTS, DESSERT_PURCHASE, PURCHASE " +
                    "WHERE DESSERTS.articul = DESSERT_PURCHASE.articul AND " +
                    "PURCHASE.purchase_id = DESSERT_PURCHASE.purchase_id " +
                    $"AND PURCHASE.purchase_id = {id}", conn);

                da.Fill(ds);
                _checkDataSet = ds;
            }

            try
            {
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(_sfd.FileName, FileMode.Create));

                doc.Open();

                PdfPTable table = new PdfPTable(_checkDataSet.Tables[0].Columns.Count);

                BaseFont baseFont = BaseFont.CreateFont("Resources\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

                PdfPCell cell = new PdfPCell(new Phrase($"Чек від " +
                    $"{DateTime.Now.ToString("f")}", font));

                cell.Colspan = _checkDataSet.Tables[0].Columns.Count;
                cell.HorizontalAlignment = 1;
                //Убираем границу первой ячейки, чтобы балы как заголовок
                cell.Border = 0;
                table.AddCell(cell);

                //Сначала добавляем заголовки таблицы

                for (int j = 0; j < _checkDataSet.Tables[0].Columns.Count; j++)
                {
                    cell = new PdfPCell(new Phrase(new Phrase(
                        _checkDataSet.Tables[0].Columns[j].ColumnName, font)));
                    //Фоновый цвет (необязательно, просто сделаем по красивее)
                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }

                //Добавляем все остальные ячейки
                for (int j = 0; j < _checkDataSet.Tables[0].Rows.Count; j++)
                {
                    for (int k = 0; k < _checkDataSet.Tables[0].Columns.Count; k++)
                    {
                        table.AddCell(new Phrase(_checkDataSet.Tables[0].Rows[j][k].ToString(), font));
                    }
                }

                doc.Add(table);
                MessageBox.Show($"Документ був збережений у {_sfd.FileName}", "Успішне збереження",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }
    }
}
