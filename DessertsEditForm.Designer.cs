namespace CourseWorkDB
{
    partial class DessertsEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_Wholesale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Brutto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Netto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_decline = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_Articul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_IsForDiabetics = new System.Windows.Forms.ComboBox();
            this.comboBox_Manufacturer = new System.Windows.Forms.ComboBox();
            this.mANUFACTURERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cond_departmentDataSet = new CourseWorkDB.cond_departmentDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox_Rating = new System.Windows.Forms.ComboBox();
            this.mANUFACTURERSTableAdapter = new CourseWorkDB.cond_departmentDataSetTableAdapters.MANUFACTURERSTableAdapter();
            this.dESSERTSTableAdapter = new CourseWorkDB.cond_departmentDataSetTableAdapters.DESSERTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mANUFACTURERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Wholesale
            // 
            this.textBox_Wholesale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Wholesale.Location = new System.Drawing.Point(200, 239);
            this.textBox_Wholesale.MaxLength = 5;
            this.textBox_Wholesale.Name = "textBox_Wholesale";
            this.textBox_Wholesale.Size = new System.Drawing.Size(181, 30);
            this.textBox_Wholesale.TabIndex = 39;
            this.textBox_Wholesale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Wholesale_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Ціна закупки";
            // 
            // textBox_Type
            // 
            this.textBox_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Type.Location = new System.Drawing.Point(200, 318);
            this.textBox_Type.MaxLength = 50;
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(181, 30);
            this.textBox_Type.TabIndex = 37;
            this.textBox_Type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Type_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 36;
            this.label8.Text = "Вид продукту";
            // 
            // textBox_Brutto
            // 
            this.textBox_Brutto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Brutto.Location = new System.Drawing.Point(200, 150);
            this.textBox_Brutto.MaxLength = 5;
            this.textBox_Brutto.Name = "textBox_Brutto";
            this.textBox_Brutto.Size = new System.Drawing.Size(181, 30);
            this.textBox_Brutto.TabIndex = 33;
            this.textBox_Brutto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Brutto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Маса брутто";
            // 
            // textBox_Netto
            // 
            this.textBox_Netto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Netto.Location = new System.Drawing.Point(200, 109);
            this.textBox_Netto.MaxLength = 5;
            this.textBox_Netto.Name = "textBox_Netto";
            this.textBox_Netto.Size = new System.Drawing.Size(181, 30);
            this.textBox_Netto.TabIndex = 31;
            this.textBox_Netto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Netto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Маса нетто";
            // 
            // button_decline
            // 
            this.button_decline.Location = new System.Drawing.Point(200, 479);
            this.button_decline.Name = "button_decline";
            this.button_decline.Size = new System.Drawing.Size(181, 34);
            this.button_decline.TabIndex = 29;
            this.button_decline.Text = "Отмена";
            this.button_decline.UseVisualStyleBackColor = true;
            this.button_decline.Click += new System.EventHandler(this.button_decline_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(12, 479);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(177, 34);
            this.button_OK.TabIndex = 28;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_Articul
            // 
            this.textBox_Articul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Articul.Location = new System.Drawing.Point(200, 22);
            this.textBox_Articul.MaxLength = 10;
            this.textBox_Articul.Name = "textBox_Articul";
            this.textBox_Articul.Size = new System.Drawing.Size(181, 30);
            this.textBox_Articul.TabIndex = 27;
            this.textBox_Articul.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Articul_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Артикул";
            // 
            // textBox_Price
            // 
            this.textBox_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Price.Location = new System.Drawing.Point(200, 275);
            this.textBox_Price.MaxLength = 5;
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(181, 30);
            this.textBox_Price.TabIndex = 24;
            this.textBox_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Price_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Виробник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ціна продажу";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Name.Location = new System.Drawing.Point(200, 64);
            this.textBox_Name.MaxLength = 50;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(181, 30);
            this.textBox_Name.TabIndex = 21;
            this.textBox_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Назва десерта";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 365);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 25);
            this.label10.TabIndex = 40;
            this.label10.Text = "Для діабетиків";
            // 
            // comboBox_IsForDiabetics
            // 
            this.comboBox_IsForDiabetics.AutoCompleteCustomSource.AddRange(new string[] {
            "Так",
            "Ні"});
            this.comboBox_IsForDiabetics.DisplayMember = "manufacturer_name";
            this.comboBox_IsForDiabetics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_IsForDiabetics.FormattingEnabled = true;
            this.comboBox_IsForDiabetics.Items.AddRange(new object[] {
            "Так",
            "Ні"});
            this.comboBox_IsForDiabetics.Location = new System.Drawing.Point(200, 362);
            this.comboBox_IsForDiabetics.Name = "comboBox_IsForDiabetics";
            this.comboBox_IsForDiabetics.Size = new System.Drawing.Size(181, 33);
            this.comboBox_IsForDiabetics.TabIndex = 41;
            this.comboBox_IsForDiabetics.Text = "Ні";
            this.comboBox_IsForDiabetics.ValueMember = "manufacturer_name";
            // 
            // comboBox_Manufacturer
            // 
            this.comboBox_Manufacturer.AutoCompleteCustomSource.AddRange(new string[] {
            "Так",
            "Ні"});
            this.comboBox_Manufacturer.DataSource = this.mANUFACTURERSBindingSource;
            this.comboBox_Manufacturer.DisplayMember = "manufacturer_name";
            this.comboBox_Manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Manufacturer.FormattingEnabled = true;
            this.comboBox_Manufacturer.Location = new System.Drawing.Point(200, 199);
            this.comboBox_Manufacturer.Name = "comboBox_Manufacturer";
            this.comboBox_Manufacturer.Size = new System.Drawing.Size(181, 33);
            this.comboBox_Manufacturer.TabIndex = 42;
            this.comboBox_Manufacturer.ValueMember = "manufacturer_name";
            // 
            // mANUFACTURERSBindingSource
            // 
            this.mANUFACTURERSBindingSource.DataMember = "MANUFACTURERS";
            this.mANUFACTURERSBindingSource.DataSource = this.cond_departmentDataSet;
            // 
            // cond_departmentDataSet
            // 
            this.cond_departmentDataSet.DataSetName = "cond_departmentDataSet";
            this.cond_departmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 43;
            this.label11.Text = "Рейтинг";
            // 
            // comboBox_Rating
            // 
            this.comboBox_Rating.AutoCompleteCustomSource.AddRange(new string[] {
            "Так",
            "Ні"});
            this.comboBox_Rating.DisplayMember = "manufacturer_name";
            this.comboBox_Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Rating.FormattingEnabled = true;
            this.comboBox_Rating.Items.AddRange(new object[] {
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.comboBox_Rating.Location = new System.Drawing.Point(200, 404);
            this.comboBox_Rating.Name = "comboBox_Rating";
            this.comboBox_Rating.Size = new System.Drawing.Size(181, 33);
            this.comboBox_Rating.TabIndex = 44;
            this.comboBox_Rating.Text = "5";
            this.comboBox_Rating.ValueMember = "manufacturer_name";
            // 
            // mANUFACTURERSTableAdapter
            // 
            this.mANUFACTURERSTableAdapter.ClearBeforeFill = true;
            // 
            // dESSERTSTableAdapter
            // 
            this.dESSERTSTableAdapter.ClearBeforeFill = true;
            // 
            // DessertsEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 560);
            this.Controls.Add(this.comboBox_Rating);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox_Manufacturer);
            this.Controls.Add(this.comboBox_IsForDiabetics);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_Wholesale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Brutto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Netto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_decline);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_Articul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Name = "DessertsEditForm";
            this.Text = "DessertsEditForm";
            this.Load += new System.EventHandler(this.DessertsEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mANUFACTURERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Wholesale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Brutto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Netto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_decline;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_Articul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.ComboBox comboBox_IsForDiabetics;
        private cond_departmentDataSet cond_departmentDataSet;
        private System.Windows.Forms.BindingSource mANUFACTURERSBindingSource;
        private cond_departmentDataSetTableAdapters.MANUFACTURERSTableAdapter mANUFACTURERSTableAdapter;
        public System.Windows.Forms.ComboBox comboBox_Manufacturer;
        private cond_departmentDataSetTableAdapters.DESSERTSTableAdapter dESSERTSTableAdapter;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox comboBox_Rating;
    }
}