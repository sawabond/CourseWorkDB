namespace CourseWorkDB
{
    partial class RecommendationsForm
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
            this.dataGridViewMostPopularDesserts = new System.Windows.Forms.DataGridView();
            this.label_TheMostPopularDesserts = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostPopularDesserts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMostPopularDesserts
            // 
            this.dataGridViewMostPopularDesserts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostPopularDesserts.Location = new System.Drawing.Point(38, 105);
            this.dataGridViewMostPopularDesserts.Name = "dataGridViewMostPopularDesserts";
            this.dataGridViewMostPopularDesserts.RowHeadersWidth = 51;
            this.dataGridViewMostPopularDesserts.RowTemplate.Height = 24;
            this.dataGridViewMostPopularDesserts.Size = new System.Drawing.Size(338, 263);
            this.dataGridViewMostPopularDesserts.TabIndex = 0;
            this.dataGridViewMostPopularDesserts.Visible = false;
            // 
            // label_TheMostPopularDesserts
            // 
            this.label_TheMostPopularDesserts.AutoSize = true;
            this.label_TheMostPopularDesserts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_TheMostPopularDesserts.Location = new System.Drawing.Point(12, 142);
            this.label_TheMostPopularDesserts.Name = "label_TheMostPopularDesserts";
            this.label_TheMostPopularDesserts.Size = new System.Drawing.Size(324, 25);
            this.label_TheMostPopularDesserts.TabIndex = 1;
            this.label_TheMostPopularDesserts.Text = "Найпопулярніші десерти за 7 днів";
            this.label_TheMostPopularDesserts.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(327, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введіть пошту для розсилки";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(145, 71);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // RecommendationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 102);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_TheMostPopularDesserts);
            this.Controls.Add(this.dataGridViewMostPopularDesserts);
            this.Name = "RecommendationsForm";
            this.Text = "RecommendationsForm";
            this.Load += new System.EventHandler(this.RecommendationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostPopularDesserts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMostPopularDesserts;
        private System.Windows.Forms.Label label_TheMostPopularDesserts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OK;
    }
}