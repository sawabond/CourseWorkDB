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
    public partial class DessertPurchaseForm : Form
    {
        private int _currentPrice = 0;
        private int _purchaseSum = 0;
        private DataTable _purchaseDataTable = new DataTable();
        public DessertPurchaseForm()
        {
            InitializeComponent();
            LoadDessertsInfo();
            _purchaseDataTable.Columns.Add(new DataColumn("назва_товару"));
            _purchaseDataTable.Columns.Add(new DataColumn("кількість"));
            _purchaseDataTable.Columns.Add(new DataColumn("ціна"));
            _purchaseDataTable.Columns.Add(new DataColumn("артикул"));
            dataGridView1.DataSource = _purchaseDataTable;
        }

        public void LoadDessertsInfo()
        {
            using (var conn = new SqlConnection(Main.CONNECTION_STRING))
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(
                    @"SELECT TOP (1000) [articul]
      ,[dessert_name]
      ,[net_weight]
      ,[gross_weight]
      ,[manufacturer_name]
      ,[wholesale_price]
      ,[retail_price]
      ,[product_type]
      ,[is_for_diabetics]
      ,[rating]
      ,[dessert_amount]
  FROM [cond_department].[dbo].[DESSERTS]", conn);
                var ds = new DataSet();
                adapter.Fill(ds);
                dataGridViewDesserts.DataSource = ds.Tables[0];
            }
        }

        private void DessertPurchaseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cond_departmentDataSet1.DESSERTS". При необходимости она может быть перемещена или удалена.
            //this.dESSERTSTableAdapter.Fill(this.cond_departmentDataSet1.DESSERTS);

        }

        private void dataGridViewDesserts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewDesserts.Rows[e.RowIndex].Selected = true;

                var row = dataGridViewDesserts.SelectedRows[0].Cells;

                textBox_Name.Text = row["dessert_name"].Value.ToString();
                textBox_ValidAmount.Text = row["dessert_amount"].Value.ToString();
                textBox_Articul.Text = row["articul"].Value.ToString();
                _currentPrice = int.Parse(row["retail_price"].Value.ToString());

            }
            catch (Exception)
            {

            }
        }

        private void button_AddToCheck_Click(object sender, EventArgs e)
        {
            var dr = _purchaseDataTable.NewRow();
            try
            {
                dr["назва_товару"] = textBox_Name.Text;
                dr["кількість"] = textBox_BuyAmount.Text;
                dr["ціна"] = (int.Parse(textBox_BuyAmount.Text) *
                    int.Parse(dataGridViewDesserts.SelectedRows[0]?.Cells["retail_price"]?.Value?.ToString())).ToString() ?? "";
                _purchaseDataTable.Rows.Add(dr);
                dr["артикул"] = textBox_Articul.Text;

                _purchaseSum += _currentPrice * int.Parse(textBox_BuyAmount.Text);
                textBox_PurchaseSum.Text = _purchaseSum.ToString();

                dataGridViewDesserts.Rows.Remove(dataGridViewDesserts.SelectedRows[0]);
            }
            catch (Exception) { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Change.Text = (int.Parse(textBox_Income.Text) - int.Parse(textBox_PurchaseSum.Text)).ToString();

            using (var conn = new SqlConnection(Main.CONNECTION_STRING))
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                SqlCommand command = conn.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText = "SELECT MAX(purchase_id) FROM PURCHASE";
                    int purchase_id = (int)command.ExecuteScalar();

                    command.CommandText = $"INSERT INTO PURCHASE (purchase_cost, purchase_change, purchase_id, " +
                        $"purchase_payment, purchase_date, purchase_type, purchase_adress) " +
                        $"VALUES ({textBox_PurchaseSum.Text}, {textBox_Change.Text}, {purchase_id + 1}, {textBox_Income.Text}, " +
                        $"'{DateTime.Now.ToString("d")}', 'karta', 'this_adress')";
                    command.ExecuteNonQuery();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["артикул"].Value == null)
                        {
                            break;
                        }

                        command.CommandText = "INSERT INTO DESSERT_PURCHASE (articul, purchase_id, dessert_amount)" +
                            $"VALUES ({row.Cells["артикул"].Value}, {purchase_id}, {row.Cells["кількість"].Value})";
                        command.ExecuteNonQuery();

                        command.CommandText = "UPDATE DESSERTS " +
                            $"SET DESSERTS.dessert_amount = DESSERTS.dessert_amount - {row.Cells["кількість"].Value} " +
                            $"WHERE DESSERTS.articul = {row.Cells["артикул"].Value}";
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    MessageBox.Show("Покупка успішно здійснена");
                }
                catch (Exception ex)
                {
                    // rollback if we got exception
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private void checkBox_Card_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Card.Checked)
            {
                textBox_Income.Text = textBox_PurchaseSum.Text;
                textBox_Income.Enabled = false;
                return;
            }
            textBox_Income.Text = string.Empty;
            textBox_Income.Enabled = true;
        }
    }
}
