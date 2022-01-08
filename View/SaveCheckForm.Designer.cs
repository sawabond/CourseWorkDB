namespace CourseWorkDB
{
    partial class SaveCheckForm
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
            this.dataGridViewPurchase = new System.Windows.Forms.DataGridView();
            this.button_SaveCheck = new System.Windows.Forms.Button();
            this.dataGridViewAllPurchases = new System.Windows.Forms.DataGridView();
            this.label_CuurentCheckInfo = new System.Windows.Forms.Label();
            this.label_AllChecks = new System.Windows.Forms.Label();
            this.button_СhooseCheck = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPurchase
            // 
            this.dataGridViewPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchase.Location = new System.Drawing.Point(572, 109);
            this.dataGridViewPurchase.Name = "dataGridViewPurchase";
            this.dataGridViewPurchase.RowHeadersWidth = 51;
            this.dataGridViewPurchase.RowTemplate.Height = 24;
            this.dataGridViewPurchase.Size = new System.Drawing.Size(697, 250);
            this.dataGridViewPurchase.TabIndex = 0;
            this.dataGridViewPurchase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPurchase_CellClick);
            // 
            // button_SaveCheck
            // 
            this.button_SaveCheck.Location = new System.Drawing.Point(1088, 365);
            this.button_SaveCheck.Name = "button_SaveCheck";
            this.button_SaveCheck.Size = new System.Drawing.Size(181, 37);
            this.button_SaveCheck.TabIndex = 1;
            this.button_SaveCheck.Text = "Зберегти чек";
            this.button_SaveCheck.UseVisualStyleBackColor = true;
            this.button_SaveCheck.Click += new System.EventHandler(this.button_SaveCheck_Click);
            // 
            // dataGridViewAllPurchases
            // 
            this.dataGridViewAllPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllPurchases.Location = new System.Drawing.Point(12, 109);
            this.dataGridViewAllPurchases.Name = "dataGridViewAllPurchases";
            this.dataGridViewAllPurchases.RowHeadersWidth = 51;
            this.dataGridViewAllPurchases.RowTemplate.Height = 24;
            this.dataGridViewAllPurchases.Size = new System.Drawing.Size(551, 247);
            this.dataGridViewAllPurchases.TabIndex = 2;
            this.dataGridViewAllPurchases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllPurchases_CellClick);
            // 
            // label_CuurentCheckInfo
            // 
            this.label_CuurentCheckInfo.AutoSize = true;
            this.label_CuurentCheckInfo.Location = new System.Drawing.Point(569, 89);
            this.label_CuurentCheckInfo.Name = "label_CuurentCheckInfo";
            this.label_CuurentCheckInfo.Size = new System.Drawing.Size(100, 17);
            this.label_CuurentCheckInfo.TabIndex = 3;
            this.label_CuurentCheckInfo.Text = "Поточний чек";
            // 
            // label_AllChecks
            // 
            this.label_AllChecks.AutoSize = true;
            this.label_AllChecks.Location = new System.Drawing.Point(9, 89);
            this.label_AllChecks.Name = "label_AllChecks";
            this.label_AllChecks.Size = new System.Drawing.Size(62, 17);
            this.label_AllChecks.TabIndex = 4;
            this.label_AllChecks.Text = "Усі чеки";
            // 
            // button_СhooseCheck
            // 
            this.button_СhooseCheck.Location = new System.Drawing.Point(382, 365);
            this.button_СhooseCheck.Name = "button_СhooseCheck";
            this.button_СhooseCheck.Size = new System.Drawing.Size(181, 37);
            this.button_СhooseCheck.TabIndex = 5;
            this.button_СhooseCheck.Text = "Обрати чек";
            this.button_СhooseCheck.UseVisualStyleBackColor = true;
            this.button_СhooseCheck.Click += new System.EventHandler(this.button_СhooseCheck_Click);
            // 
            // SaveCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 450);
            this.Controls.Add(this.button_СhooseCheck);
            this.Controls.Add(this.label_AllChecks);
            this.Controls.Add(this.label_CuurentCheckInfo);
            this.Controls.Add(this.dataGridViewAllPurchases);
            this.Controls.Add(this.button_SaveCheck);
            this.Controls.Add(this.dataGridViewPurchase);
            this.Name = "SaveCheckForm";
            this.Text = "SaveCheckForm";
            this.Load += new System.EventHandler(this.SaveCheckForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllPurchases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPurchase;
        private System.Windows.Forms.Button button_SaveCheck;
        private System.Windows.Forms.DataGridView dataGridViewAllPurchases;
        private System.Windows.Forms.Label label_CuurentCheckInfo;
        private System.Windows.Forms.Label label_AllChecks;
        private System.Windows.Forms.Button button_СhooseCheck;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}