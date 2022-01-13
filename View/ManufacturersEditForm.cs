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
    public partial class ManufacturersEditForm : Form
    {
        private readonly string _connectionString = @"Data Source=DESKTOP-8OFU01P;Initial Catalog=cond_department;Integrated Security=True";
        public ManufacturersEditForm()
        {
            InitializeComponent();
        }
        public ManufacturersEditForm(string manufacturerName, string headName,
            string phoneNumber, string adress, string city) : this()
        {
            textBox_HeadName.Text = headName;
            textBox_ManufacturerName.Text = manufacturerName;
            textBox_Phone.Text = phoneNumber;
            textBox_Adress.Text = adress;
            textBox_City.Text = city;
        }
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (Main.edit)
            {
                // Обновление производителей
                try
                {
                    using (var conn = new SqlConnection(_connectionString))
                    {
                        conn.Open();

                        string updateExpression =
                            $"UPDATE MANUFACTURERS SET " +
                            $"manufacturer_name = '{textBox_ManufacturerName.Text.Trim()}', " +
                            $"head = '{textBox_HeadName.Text.Trim()}', " +
                            $"phone = '{textBox_Phone.Text.Trim()}', " +
                            $"adress = '{textBox_Adress.Text.Trim()}', " +
                            $"city = '{textBox_City.Text.Trim()}' " +
                            $"WHERE manufacturer_name = '{textBox_ManufacturerName.Text.Trim()}'";

                        var command = new SqlCommand(updateExpression, conn);
                        command.ExecuteNonQuery();
                        mANUFACTURERSTableAdapter.Update(cond_departmentDataSet.MANUFACTURERS);

                        var da = new SqlDataAdapter(@"SELECT [manufacturer_name] назва
      ,[head] голова
      ,[phone] телефон
      ,[adress] адреса
      ,[city] місто
  FROM [cond_department].[dbo].[MANUFACTURERS]", conn);
                        var ds = new DataSet();
                        da.Fill(ds);
                        Main.S_dataGridViewMain.DataSource = ds.Tables[0];
                    }
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
                    mANUFACTURERSTableAdapter.InsertQuery(
                        textBox_ManufacturerName.Text.Trim(),
                        textBox_HeadName.Text.Trim(),
                        textBox_Phone.Text.Trim(),
                        textBox_Adress.Text.Trim(),
                        textBox_City.Text.Trim()
                    );

                    using (var conn = new SqlConnection(Main.CONNECTION_STRING))
                    {
                        var da = new SqlDataAdapter(@"SELECT [manufacturer_name] назва
      ,[head] голова
      ,[phone] телефон
      ,[adress] адреса
      ,[city] місто
  FROM [cond_department].[dbo].[MANUFACTURERS]", conn);
                        var ds = new DataSet();
                        da.Fill(ds);
                        Main.S_dataGridViewMain.DataSource = ds.Tables[0];
                    }
                    
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

        private void ManufacturersEditForm_Load(object sender, EventArgs e)
        {

        }
        private const int CHARCODE_BACKSPACE = 8;
        private void textBox_HeadName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsLetter(number)
                || number == ' '
                || char.IsControl(number)) == false)
            {
                e.Handled = true;
            }
        }

        private void textBox_ManufacturerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsLetterOrDigit(number)
                || number == ' '
                || char.IsControl(number)) == false)
            {
                e.Handled = true;
            }
        }

        private void textBox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsDigit(number) == false)
                && (char.IsControl(number) == false))
            {
                e.Handled = true;
            }
        }

        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Phone_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox_Adress_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsLetterOrDigit(number)
                || number == ' '
                || char.IsControl(number)) == false)
            {
                e.Handled = true;
            }
        }

        private void textBox_City_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((char.IsLetter(number)
                || number == ' '
                || number == '-'
                || char.IsControl(number)) == false)
            {
                e.Handled = true;
            }
        }
    }
}
