using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CourseWorkDB
{
    public partial class Main : Form
    {
        public static bool edit = true;
        public static readonly string CONNECTION_STRING = @"Data Source=DESKTOP-8OFU01P;Initial Catalog=cond_department;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static DataGridView S_dataGridViewMain;
        public enum DessertRows
        {
            articul = 3
        }
        public Main()
        {
            InitializeComponent();
            S_dataGridViewMain = dataGridViewMain;
        }
        public void UpdateMainDataGridViewSource(DataSet dataSet)
        {
            dataGridViewMain.DataSource = dataSet.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cond_departmentDataSet.MANUFACTURERS". При необходимости она может быть перемещена или удалена.
            //this.mANUFACTURERSTableAdapter.Fill(this.cond_departmentDataSet.MANUFACTURERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cond_departmentDataSet.DESSERTS". При необходимости она может быть перемещена или удалена.
            dESSERTSTableAdapter.Fill(cond_departmentDataSet.DESSERTS);
            mANUFACTURERSTableAdapter.Fill(cond_departmentDataSet.MANUFACTURERS);
        }

        private void виробникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter(@"SELECT [manufacturer_name] назва
      ,[head] голова
      ,[phone] телефон
      ,[adress] адреса
      ,[city] місто
  FROM [cond_department].[dbo].[MANUFACTURERS]", conn);
                var ds = new DataSet();
                da.Fill(ds);

                int index = 0;
                try
                {
                    index = dataGridViewMain.SelectedRows[0].Index;
                }
                catch (Exception) { }
                dataGridViewMain.DataSource = ds?.Tables[0];
                try
                {
                    dataGridViewMain.Rows[index].Selected = true;
                }
                catch (Exception) { }
            }
            //dataGridViewMain.Refresh();
        }

        private void десертиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDessertsDataGridView();
            //dataGridViewMain.Refresh();
        }
        private void UpdateDessertsDataGridView()
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter(@"SELECT [articul] артикул
      ,[dessert_name] назва
      ,[net_weight] маса_нетто
      ,[gross_weight] маса_брутто
      ,[manufacturer_name] виробник
      ,[wholesale_price] закупочна_ціна
      ,[retail_price] ціна_продажу
      ,[product_type] тип_десерту
      ,[is_for_diabetics] для_діабетиків
      ,[rating] рейтинг
      ,[dessert_amount] кількість
  FROM [cond_department].[dbo].[DESSERTS]", conn);
                var ds = new DataSet();
                da.Fill(ds);
                int index = 0;
                try
                {
                    index = dataGridViewMain.SelectedRows[0].Index;
                }
                catch (Exception) { }
                dataGridViewMain.DataSource = ds?.Tables[0];
                try
                {
                    dataGridViewMain.Rows[index].Selected = true;
                }
                catch (Exception) { }
            }
        }

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = false;
            var edt = new DessertsEditForm();
            edt.ShowDialog();

            dESSERTSTableAdapter.Fill(cond_departmentDataSet.DESSERTS);
            cond_departmentDataSet.AcceptChanges();
            UpdateDessertsDataGridView();
        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = true;
            try
            {
                var st = new cond_departmentDataSet.DESSERTSDataTable();
                dESSERTSTableAdapter.FillBy(st,
                    Convert.ToInt32(dataGridViewMain.SelectedRows[0].Cells[0].Value));

                object[] row = st.Rows[0].ItemArray;

                var isForDiabetics = (bool)row[8];

                var edt = new DessertsEditForm(
                    Convert.ToInt32(row[0]),
                    row[1].ToString(),
                    Convert.ToInt32(row[2]),
                    Convert.ToInt32(row[3]),
                    row[4].ToString(),
                    Convert.ToDouble(row[5]),
                    Convert.ToDouble(row[6]),
                    row[7].ToString(),
                    isForDiabetics,
                    Convert.ToInt32(row[9])
                    );

                edt.ShowDialog();
                dESSERTSTableAdapter.Fill(cond_departmentDataSet.DESSERTS);
                cond_departmentDataSet.AcceptChanges();
                UpdateDessertsDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: возможно выбрана только ячейка или не выбрано ничего " +
                                "Попробуйте выбрать строку полностью\n"
                                  + ex.Message);
            }
        }

        private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridViewMain.Rows[e.RowIndex].Selected = true;
            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }

        private void видалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Усі обрані записи будуть видалені, ви впевнені, що хочете видалити ці записи?",
                "Видалення записів", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridViewMain.SelectedRows)
                    {
                        int articul = Convert.ToInt32(row.Cells[0].Value);
                        dESSERTSTableAdapter.DeleteQuery(articul);
                    }
                    dESSERTSTableAdapter.Fill(cond_departmentDataSet.DESSERTS);
                    cond_departmentDataSet.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неможливо видалити дані, оскільки ці дані знаходяться в пов'язаних таблицях");
                }
            }
            UpdateDessertsDataGridView();
        }

        private void додатиВиробникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = false;
            var edt = new ManufacturersEditForm();
            edt.ShowDialog();

            mANUFACTURERSTableAdapter.Fill(cond_departmentDataSet.MANUFACTURERS);
            cond_departmentDataSet.AcceptChanges();
        }

        private void редагуватиВиробникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = true;
            try
            {
                var st = new cond_departmentDataSet.MANUFACTURERSDataTable();
                mANUFACTURERSTableAdapter.FillBy(st,
                    Convert.ToString(dataGridViewMain.SelectedRows[0].Cells[0].Value));

                object[] row = st.Rows[0].ItemArray;

                var edt = new ManufacturersEditForm(
                        Convert.ToString(row[0]),
                        Convert.ToString(row[1]),
                        Convert.ToString(row[2]),
                        Convert.ToString(row[3]),
                        Convert.ToString(row[4])
                    );

                edt.ShowDialog();
                mANUFACTURERSTableAdapter.Fill(cond_departmentDataSet.MANUFACTURERS);
                cond_departmentDataSet.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: возможно выбрана только ячейка или не выбрано ничего " +
                                "Попробуйте выбрать строку полностью\n"
                                  + ex.Message);
            }
        }

        private void видалитиВиробникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Усі обрані записи будуть видалені, ви впевнені, що хочете видалити ці записи?",
                "Видалення записів", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridViewMain.SelectedRows)
                    {
                        string manufacturerName = Convert.ToString(row.Cells[0].Value);
                        mANUFACTURERSTableAdapter.DeleteQuery(manufacturerName);
                    }
                    mANUFACTURERSTableAdapter.Fill(cond_departmentDataSet.MANUFACTURERS);
                    dESSERTSTableAdapter.Fill(cond_departmentDataSet.DESSERTS);
                    cond_departmentDataSet.AcceptChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неможливо видалити дані, оскільки ці дані знаходяться в пов'язаних таблицях");
                }
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
        }

        

        private void button_Filter_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter("SELECT * FROM DESSERTS", conn);
                var ds = new DataSet();
                da.Fill(ds);

                dataGridViewMain.DataSource = ds?.Tables[0];

                //(dataGridViewMain.DataSource as DataTable).DefaultView.RowFilter =
                //$"dessert_name LIKE '%{textBox_FName.Text}%' " +
                //$"AND retail_price > {textBox_FPriceFrom.Text} " +
                //$"AND retail_price < {textBox_FPriceTo.Text}";
            }
        }
        

        private void середняцінаДесертиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter("SELECT 'Середня ціна десертів' середня_ціна, AVG(wholesale_price) ціна FROM DESSERTS", conn);
                var ds = new DataSet();
                da.Fill(ds);

                dataGridViewMain.DataSource = ds?.Tables[0];
            }
        }

        private void модаВиробниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter("SELECT manufacturer_name виробник, COUNT(articul) частота " +
                "FROM DESSERTS " +
                "GROUP BY manufacturer_name " +
                "HAVING COUNT(articul) IN " +
                "(SELECT MAX(cnt) as MX " +
                "FROM(SELECT manufacturer_name, COUNT(articul) AS cnt " +
                "FROM DESSERTS " +
                "GROUP BY manufacturer_name) chastoti) ", conn);

                var ds = new DataSet();
                da.Fill(ds);

                dataGridViewMain.DataSource = ds?.Tables[0];
            }
        }

        private void рядРозподілуВиробниківЗаКількістюТоварівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter("SELECT manufacturer_name виробник, COUNT(articul) кількість_десертів " +
                    "FROM DESSERTS " +
                    "GROUP BY manufacturer_name", conn);
                var ds = new DataSet();
                da.Fill(ds);

                dataGridViewMain.DataSource = ds?.Tables[0];
            }
        }

        private void зберегтиЧекToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveCheckForm = new SaveCheckForm();
            saveCheckForm.ShowDialog();
        }

        private void отриматиРекомендацїіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var recommendationForm = new RecommendationsForm();
            recommendationForm.ShowDialog();
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

        private void пошукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var searchFilterSorForm = new SearchFilterSortForm(this);
            searchFilterSorForm.ShowDialog();
        }

        private void відхиленняВідСередньоїЦіниДесертівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter(
                "SELECT DESSERTS.articul артикул, DESSERTS.dessert_name назва, " +
                "DESSERTS.wholesale_price - average.average_price відхилення_від_середнього_значення, " +
                "average.average_price середня_ціна " +
                "FROM DESSERTS, (SELECT AVG(DESSERTS.wholesale_price) average_price FROM DESSERTS) average", conn);

                var ds = new DataSet();
                da.Fill(ds);

                dataGridViewMain.DataSource = ds?.Tables[0];
            }
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поставникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter("SELECT supplier_name поставник, " +
                    "supplier_phone номер_телефону, " +
                    "supplier_adress адреса_поставника, " +
                    "supplier_company компанія_поставника FROM SUPPLIER", conn);
                var ds = new DataSet();
                da.Fill(ds);

                dataGridViewMain.DataSource = ds?.Tables[0];
            }
        }

        private void menuStripMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter("SELECT  supply_id ідентифікатор, " +
                    "supply_date дата_поставки, " +
                    "articul артикул, " +
                    "supply_amount кількість_поставки, " +
                    "supplier_company назва_поставника  FROM SUPPLY", conn);
                var ds = new DataSet();
                da.Fill(ds);

                dataGridViewMain.DataSource = ds?.Tables[0];
            }
        }

        private void заказиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter("SELECT  purchase_id ідентифікатор, " +
                    "purchase_date дата_заказа, " +
                    "purchase_payment оплата_заказа, " +
                    "purchase_cost ціна_заказа, " +
                    "purchase_change здача_заказа, " +
                    "purchase_type тип_заказа, " +
                    "purchase_adress адреса_заказа FROM PURCHASE", conn);
                var ds = new DataSet();
                da.Fill(ds);

                dataGridViewMain.DataSource = ds?.Tables[0];
            }
        }

        private void заказиДесертівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(CONNECTION_STRING))
            {
                conn.Open();

                var da = new SqlDataAdapter("SELECT purchase_id ід_покупки, " +
                    "id ід_заказа, " +
                    "dessert_amount кількість_десертів, " +
                    "articul артикул FROM DESSERT_PURCHASE", conn);
                var ds = new DataSet();
                da.Fill(ds);

                dataGridViewMain.DataSource = ds?.Tables[0];
            }
        }

        private void створитиПоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addSupplyForm = new AddSupplyForm();
            addSupplyForm.ShowDialog();
        }

        private void покупкаТоваруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dessertPurchaseForm = new DessertPurchaseForm();
            dessertPurchaseForm.ShowDialog();
        }

        private void отриматиРекомендацїіToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var recommendationForm = new RecommendationsForm();
            recommendationForm.ShowDialog();
        }

        private void покупкаТоваруToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var purchaseForm = new DessertPurchaseForm();
            purchaseForm.ShowDialog();
        }

        private void зберегтиПоточніДаніToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var da = new SqlDataAdapter("SELECT * FROM SUPPLIER", new SqlConnection(CONNECTION_STRING));
            var ds = new DataSet();
            da.Fill(ds);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Pdf File |*.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var pdfTableReportSaver = new PdfTableReportSaver(ds, sfd);
                pdfTableReportSaver.SaveReport();
            }
        }
    }
}
