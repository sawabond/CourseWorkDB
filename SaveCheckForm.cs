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
        private void SaveCheckForm_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(Main.CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter(
                "SELECT * FROM PURCHASE", conn);

                var ds = new DataSet();
                da.Fill(ds);

                dataGridViewAllPurchases.DataSource = ds?.Tables[0];
            }
        }

        private void dataGridViewPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewPurchase.Rows[e.RowIndex].Selected = true;
        }

        private void button_SaveCheck_Click(object sender, EventArgs e)
        {
            var checkFormer = new CheckFormer(this);
            checkFormer.SaveCheckToWord(_checkId);
        }

        private void dataGridViewAllPurchases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewAllPurchases.Rows[e.RowIndex].Selected = true;
        }

        private void button_СhooseCheck_Click(object sender, EventArgs e)
        {
            _checkId = Convert.ToInt32(
                dataGridViewAllPurchases[2, dataGridViewAllPurchases.SelectedRows[0].Index].Value);

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
                    $"AND PURCHASE.purchase_id = {_checkId}", conn);

                da.Fill(ds);

                var purchaseDataGridView = GetPurchaseDataGridView;

                purchaseDataGridView.DataSource = ds.Tables[0];
            }
        }
    }
}
