using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace CourseWorkDB
{
    public partial class RecommendationsForm : Form
    {
        public DataGridView dgMostPopularDesserts { get => dataGridViewMostPopularDesserts; }
        private string receiverName;
        public RecommendationsForm()
        {
            InitializeComponent();
        }

        private void RecommendationsForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_Date_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            var at = new AutomationTask(this);

            if ((new EmailAddressAttribute()).IsValid(textBox1.Text))
            {
                at.ReceiverName = textBox1.Text;
                at.PerformAutomation();
                MessageBox.Show("Рекомендації були відправлені на вказану пошту", "Рекомендації відправлені",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                return;
            }
            MessageBox.Show("Перевірте коректність даних", "Помилка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
