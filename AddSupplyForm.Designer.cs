namespace CourseWorkDB
{
    partial class AddSupplyForm
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
            this.comboBox_Articul = new System.Windows.Forms.ComboBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_decline = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.textBox_Supply_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Supply_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Company = new System.Windows.Forms.ComboBox();
            this.cond_departmentDataSet = new CourseWorkDB.cond_departmentDataSet();
            this.dESSERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dESSERTSTableAdapter = new CourseWorkDB.cond_departmentDataSetTableAdapters.DESSERTSTableAdapter();
            this.cond_departmentDataSet1 = new CourseWorkDB.cond_departmentDataSet1();
            this.sUPPLIERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUPPLIERTableAdapter = new CourseWorkDB.cond_departmentDataSet1TableAdapters.SUPPLIERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESSERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Articul
            // 
            this.comboBox_Articul.AutoCompleteCustomSource.AddRange(new string[] {
            "Так",
            "Ні"});
            this.comboBox_Articul.DataSource = this.dESSERTSBindingSource;
            this.comboBox_Articul.DisplayMember = "articul";
            this.comboBox_Articul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Articul.FormattingEnabled = true;
            this.comboBox_Articul.Location = new System.Drawing.Point(361, 117);
            this.comboBox_Articul.Name = "comboBox_Articul";
            this.comboBox_Articul.Size = new System.Drawing.Size(181, 33);
            this.comboBox_Articul.TabIndex = 64;
            this.comboBox_Articul.ValueMember = "articul";
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Amount.Location = new System.Drawing.Point(361, 198);
            this.textBox_Amount.MaxLength = 5;
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(181, 30);
            this.textBox_Amount.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(164, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Кількість продукту";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(260, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Артикул";
            // 
            // button_decline
            // 
            this.button_decline.Location = new System.Drawing.Point(361, 244);
            this.button_decline.Name = "button_decline";
            this.button_decline.Size = new System.Drawing.Size(181, 34);
            this.button_decline.TabIndex = 53;
            this.button_decline.Text = "Отмена";
            this.button_decline.UseVisualStyleBackColor = true;
            this.button_decline.Click += new System.EventHandler(this.button_decline_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(173, 244);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(177, 34);
            this.button_OK.TabIndex = 52;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // textBox_Supply_id
            // 
            this.textBox_Supply_id.Enabled = false;
            this.textBox_Supply_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Supply_id.Location = new System.Drawing.Point(361, 28);
            this.textBox_Supply_id.MaxLength = 10;
            this.textBox_Supply_id.Name = "textBox_Supply_id";
            this.textBox_Supply_id.Size = new System.Drawing.Size(181, 30);
            this.textBox_Supply_id.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(232, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Id поставки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(145, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 25);
            this.label3.TabIndex = 48;
            this.label3.Text = "Компанія поставника";
            // 
            // textBox_Supply_date
            // 
            this.textBox_Supply_date.Enabled = false;
            this.textBox_Supply_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Supply_date.Location = new System.Drawing.Point(361, 70);
            this.textBox_Supply_date.MaxLength = 50;
            this.textBox_Supply_date.Name = "textBox_Supply_date";
            this.textBox_Supply_date.Size = new System.Drawing.Size(181, 30);
            this.textBox_Supply_date.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(199, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Дата поставки";
            // 
            // comboBox_Company
            // 
            this.comboBox_Company.AutoCompleteCustomSource.AddRange(new string[] {
            "Так",
            "Ні"});
            this.comboBox_Company.DataSource = this.sUPPLIERBindingSource;
            this.comboBox_Company.DisplayMember = "supplier_company";
            this.comboBox_Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Company.FormattingEnabled = true;
            this.comboBox_Company.Location = new System.Drawing.Point(361, 159);
            this.comboBox_Company.Name = "comboBox_Company";
            this.comboBox_Company.Size = new System.Drawing.Size(181, 33);
            this.comboBox_Company.TabIndex = 65;
            this.comboBox_Company.ValueMember = "supplier_company";
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
            // cond_departmentDataSet1
            // 
            this.cond_departmentDataSet1.DataSetName = "cond_departmentDataSet1";
            this.cond_departmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sUPPLIERBindingSource
            // 
            this.sUPPLIERBindingSource.DataMember = "SUPPLIER";
            this.sUPPLIERBindingSource.DataSource = this.cond_departmentDataSet1;
            // 
            // sUPPLIERTableAdapter
            // 
            this.sUPPLIERTableAdapter.ClearBeforeFill = true;
            // 
            // AddSupplyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.comboBox_Company);
            this.Controls.Add(this.comboBox_Articul);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_decline);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_Supply_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Supply_date);
            this.Controls.Add(this.label1);
            this.Name = "AddSupplyForm";
            this.Text = "AddSupplyForm";
            this.Load += new System.EventHandler(this.AddSupplyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESSERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUPPLIERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox comboBox_Articul;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_decline;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_Supply_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Supply_date;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox_Company;
        private cond_departmentDataSet cond_departmentDataSet;
        private System.Windows.Forms.BindingSource dESSERTSBindingSource;
        private cond_departmentDataSetTableAdapters.DESSERTSTableAdapter dESSERTSTableAdapter;
        private cond_departmentDataSet1 cond_departmentDataSet1;
        private System.Windows.Forms.BindingSource sUPPLIERBindingSource;
        private cond_departmentDataSet1TableAdapters.SUPPLIERTableAdapter sUPPLIERTableAdapter;
    }
}