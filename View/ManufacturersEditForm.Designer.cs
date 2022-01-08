namespace CourseWorkDB
{
    partial class ManufacturersEditForm
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
            this.textBox_HeadName = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_ManufacturerName = new System.Windows.Forms.TextBox();
            this.label_CompanyName = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label_Phone = new System.Windows.Forms.Label();
            this.textBox_Adress = new System.Windows.Forms.TextBox();
            this.label_Adress = new System.Windows.Forms.Label();
            this.button_decline = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.label_City = new System.Windows.Forms.Label();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.cond_departmentDataSet = new CourseWorkDB.cond_departmentDataSet();
            this.mANUFACTURERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mANUFACTURERSTableAdapter = new CourseWorkDB.cond_departmentDataSetTableAdapters.MANUFACTURERSTableAdapter();
            this.dESSERTSTableAdapter = new CourseWorkDB.cond_departmentDataSetTableAdapters.DESSERTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANUFACTURERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_HeadName
            // 
            this.textBox_HeadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_HeadName.Location = new System.Drawing.Point(120, 6);
            this.textBox_HeadName.MaxLength = 50;
            this.textBox_HeadName.Name = "textBox_HeadName";
            this.textBox_HeadName.Size = new System.Drawing.Size(261, 30);
            this.textBox_HeadName.TabIndex = 30;
            this.textBox_HeadName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HeadName_KeyPress);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(3, 9);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(111, 25);
            this.label_Name.TabIndex = 29;
            this.label_Name.Text = "ПІБ голови";
            // 
            // textBox_ManufacturerName
            // 
            this.textBox_ManufacturerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ManufacturerName.Location = new System.Drawing.Point(120, 42);
            this.textBox_ManufacturerName.MaxLength = 50;
            this.textBox_ManufacturerName.Name = "textBox_ManufacturerName";
            this.textBox_ManufacturerName.Size = new System.Drawing.Size(261, 30);
            this.textBox_ManufacturerName.TabIndex = 32;
            this.textBox_ManufacturerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ManufacturerName_KeyPress);
            // 
            // label_CompanyName
            // 
            this.label_CompanyName.AutoSize = true;
            this.label_CompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CompanyName.Location = new System.Drawing.Point(15, 47);
            this.label_CompanyName.Name = "label_CompanyName";
            this.label_CompanyName.Size = new System.Drawing.Size(99, 25);
            this.label_CompanyName.TabIndex = 31;
            this.label_CompanyName.Text = "Компанія";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Phone.Location = new System.Drawing.Point(120, 80);
            this.textBox_Phone.MaxLength = 12;
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(261, 30);
            this.textBox_Phone.TabIndex = 33;
            this.textBox_Phone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_Phone_MouseClick);
            this.textBox_Phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Phone_KeyPress);
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Phone.Location = new System.Drawing.Point(15, 83);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(99, 25);
            this.label_Phone.TabIndex = 34;
            this.label_Phone.Text = "Телефон";
            // 
            // textBox_Adress
            // 
            this.textBox_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Adress.Location = new System.Drawing.Point(120, 116);
            this.textBox_Adress.MaxLength = 50;
            this.textBox_Adress.Name = "textBox_Adress";
            this.textBox_Adress.Size = new System.Drawing.Size(261, 30);
            this.textBox_Adress.TabIndex = 35;
            this.textBox_Adress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Adress_KeyPress);
            // 
            // label_Adress
            // 
            this.label_Adress.AutoSize = true;
            this.label_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Adress.Location = new System.Drawing.Point(35, 119);
            this.label_Adress.Name = "label_Adress";
            this.label_Adress.Size = new System.Drawing.Size(79, 25);
            this.label_Adress.TabIndex = 36;
            this.label_Adress.Text = "Адреса";
            // 
            // button_decline
            // 
            this.button_decline.Location = new System.Drawing.Point(196, 191);
            this.button_decline.Name = "button_decline";
            this.button_decline.Size = new System.Drawing.Size(181, 34);
            this.button_decline.TabIndex = 38;
            this.button_decline.Text = "Отмена";
            this.button_decline.UseVisualStyleBackColor = true;
            this.button_decline.Click += new System.EventHandler(this.button_decline_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(8, 191);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(177, 34);
            this.button_OK.TabIndex = 37;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_City.Location = new System.Drawing.Point(49, 155);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(65, 25);
            this.label_City.TabIndex = 40;
            this.label_City.Text = "Місто";
            // 
            // textBox_City
            // 
            this.textBox_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_City.Location = new System.Drawing.Point(120, 155);
            this.textBox_City.MaxLength = 50;
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(261, 30);
            this.textBox_City.TabIndex = 39;
            this.textBox_City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_City_KeyPress);
            // 
            // cond_departmentDataSet
            // 
            this.cond_departmentDataSet.DataSetName = "cond_departmentDataSet";
            this.cond_departmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mANUFACTURERSBindingSource
            // 
            this.mANUFACTURERSBindingSource.DataMember = "MANUFACTURERS";
            this.mANUFACTURERSBindingSource.DataSource = this.cond_departmentDataSet;
            // 
            // mANUFACTURERSTableAdapter
            // 
            this.mANUFACTURERSTableAdapter.ClearBeforeFill = true;
            // 
            // dESSERTSTableAdapter
            // 
            this.dESSERTSTableAdapter.ClearBeforeFill = true;
            // 
            // ManufacturersEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 241);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.button_decline);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_Adress);
            this.Controls.Add(this.textBox_Adress);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.textBox_ManufacturerName);
            this.Controls.Add(this.label_CompanyName);
            this.Controls.Add(this.textBox_HeadName);
            this.Controls.Add(this.label_Name);
            this.Name = "ManufacturersEditForm";
            this.Text = "ManufacturersEditForm";
            this.Load += new System.EventHandler(this.ManufacturersEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANUFACTURERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_HeadName;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_ManufacturerName;
        private System.Windows.Forms.Label label_CompanyName;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.TextBox textBox_Adress;
        private System.Windows.Forms.Label label_Adress;
        private System.Windows.Forms.Button button_decline;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.TextBox textBox_City;
        private cond_departmentDataSet cond_departmentDataSet;
        private System.Windows.Forms.BindingSource mANUFACTURERSBindingSource;
        private cond_departmentDataSetTableAdapters.MANUFACTURERSTableAdapter mANUFACTURERSTableAdapter;
        private cond_departmentDataSetTableAdapters.DESSERTSTableAdapter dESSERTSTableAdapter;
    }
}