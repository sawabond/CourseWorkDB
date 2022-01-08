using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CourseWorkDB
{
    public partial class AddSupplyForm : Form
    {
        public AddSupplyForm()
        {
            InitializeComponent();
            FillCalculatedInfo();
        }

        public void FillCalculatedInfo()
        {
            using (var conn = new SqlConnection(Main.CONNECTION_STRING))
            {
                conn.Open();

                var command = new SqlCommand("SELECT MAX(supply_id) FROM SUPPLY", conn);
                int number = ((int)command.ExecuteScalar()) + 1;
                textBox_Supply_id.Text = number.ToString();

                textBox_Supply_date.Text = DateTime.Now.ToString("d");
            }
        }

        private void AddSupplyForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cond_departmentDataSet1.SUPPLIER". При необходимости она может быть перемещена или удалена.
            this.sUPPLIERTableAdapter.Fill(this.cond_departmentDataSet1.SUPPLIER);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cond_departmentDataSet.DESSERTS". При необходимости она может быть перемещена или удалена.
            this.dESSERTSTableAdapter.Fill(this.cond_departmentDataSet.DESSERTS);

        }
        private void AddSupplyTransaction()
        {
            var supplyId = int.Parse(textBox_Supply_id.Text);
            var articul = int.Parse(comboBox_Articul.Text);
            var supplierCompany = comboBox_Company.Text;
            var amount = int.Parse(textBox_Amount.Text);
            var dateOfSupply = textBox_Supply_date.Text;

            using (var conn = new SqlConnection(Main.CONNECTION_STRING))
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                SqlCommand command = conn.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    // execute two separate queries
                    command.CommandText = "UPDATE DESSERTS SET DESSERTS.dessert_amount" +
                        $" = Desserts.dessert_amount + {amount} " +
                        $"WHERE Desserts.articul = {articul}";
                    command.ExecuteNonQuery();
                    command.CommandText = "INSERT INTO SUPPLY (supply_id, supply_date, articul, supply_amount, supplier_company) " +
                        $"VALUES({supplyId}, '{dateOfSupply}', {articul}, {amount}, '{supplierCompany}')";
                    command.ExecuteNonQuery();

                    // commit transaction
                    transaction.Commit();
                    MessageBox.Show("Поставка успішно додана! Кількість товарів оновлена");
                }
                catch (Exception)
                {
                    // rollback if we got exception
                    MessageBox.Show("Виникла помилка під час додавання поставки. Перевірте коректність даних");
                    transaction.Rollback();
                }
            }
            
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            AddSupplyTransaction();
        }

        private void button_decline_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
