namespace CourseWorkDB
{
    partial class DessertPurchaseForm
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
            this.dataGridViewDesserts = new System.Windows.Forms.DataGridView();
            this.dESSERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cond_departmentDataSet1 = new CourseWorkDB.cond_departmentDataSet1();
            this.conddepartmentDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dESSERTSTableAdapter = new CourseWorkDB.cond_departmentDataSet1TableAdapters.DESSERTSTableAdapter();
            this.labelPurchase = new System.Windows.Forms.Label();
            this.button_AddToCheck = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_ValidAmount = new System.Windows.Forms.Label();
            this.label_AmountToBuy = new System.Windows.Forms.Label();
            this.textBox_BuyAmount = new System.Windows.Forms.TextBox();
            this.textBox_ValidAmount = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Income = new System.Windows.Forms.TextBox();
            this.textBox_Change = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_PurchaseSum = new System.Windows.Forms.TextBox();
            this.label_Articul = new System.Windows.Forms.Label();
            this.textBox_Articul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_Card = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesserts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESSERTSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conddepartmentDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDesserts
            // 
            this.dataGridViewDesserts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDesserts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDesserts.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDesserts.Name = "dataGridViewDesserts";
            this.dataGridViewDesserts.RowHeadersWidth = 51;
            this.dataGridViewDesserts.RowTemplate.Height = 24;
            this.dataGridViewDesserts.Size = new System.Drawing.Size(1143, 196);
            this.dataGridViewDesserts.TabIndex = 0;
            this.dataGridViewDesserts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDesserts_CellClick);
            // 
            // dESSERTSBindingSource
            // 
            this.dESSERTSBindingSource.DataMember = "DESSERTS";
            this.dESSERTSBindingSource.DataSource = this.cond_departmentDataSet1;
            // 
            // cond_departmentDataSet1
            // 
            this.cond_departmentDataSet1.DataSetName = "cond_departmentDataSet1";
            this.cond_departmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // conddepartmentDataSet1BindingSource
            // 
            this.conddepartmentDataSet1BindingSource.DataSource = this.cond_departmentDataSet1;
            this.conddepartmentDataSet1BindingSource.Position = 0;
            // 
            // dESSERTSTableAdapter
            // 
            this.dESSERTSTableAdapter.ClearBeforeFill = true;
            // 
            // labelPurchase
            // 
            this.labelPurchase.AutoSize = true;
            this.labelPurchase.Location = new System.Drawing.Point(12, 215);
            this.labelPurchase.Name = "labelPurchase";
            this.labelPurchase.Size = new System.Drawing.Size(122, 17);
            this.labelPurchase.TabIndex = 1;
            this.labelPurchase.Text = "Поточна покупка";
            // 
            // button_AddToCheck
            // 
            this.button_AddToCheck.Location = new System.Drawing.Point(622, 379);
            this.button_AddToCheck.Name = "button_AddToCheck";
            this.button_AddToCheck.Size = new System.Drawing.Size(177, 34);
            this.button_AddToCheck.TabIndex = 38;
            this.button_AddToCheck.Text = "Додати";
            this.button_AddToCheck.UseVisualStyleBackColor = true;
            this.button_AddToCheck.Click += new System.EventHandler(this.button_AddToCheck_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(672, 235);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(66, 25);
            this.label_Name.TabIndex = 39;
            this.label_Name.Text = "Назва";
            // 
            // label_ValidAmount
            // 
            this.label_ValidAmount.AutoSize = true;
            this.label_ValidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ValidAmount.Location = new System.Drawing.Point(550, 267);
            this.label_ValidAmount.Name = "label_ValidAmount";
            this.label_ValidAmount.Size = new System.Drawing.Size(190, 25);
            this.label_ValidAmount.TabIndex = 40;
            this.label_ValidAmount.Text = "Доступна кількість";
            // 
            // label_AmountToBuy
            // 
            this.label_AmountToBuy.AutoSize = true;
            this.label_AmountToBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AmountToBuy.Location = new System.Drawing.Point(564, 335);
            this.label_AmountToBuy.Name = "label_AmountToBuy";
            this.label_AmountToBuy.Size = new System.Drawing.Size(174, 25);
            this.label_AmountToBuy.TabIndex = 41;
            this.label_AmountToBuy.Text = "Кількість покупки";
            // 
            // textBox_BuyAmount
            // 
            this.textBox_BuyAmount.Location = new System.Drawing.Point(744, 335);
            this.textBox_BuyAmount.Name = "textBox_BuyAmount";
            this.textBox_BuyAmount.Size = new System.Drawing.Size(100, 22);
            this.textBox_BuyAmount.TabIndex = 42;
            // 
            // textBox_ValidAmount
            // 
            this.textBox_ValidAmount.Enabled = false;
            this.textBox_ValidAmount.Location = new System.Drawing.Point(744, 270);
            this.textBox_ValidAmount.Name = "textBox_ValidAmount";
            this.textBox_ValidAmount.Size = new System.Drawing.Size(100, 22);
            this.textBox_ValidAmount.TabIndex = 43;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Enabled = false;
            this.textBox_Name.Location = new System.Drawing.Point(744, 235);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Name.TabIndex = 44;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(532, 150);
            this.dataGridView1.TabIndex = 45;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 34);
            this.button1.TabIndex = 46;
            this.button1.Text = "Здійснити покупку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "Внесена сума";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(78, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Решта";
            // 
            // textBox_Income
            // 
            this.textBox_Income.Location = new System.Drawing.Point(157, 392);
            this.textBox_Income.Name = "textBox_Income";
            this.textBox_Income.Size = new System.Drawing.Size(100, 22);
            this.textBox_Income.TabIndex = 49;
            // 
            // textBox_Change
            // 
            this.textBox_Change.Enabled = false;
            this.textBox_Change.Location = new System.Drawing.Point(157, 417);
            this.textBox_Change.Name = "textBox_Change";
            this.textBox_Change.Size = new System.Drawing.Size(100, 22);
            this.textBox_Change.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(263, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Сума покупки";
            // 
            // textBox_PurchaseSum
            // 
            this.textBox_PurchaseSum.Enabled = false;
            this.textBox_PurchaseSum.Location = new System.Drawing.Point(408, 395);
            this.textBox_PurchaseSum.Name = "textBox_PurchaseSum";
            this.textBox_PurchaseSum.Size = new System.Drawing.Size(100, 22);
            this.textBox_PurchaseSum.TabIndex = 52;
            this.textBox_PurchaseSum.TextChanged += new System.EventHandler(this.textBox_PurchaseSum_TextChanged);
            // 
            // label_Articul
            // 
            this.label_Articul.AutoSize = true;
            this.label_Articul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Articul.Location = new System.Drawing.Point(564, 301);
            this.label_Articul.Name = "label_Articul";
            this.label_Articul.Size = new System.Drawing.Size(174, 25);
            this.label_Articul.TabIndex = 53;
            this.label_Articul.Text = "Кількість покупки";
            // 
            // textBox_Articul
            // 
            this.textBox_Articul.Enabled = false;
            this.textBox_Articul.Location = new System.Drawing.Point(744, 301);
            this.textBox_Articul.Name = "textBox_Articul";
            this.textBox_Articul.Size = new System.Drawing.Size(100, 22);
            this.textBox_Articul.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(263, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Оплата картою";
            // 
            // checkBox_Card
            // 
            this.checkBox_Card.AutoSize = true;
            this.checkBox_Card.Location = new System.Drawing.Point(425, 423);
            this.checkBox_Card.Name = "checkBox_Card";
            this.checkBox_Card.Size = new System.Drawing.Size(18, 17);
            this.checkBox_Card.TabIndex = 56;
            this.checkBox_Card.UseVisualStyleBackColor = true;
            this.checkBox_Card.CheckedChanged += new System.EventHandler(this.checkBox_Card_CheckedChanged);
            // 
            // DessertPurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 569);
            this.Controls.Add(this.checkBox_Card);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Articul);
            this.Controls.Add(this.label_Articul);
            this.Controls.Add(this.textBox_PurchaseSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Change);
            this.Controls.Add(this.textBox_Income);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_ValidAmount);
            this.Controls.Add(this.textBox_BuyAmount);
            this.Controls.Add(this.label_AmountToBuy);
            this.Controls.Add(this.label_ValidAmount);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_AddToCheck);
            this.Controls.Add(this.labelPurchase);
            this.Controls.Add(this.dataGridViewDesserts);
            this.Name = "DessertPurchaseForm";
            this.Text = "DessertPurchaseForm";
            this.Load += new System.EventHandler(this.DessertPurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDesserts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESSERTSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conddepartmentDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDesserts;
        private System.Windows.Forms.BindingSource conddepartmentDataSet1BindingSource;
        private cond_departmentDataSet1 cond_departmentDataSet1;
        private System.Windows.Forms.BindingSource dESSERTSBindingSource;
        private cond_departmentDataSet1TableAdapters.DESSERTSTableAdapter dESSERTSTableAdapter;
        private System.Windows.Forms.Label labelPurchase;
        private System.Windows.Forms.Button button_AddToCheck;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_ValidAmount;
        private System.Windows.Forms.Label label_AmountToBuy;
        private System.Windows.Forms.TextBox textBox_BuyAmount;
        private System.Windows.Forms.TextBox textBox_ValidAmount;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Income;
        private System.Windows.Forms.TextBox textBox_Change;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_PurchaseSum;
        private System.Windows.Forms.Label label_Articul;
        private System.Windows.Forms.TextBox textBox_Articul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Card;
    }
}