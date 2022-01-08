using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CourseWorkDB
{
    class PdfTableReportSaver : IReportSaver
    {
        private readonly DataSet _dataSetToSave;
        private readonly SaveFileDialog _sfd;
        public PdfTableReportSaver(DataSet dgv, SaveFileDialog sfd)
        {
            _dataSetToSave = dgv;
            _sfd = sfd;
        }

        public void SaveReport()
        {
            Document doc = new Document();

            try
            {
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(_sfd.FileName, FileMode.Create));

                doc.Open();

                
                PdfPTable table = new PdfPTable(_dataSetToSave.Tables[0].Columns.Count);

                BaseFont baseFont = BaseFont.CreateFont("D:\\Reports\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

                PdfPCell cell = new PdfPCell(new Phrase($"Таблиця постачальники на " +
                    $"{DateTime.Now.ToString("d")}",font));

                cell.Colspan = _dataSetToSave.Tables[0].Columns.Count;
                cell.HorizontalAlignment = 1;
                //Убираем границу первой ячейки, чтобы балы как заголовок
                cell.Border = 0;
                table.AddCell(cell);

                //Сначала добавляем заголовки таблицы

                var dict = new Dictionary<string, string>();

                dict.Add("supplier_name", "Поставник");
                dict.Add("supplier_phone", "Номер телефону");
                dict.Add("supplier_adress", "Адреса");
                dict.Add("supplier_company", "Компанія");

                for (int j = 0; j < _dataSetToSave.Tables[0].Columns.Count; j++)
                {
                    cell = new PdfPCell(new Phrase(new Phrase(
                        dict[_dataSetToSave.Tables[0].Columns[j].ColumnName], font)));
                    //Фоновый цвет (необязательно, просто сделаем по красивее)
                    cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }

                //Добавляем все остальные ячейки
                for (int j = 0; j < _dataSetToSave.Tables[0].Rows.Count; j++)
                {
                    for (int k = 0; k < _dataSetToSave.Tables[0].Columns.Count; k++)
                    {
                        table.AddCell(new Phrase(_dataSetToSave.Tables[0].Rows[j][k].ToString(), font));
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
