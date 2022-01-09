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
    public partial class SearchFilterSortForm : Form
    {
        private Main _main;
        public SearchFilterSortForm(Main mainForm)
        {
            InitializeComponent();
            _main = mainForm;
        }

        private void SearchFilterSortForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cond_departmentDataSet.DESSERTS". При необходимости она может быть перемещена или удалена.
            this.dESSERTSTableAdapter.Fill(this.cond_departmentDataSet.DESSERTS);

        }

        private void button_Filter_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_FPriceFrom_TextChanged(object sender, EventArgs e)
        {
            if (textBox_FPriceFrom.Text == String.Empty)
                textBox_FPriceFrom.Text = "0";
        }

        private void textBox_FPriceTo_TextChanged(object sender, EventArgs e)
        {
            if (textBox_FPriceTo.Text == String.Empty)
                textBox_FPriceTo.Text = "99999";
        }

        private void label_TitleFiltering_Click(object sender, EventArgs e)
        {

        }

        private void label_FilterPrice_Click(object sender, EventArgs e)
        {

        }

        private void textBox_FPriceFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsDigit(number) == false)
                && (char.IsControl(number) == false))
            {
                e.Handled = true;
            }
        }

        private void textBox_FPriceTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsDigit(number) == false)
                && (char.IsControl(number) == false))
            {
                e.Handled = true;
            }
        }
        public DataSet FilteredDessertsDataSet { get; private set; } = new DataSet();
        private void button_Execute_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(Main.CONNECTION_STRING))
            {
                conn.Open();
                FilteredDessertsDataSet = new DataSet();

                var dict = new Dictionary<string, string>();
                dict.Add("назва десерта", "dessert_name");
                dict.Add("ціна", "retail_price");

                var da = new SqlDataAdapter("SELECT * FROM DESSERTS " +
                    $"WHERE " +
                    $"dessert_name LIKE '%{textBox_FName.Text}%' " +
                    $"AND manufacturer_name LIKE '%{textBox_FManufacturer.Text}%' " +
                    $"AND retail_price BETWEEN {textBox_FPriceFrom.Text} AND {textBox_FPriceTo.Text} " +
                    $"AND gross_weight BETWEEN {textBox_WeightFrom.Text} AND {textBox_WeightTo.Text} " +
                    $"ORDER BY {(string.IsNullOrEmpty(comboBox_Sort.Text) ? "dessert_name" : dict[comboBox_Sort.Text])} " + (radioButton_Descending.Checked ? "DESC" : String.Empty), conn);

                da.Fill(FilteredDessertsDataSet);
            }
            _main.UpdateMainDataGridViewSource(FilteredDessertsDataSet);
        }

        private void textBox_WeightFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsDigit(number) == false)
                && (char.IsControl(number) == false))
            {
                e.Handled = true;
            }
        }

        private void textBox_WeightTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsDigit(number) == false)
                && (char.IsControl(number) == false))
            {
                e.Handled = true;
            }
        }
    }
}
