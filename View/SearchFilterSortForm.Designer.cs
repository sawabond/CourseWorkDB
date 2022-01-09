namespace CourseWorkDB
{
    partial class SearchFilterSortForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_FPriceTo = new System.Windows.Forms.TextBox();
            this.textBox_FPriceFrom = new System.Windows.Forms.TextBox();
            this.label_TitleFiltering = new System.Windows.Forms.Label();
            this.label_FilterPrice = new System.Windows.Forms.Label();
            this.label_FilterName = new System.Windows.Forms.Label();
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.radioButton_Descending = new System.Windows.Forms.RadioButton();
            this.radioButton_Ascending = new System.Windows.Forms.RadioButton();
            this.button_Execute = new System.Windows.Forms.Button();
            this.comboBox_Sort = new System.Windows.Forms.ComboBox();
            this.label_Sort = new System.Windows.Forms.Label();
            this.cond_departmentDataSet = new CourseWorkDB.cond_departmentDataSet();
            this.dESSERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dESSERTSTableAdapter = new CourseWorkDB.cond_departmentDataSetTableAdapters.DESSERTSTableAdapter();
            this.label_Search = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FManufacturer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_WeightTo = new System.Windows.Forms.TextBox();
            this.textBox_WeightFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESSERTSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(210, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_FPriceTo
            // 
            this.textBox_FPriceTo.Location = new System.Drawing.Point(235, 142);
            this.textBox_FPriceTo.Name = "textBox_FPriceTo";
            this.textBox_FPriceTo.Size = new System.Drawing.Size(59, 22);
            this.textBox_FPriceTo.TabIndex = 51;
            this.textBox_FPriceTo.Text = "99999";
            this.textBox_FPriceTo.TextChanged += new System.EventHandler(this.textBox_FPriceTo_TextChanged);
            this.textBox_FPriceTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_FPriceTo_KeyPress);
            // 
            // textBox_FPriceFrom
            // 
            this.textBox_FPriceFrom.Location = new System.Drawing.Point(144, 142);
            this.textBox_FPriceFrom.Name = "textBox_FPriceFrom";
            this.textBox_FPriceFrom.Size = new System.Drawing.Size(60, 22);
            this.textBox_FPriceFrom.TabIndex = 50;
            this.textBox_FPriceFrom.Text = "0";
            this.textBox_FPriceFrom.TextChanged += new System.EventHandler(this.textBox_FPriceFrom_TextChanged);
            this.textBox_FPriceFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_FPriceFrom_KeyPress);
            // 
            // label_TitleFiltering
            // 
            this.label_TitleFiltering.AutoSize = true;
            this.label_TitleFiltering.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TitleFiltering.Location = new System.Drawing.Point(5, 113);
            this.label_TitleFiltering.Name = "label_TitleFiltering";
            this.label_TitleFiltering.Size = new System.Drawing.Size(164, 25);
            this.label_TitleFiltering.TabIndex = 49;
            this.label_TitleFiltering.Text = "Фільтрувати за:";
            this.label_TitleFiltering.Click += new System.EventHandler(this.label_TitleFiltering_Click);
            // 
            // label_FilterPrice
            // 
            this.label_FilterPrice.AutoSize = true;
            this.label_FilterPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FilterPrice.Location = new System.Drawing.Point(6, 138);
            this.label_FilterPrice.Name = "label_FilterPrice";
            this.label_FilterPrice.Size = new System.Drawing.Size(71, 25);
            this.label_FilterPrice.TabIndex = 48;
            this.label_FilterPrice.Text = "ціною:";
            this.label_FilterPrice.Click += new System.EventHandler(this.label_FilterPrice_Click);
            // 
            // label_FilterName
            // 
            this.label_FilterName.AutoSize = true;
            this.label_FilterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_FilterName.Location = new System.Drawing.Point(5, 42);
            this.label_FilterName.Name = "label_FilterName";
            this.label_FilterName.Size = new System.Drawing.Size(86, 25);
            this.label_FilterName.TabIndex = 47;
            this.label_FilterName.Text = "назвою:";
            // 
            // textBox_FName
            // 
            this.textBox_FName.Location = new System.Drawing.Point(143, 42);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.Size = new System.Drawing.Size(151, 22);
            this.textBox_FName.TabIndex = 46;
            // 
            // radioButton_Descending
            // 
            this.radioButton_Descending.AutoSize = true;
            this.radioButton_Descending.Checked = true;
            this.radioButton_Descending.Location = new System.Drawing.Point(116, 259);
            this.radioButton_Descending.Name = "radioButton_Descending";
            this.radioButton_Descending.Size = new System.Drawing.Size(94, 21);
            this.radioButton_Descending.TabIndex = 45;
            this.radioButton_Descending.TabStop = true;
            this.radioButton_Descending.Text = "Спадання";
            this.radioButton_Descending.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ascending
            // 
            this.radioButton_Ascending.AutoSize = true;
            this.radioButton_Ascending.Location = new System.Drawing.Point(10, 259);
            this.radioButton_Ascending.Name = "radioButton_Ascending";
            this.radioButton_Ascending.Size = new System.Drawing.Size(100, 21);
            this.radioButton_Ascending.TabIndex = 44;
            this.radioButton_Ascending.Text = "Зростання";
            this.radioButton_Ascending.UseVisualStyleBackColor = true;
            // 
            // button_Execute
            // 
            this.button_Execute.Location = new System.Drawing.Point(4, 286);
            this.button_Execute.Name = "button_Execute";
            this.button_Execute.Size = new System.Drawing.Size(290, 34);
            this.button_Execute.TabIndex = 43;
            this.button_Execute.Text = "Виконати";
            this.button_Execute.UseVisualStyleBackColor = true;
            this.button_Execute.Click += new System.EventHandler(this.button_Execute_Click);
            // 
            // comboBox_Sort
            // 
            this.comboBox_Sort.FormattingEnabled = true;
            this.comboBox_Sort.Items.AddRange(new object[] {
            "назва десерта",
            "ціна"});
            this.comboBox_Sort.Location = new System.Drawing.Point(10, 229);
            this.comboBox_Sort.Name = "comboBox_Sort";
            this.comboBox_Sort.Size = new System.Drawing.Size(194, 24);
            this.comboBox_Sort.TabIndex = 42;
            // 
            // label_Sort
            // 
            this.label_Sort.AutoSize = true;
            this.label_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sort.Location = new System.Drawing.Point(6, 201);
            this.label_Sort.Name = "label_Sort";
            this.label_Sort.Size = new System.Drawing.Size(168, 25);
            this.label_Sort.TabIndex = 41;
            this.label_Sort.Text = "Відсортувати за:";
            // 
            // cond_departmentDataSet
            // 
            this.cond_departmentDataSet.DataSetName = "cond_departmentDataSet";
            this.cond_departmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dESSERTSBindingSource
            // 
            this.dESSERTSBindingSource.DataMember = "DESSERTS";
            this.dESSERTSBindingSource.DataSource = this.cond_departmentDataSet;
            // 
            // dESSERTSTableAdapter
            // 
            this.dESSERTSTableAdapter.ClearBeforeFill = true;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search.Location = new System.Drawing.Point(5, 9);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(104, 25);
            this.label_Search.TabIndex = 54;
            this.label_Search.Text = "Пошук за:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "виробником:";
            // 
            // textBox_FManufacturer
            // 
            this.textBox_FManufacturer.Location = new System.Drawing.Point(143, 66);
            this.textBox_FManufacturer.Name = "textBox_FManufacturer";
            this.textBox_FManufacturer.Size = new System.Drawing.Size(151, 22);
            this.textBox_FManufacturer.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "-";
            // 
            // textBox_WeightTo
            // 
            this.textBox_WeightTo.Location = new System.Drawing.Point(234, 167);
            this.textBox_WeightTo.Name = "textBox_WeightTo";
            this.textBox_WeightTo.Size = new System.Drawing.Size(59, 22);
            this.textBox_WeightTo.TabIndex = 59;
            this.textBox_WeightTo.Text = "99999";
            this.textBox_WeightTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_WeightTo_KeyPress);
            // 
            // textBox_WeightFrom
            // 
            this.textBox_WeightFrom.Location = new System.Drawing.Point(143, 167);
            this.textBox_WeightFrom.Name = "textBox_WeightFrom";
            this.textBox_WeightFrom.Size = new System.Drawing.Size(60, 22);
            this.textBox_WeightFrom.TabIndex = 58;
            this.textBox_WeightFrom.Text = "0";
            this.textBox_WeightFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_WeightFrom_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 57;
            this.label4.Text = "вагою:";
            // 
            // SearchFilterSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_WeightTo);
            this.Controls.Add(this.textBox_WeightFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_FManufacturer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_FPriceTo);
            this.Controls.Add(this.textBox_FPriceFrom);
            this.Controls.Add(this.label_TitleFiltering);
            this.Controls.Add(this.label_FilterPrice);
            this.Controls.Add(this.label_FilterName);
            this.Controls.Add(this.textBox_FName);
            this.Controls.Add(this.radioButton_Descending);
            this.Controls.Add(this.radioButton_Ascending);
            this.Controls.Add(this.button_Execute);
            this.Controls.Add(this.comboBox_Sort);
            this.Controls.Add(this.label_Sort);
            this.Name = "SearchFilterSortForm";
            this.Text = "SearchFilterSortForm";
            this.Load += new System.EventHandler(this.SearchFilterSortForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESSERTSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_FPriceTo;
        private System.Windows.Forms.TextBox textBox_FPriceFrom;
        private System.Windows.Forms.Label label_TitleFiltering;
        private System.Windows.Forms.Label label_FilterPrice;
        private System.Windows.Forms.Label label_FilterName;
        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.RadioButton radioButton_Descending;
        private System.Windows.Forms.RadioButton radioButton_Ascending;
        private System.Windows.Forms.Button button_Execute;
        private System.Windows.Forms.ComboBox comboBox_Sort;
        private System.Windows.Forms.Label label_Sort;
        private cond_departmentDataSet cond_departmentDataSet;
        private System.Windows.Forms.BindingSource dESSERTSBindingSource;
        private cond_departmentDataSetTableAdapters.DESSERTSTableAdapter dESSERTSTableAdapter;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FManufacturer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_WeightTo;
        private System.Windows.Forms.TextBox textBox_WeightFrom;
        private System.Windows.Forms.Label label4;
    }
}