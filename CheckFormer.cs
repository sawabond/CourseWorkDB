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

namespace CourseWorkDB
{
    public class CheckFormer
    {
        private string _checkText = String.Empty;
        private DataSet _checkDataSet = new DataSet();
        private SaveCheckForm _saveCheckForm;
        public CheckFormer(SaveCheckForm saveCheckForm)
        {
            _saveCheckForm = saveCheckForm;
        }
        public void LoadCheckInfo()
        {
            
        }
        public Check GetCheck(int id)
        {
            using (var conn = new SqlConnection(Main.CONNECTION_STRING))
            {
                conn.Open();
                var ds = new DataSet();

                var da = new SqlDataAdapter(
                    "SELECT DESSERTS.dessert_name, DESSERT_PURCHASE.dessert_amount, " +
                    "DESSERTS.wholesale_price * DESSERT_PURCHASE.dessert_amount summa, " +
                    "PURCHASE.purchase_adress, PURCHASE.purchase_type, PURCHASE.purchase_date " +
                    "FROM DESSERTS, DESSERT_PURCHASE, PURCHASE " +
                    "WHERE DESSERTS.articul = DESSERT_PURCHASE.articul AND " +
                    "PURCHASE.purchase_id = DESSERT_PURCHASE.purchase_id " +
                    $"AND PURCHASE.purchase_id = {id}", conn);

                da.Fill(ds);

                var purchaseDataGridView = _saveCheckForm.GetPurchaseDataGridView;

                purchaseDataGridView.DataSource = ds.Tables[0];
            }

            Check currentCheck = new Check();
            currentCheck.CollectValues(_saveCheckForm.GetPurchaseDataGridView, id);
            return currentCheck;
        }
        public struct Check
        {
            public int Id { get; set; }
            public string Adress { get; set; }
            public string PurchaseType { get; set; }
            public string Date { get; set; }
            public List<Dessert> Desserts { get; set; }
            public void CollectValues(DataGridView purchaseDataGridView, int id)
            {
                Id = id;
                Adress = purchaseDataGridView[3, 0].Value.ToString();
                PurchaseType = purchaseDataGridView[4, 0].Value.ToString();
                Date = purchaseDataGridView[5, 0].Value.ToString();
                Desserts = new List<Dessert>();
                for (int i = 0; i < purchaseDataGridView.Rows.Count - 1; i++)
                {
                    var dessert = new Dessert(
                            purchaseDataGridView[0, i].Value.ToString(),
                            purchaseDataGridView[1, i].Value.ToString(),
                            purchaseDataGridView[2, i].Value.ToString()
                            );
                    Desserts.Add(dessert);
                }
            }
            public struct Dessert
            {
                public string Name { get; set; }
                public string Amount { get; set; }
                public string Summ { get; set; }

                public Dessert(string name, string amount, string summ)
                {
                    Name = name;
                    Amount = amount;
                    Summ = summ;
                }
                public override string ToString()
                {
                    return $"{Name} Кількість: {Amount} Ціна: {Summ}^l";
                }
            }
        }
        public void SaveCheckToWord(int id)
        {
            var check = GetCheck(id);

            var wordApp = new Word.Application
            {
                Visible = false
            };
            try
            {
                var wordDocument = wordApp.Documents.Open(Path.GetFullPath(@"Checks\Application.docx"));
                ReplaceInWord("idCheck", $"{check.Id}", wordDocument);

                string dessertsString = String.Empty;
                foreach (Check.Dessert dessert in check.Desserts)
                {
                    dessertsString += $"{dessert.ToString()}";
                }

                ReplaceInWord("deserts", dessertsString, wordDocument);
                ReplaceInWord("payType", $"{check.PurchaseType}", wordDocument);
                ReplaceInWord("date", $"{check.Date}", wordDocument) ;
                ReplaceInWord("adress", $"{check.Adress}", wordDocument);
                //wordDocument.SaveAs(Path.GetFullPath($"Checks\\Чек {check.Id} {check.Date}.docx"));
                wordDocument.SaveAs(Path.GetFullPath($"Checks\\Чек_номер_{check.Id}.docx"));

                MessageBox.Show($"Чек збережений у Checks\\Чек_номер_{check.Id}.docx",
                    "Успішне збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                wordApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при збереженні файлу!\nМожливо цей чек вже був збережений раніше", "Помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                wordApp.Quit();
            }
        }
        protected void ReplaceInWord(string stub, string info, Word.Document document)
        {
            var symbolRange = document.Content;
            symbolRange.Find.ClearFormatting();
            symbolRange.Find.Execute(FindText: stub, ReplaceWith: info);
        }
    }
}
