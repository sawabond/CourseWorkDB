using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkDB
{
    public partial class DessertsEditForm : Form
    {
        private int _articul;
        private string _manufacturer;
        public DessertsEditForm()
        {
            InitializeComponent();
        }
        public DessertsEditForm(int articul, string product_name, int net_weight,
                        int gross_weight, string manufacturer_name,
                        double wholesale_price, double retail_price,
                        string product_type, bool isForDiabetics, int rating 
                        ) : this()
        {
            mANUFACTURERSTableAdapter.Fill(cond_departmentDataSet.MANUFACTURERS);
            dESSERTSTableAdapter.Fill(cond_departmentDataSet.DESSERTS);

            Main.edit = true;
            _articul = articul;
            textBox_Articul.Text = Convert.ToString(articul);
            textBox_Name.Text = product_name;
            textBox_Netto.Text = net_weight.ToString();
            textBox_Brutto.Text = gross_weight.ToString();

            comboBox_Manufacturer.Text = manufacturer_name;
            _manufacturer = manufacturer_name;

            textBox_Wholesale.Text = wholesale_price.ToString();
            textBox_Price.Text = Convert.ToString(retail_price);
            textBox_Type.Text = product_type;
            comboBox_IsForDiabetics.Text = isForDiabetics ? "Так" : "Ні";
            comboBox_Rating.Text = Convert.ToString(rating);
        }

        private void DessertsEditForm_Load(object sender, EventArgs e)
        {
            // Подтягивает данные для отображения в comboBox_Manufacturer
            // с помощью тейбл адаптера филается соответственный датасет для отображения;
            // назначается датасорс комбобокса
            mANUFACTURERSTableAdapter.Fill(cond_departmentDataSet.MANUFACTURERS);
            comboBox_Manufacturer.DataSource = mANUFACTURERSBindingSource;
            comboBox_Manufacturer.Text = _manufacturer;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (Main.edit)
            {
                // Обновление дессертов
                try
                {
                    bool isForDiabetics = comboBox_IsForDiabetics.Text == "Так";
                    dESSERTSTableAdapter.UpdateQuery(
                    Convert.ToInt32(textBox_Articul.Text.Trim()),
                    textBox_Name.Text.Trim(),
                    Convert.ToInt32(textBox_Netto.Text.Trim()),
                    Convert.ToInt32(textBox_Brutto.Text.Trim()),
                    comboBox_Manufacturer.Text.Trim(),
                    Convert.ToInt32(textBox_Wholesale.Text.Trim()),
                    Convert.ToInt32(textBox_Price.Text.Trim()),
                    textBox_Type.Text.Trim(),
                    isForDiabetics,
                    Convert.ToInt32(comboBox_Rating.Text.Trim())
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            else
            {
                // Вставка нового дессерта
                try
                {
                    bool isForDiabetics = comboBox_IsForDiabetics.Text == "Так";
                    dESSERTSTableAdapter.InsertQuery(
                    Convert.ToInt32(textBox_Articul.Text.Trim()),
                    textBox_Name.Text.Trim(),
                    Convert.ToInt32(textBox_Netto.Text.Trim()),
                    Convert.ToInt32(textBox_Brutto.Text.Trim()),
                    comboBox_Manufacturer.Text.Trim(),
                    Convert.ToInt32(textBox_Wholesale.Text.Trim()),
                    Convert.ToInt32(textBox_Price.Text.Trim()),
                    textBox_Type.Text.Trim(),
                    isForDiabetics,
                    Convert.ToInt32(comboBox_Rating.Text.Trim())
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }

            }
            Close();
        }

        private void button_decline_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_Articul_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsDigit(number) == false)
                && (char.IsControl(number) == false))
            {
                e.Handled = true;
            }
        }

        private void textBox_Netto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsDigit(number) == false)
                && (char.IsControl(number) == false))
            {
                e.Handled = true;
            }
        }

        private void textBox_Brutto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsDigit(number) == false)
                && (char.IsControl(number) == false))
            {
                e.Handled = true;
            }
        }

        private void textBox_Wholesale_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsDigit(number) == false)
                && (char.IsControl(number) == false))
            {
                e.Handled = true;
            }
        }

        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsDigit(number) == false)
                && (char.IsControl(number) == false))
            {
                e.Handled = true;
            }
        }

        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsLetterOrDigit(number)
                || number == ' '
                || char.IsControl(number)) == false)
            {
                e.Handled = true;
            }
        }

        private void textBox_Type_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsLetter(number)
                || number == ' '
                || char.IsControl(number)) == false)
            {
                e.Handled = true;
            }
        }
    }
}
