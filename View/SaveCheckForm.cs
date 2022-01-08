using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkDB
{
    public partial class SaveCheckForm : Form
    {
        private int _checkId = 1;
        public string SelectedPath { get; set; }
        public SaveCheckForm()
        {
            InitializeComponent();
        }
        public DataGridView GetPurchaseDataGridView { get => dataGridViewPurchase; }
        public DataGridView GetAllPurchasesDataGridView { get => dataGridViewAllPurchases; }
        private void SaveCheckForm_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(Main.CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter(
                @"SELECT [purchase_cost] вартість
      ,[purchase_change] решта
      ,[purchase_id] айді,[purchase_payment] внесена_сума
      ,[purchase_date] дата_покупки
      ,[purchase_type] тип_покупки
      ,[purchase_adress] адреса
  FROM [cond_department].[dbo].[PURCHASE]", conn);

                var ds = new DataSet();
                da.Fill(ds);

                dataGridViewAllPurchases.DataSource = ds?.Tables[0];
            }
        }

        private void dataGridViewPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewPurchase.Rows[e.RowIndex].Selected = true;
            }
            catch { }
        }

        private void button_SaveCheck_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pdf File |*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var checkFormer = new CheckFormer(this, sfd);
                checkFormer.SaveReport();
            }
        }

        private void dataGridViewAllPurchases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewAllPurchases.Rows[e.RowIndex].Selected = true;
            }
            catch { }
        }

        private void button_СhooseCheck_Click(object sender, EventArgs e)
        {
            try
            {
                _checkId = Convert.ToInt32(
                    dataGridViewAllPurchases[2, dataGridViewAllPurchases.SelectedRows[0].Index].Value);
            }
            catch { }

            using (var conn = new SqlConnection(Main.CONNECTION_STRING))
            {
                conn.Open();
                var ds = new DataSet();

                var da = new SqlDataAdapter(
                    "SELECT DESSERTS.dessert_name назва, DESSERT_PURCHASE.dessert_amount кількість, " +
                    "DESSERTS.wholesale_price * DESSERT_PURCHASE.dessert_amount сума, " +
                    "PURCHASE.purchase_adress адреса, PURCHASE.purchase_type тип_покупки, PURCHASE.purchase_date дата_покупки " +
                    "FROM DESSERTS, DESSERT_PURCHASE, PURCHASE " +
                    "WHERE DESSERTS.articul = DESSERT_PURCHASE.articul AND " +
                    "PURCHASE.purchase_id = DESSERT_PURCHASE.purchase_id " +
                    $"AND PURCHASE.purchase_id = {_checkId}", conn);

                da.Fill(ds);

                var purchaseDataGridView = GetPurchaseDataGridView;

                purchaseDataGridView.DataSource = ds.Tables[0];
            }
        }
    }
}
