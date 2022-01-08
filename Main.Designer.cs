namespace CourseWorkDB
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.десертиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.виробникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиВиробникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиВиробникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиВиробникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найпопулярнішіДесертиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.модаВиробниківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рядРозподілуВиробниківЗаКількістюТоварівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відхиленняВідСередньоїЦіниДесертівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЧекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отриматиРекомендацїіToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиПоточніДаніToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.mANUFACTURERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cond_departmentDataSet = new CourseWorkDB.cond_departmentDataSet();
            this.dESSERTSTableAdapter = new CourseWorkDB.cond_departmentDataSetTableAdapters.DESSERTSTableAdapter();
            this.dESSERTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mANUFACTURERSTableAdapter = new CourseWorkDB.cond_departmentDataSetTableAdapters.MANUFACTURERSTableAdapter();
            this.поставникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поставкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказиДесертівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиПоставкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупкаТоваруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditerDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANUFACTURERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESSERTSBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditerDepartmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.десертиToolStripMenuItem,
            this.виробникиToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.зберегтиЧекToolStripMenuItem,
            this.отриматиРекомендацїіToolStripMenuItem,
            this.зберегтиПоточніДаніToolStripMenuItem,
            this.поставникиToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1013, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            this.menuStripMain.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripMain_ItemClicked);
            // 
            // десертиToolStripMenuItem
            // 
            this.десертиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиToolStripMenuItem,
            this.редагуватиToolStripMenuItem,
            this.видалитиToolStripMenuItem,
            this.пошукToolStripMenuItem});
            this.десертиToolStripMenuItem.Name = "десертиToolStripMenuItem";
            this.десертиToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.десертиToolStripMenuItem.Text = "Десерти";
            this.десертиToolStripMenuItem.Click += new System.EventHandler(this.десертиToolStripMenuItem_Click);
            // 
            // додатиToolStripMenuItem
            // 
            this.додатиToolStripMenuItem.Name = "додатиToolStripMenuItem";
            this.додатиToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.додатиToolStripMenuItem.Text = "Додати";
            this.додатиToolStripMenuItem.Click += new System.EventHandler(this.додатиToolStripMenuItem_Click);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            this.редагуватиToolStripMenuItem.Click += new System.EventHandler(this.редагуватиToolStripMenuItem_Click);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.видалитиToolStripMenuItem_Click);
            // 
            // пошукToolStripMenuItem
            // 
            this.пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            this.пошукToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.пошукToolStripMenuItem.Text = "Пошук, фільтрація, сортування";
            this.пошукToolStripMenuItem.Click += new System.EventHandler(this.пошукToolStripMenuItem_Click);
            // 
            // виробникиToolStripMenuItem
            // 
            this.виробникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиВиробникаToolStripMenuItem,
            this.редагуватиВиробникаToolStripMenuItem,
            this.видалитиВиробникаToolStripMenuItem});
            this.виробникиToolStripMenuItem.Name = "виробникиToolStripMenuItem";
            this.виробникиToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.виробникиToolStripMenuItem.Text = "Виробники";
            this.виробникиToolStripMenuItem.Click += new System.EventHandler(this.виробникиToolStripMenuItem_Click);
            // 
            // додатиВиробникаToolStripMenuItem
            // 
            this.додатиВиробникаToolStripMenuItem.Name = "додатиВиробникаToolStripMenuItem";
            this.додатиВиробникаToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.додатиВиробникаToolStripMenuItem.Text = "Додати виробника";
            this.додатиВиробникаToolStripMenuItem.Click += new System.EventHandler(this.додатиВиробникаToolStripMenuItem_Click);
            // 
            // редагуватиВиробникаToolStripMenuItem
            // 
            this.редагуватиВиробникаToolStripMenuItem.Name = "редагуватиВиробникаToolStripMenuItem";
            this.редагуватиВиробникаToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.редагуватиВиробникаToolStripMenuItem.Text = "Редагувати виробника";
            this.редагуватиВиробникаToolStripMenuItem.Click += new System.EventHandler(this.редагуватиВиробникаToolStripMenuItem_Click);
            // 
            // видалитиВиробникаToolStripMenuItem
            // 
            this.видалитиВиробникаToolStripMenuItem.Name = "видалитиВиробникаToolStripMenuItem";
            this.видалитиВиробникаToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.видалитиВиробникаToolStripMenuItem.Text = "Видалити виробника";
            this.видалитиВиробникаToolStripMenuItem.Click += new System.EventHandler(this.видалитиВиробникаToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.найпопулярнішіДесертиToolStripMenuItem,
            this.модаВиробниківToolStripMenuItem,
            this.рядРозподілуВиробниківЗаКількістюТоварівToolStripMenuItem,
            this.відхиленняВідСередньоїЦіниДесертівToolStripMenuItem});
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            this.статистикаToolStripMenuItem.Click += new System.EventHandler(this.статистикаToolStripMenuItem_Click);
            // 
            // найпопулярнішіДесертиToolStripMenuItem
            // 
            this.найпопулярнішіДесертиToolStripMenuItem.Name = "найпопулярнішіДесертиToolStripMenuItem";
            this.найпопулярнішіДесертиToolStripMenuItem.Size = new System.Drawing.Size(417, 26);
            this.найпопулярнішіДесертиToolStripMenuItem.Text = "Середня ціна десертів";
            this.найпопулярнішіДесертиToolStripMenuItem.Click += new System.EventHandler(this.середняцінаДесертиToolStripMenuItem_Click);
            // 
            // модаВиробниківToolStripMenuItem
            // 
            this.модаВиробниківToolStripMenuItem.Name = "модаВиробниківToolStripMenuItem";
            this.модаВиробниківToolStripMenuItem.Size = new System.Drawing.Size(417, 26);
            this.модаВиробниківToolStripMenuItem.Text = "Мода виробників";
            this.модаВиробниківToolStripMenuItem.Click += new System.EventHandler(this.модаВиробниківToolStripMenuItem_Click);
            // 
            // рядРозподілуВиробниківЗаКількістюТоварівToolStripMenuItem
            // 
            this.рядРозподілуВиробниківЗаКількістюТоварівToolStripMenuItem.Name = "рядРозподілуВиробниківЗаКількістюТоварівToolStripMenuItem";
            this.рядРозподілуВиробниківЗаКількістюТоварівToolStripMenuItem.Size = new System.Drawing.Size(417, 26);
            this.рядРозподілуВиробниківЗаКількістюТоварівToolStripMenuItem.Text = "Ряд розподілу виробників за кількістю товарів";
            this.рядРозподілуВиробниківЗаКількістюТоварівToolStripMenuItem.Click += new System.EventHandler(this.рядРозподілуВиробниківЗаКількістюТоварівToolStripMenuItem_Click);
            // 
            // відхиленняВідСередньоїЦіниДесертівToolStripMenuItem
            // 
            this.відхиленняВідСередньоїЦіниДесертівToolStripMenuItem.Name = "відхиленняВідСередньоїЦіниДесертівToolStripMenuItem";
            this.відхиленняВідСередньоїЦіниДесертівToolStripMenuItem.Size = new System.Drawing.Size(417, 26);
            this.відхиленняВідСередньоїЦіниДесертівToolStripMenuItem.Text = "Відхилення від середньої ціни десертів";
            this.відхиленняВідСередньоїЦіниДесертівToolStripMenuItem.Click += new System.EventHandler(this.відхиленняВідСередньоїЦіниДесертівToolStripMenuItem_Click);
            // 
            // зберегтиЧекToolStripMenuItem
            // 
            this.зберегтиЧекToolStripMenuItem.Name = "зберегтиЧекToolStripMenuItem";
            this.зберегтиЧекToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.зберегтиЧекToolStripMenuItem.Text = "Зберегти чек";
            this.зберегтиЧекToolStripMenuItem.Click += new System.EventHandler(this.зберегтиЧекToolStripMenuItem_Click);
            // 
            // отриматиРекомендацїіToolStripMenuItem
            // 
            this.отриматиРекомендацїіToolStripMenuItem.Name = "отриматиРекомендацїіToolStripMenuItem";
            this.отриматиРекомендацїіToolStripMenuItem.Size = new System.Drawing.Size(190, 24);
            this.отриматиРекомендацїіToolStripMenuItem.Text = "Отримати рекомендацїі";
            this.отриматиРекомендацїіToolStripMenuItem.Click += new System.EventHandler(this.отриматиРекомендацїіToolStripMenuItem_Click);
            // 
            // зберегтиПоточніДаніToolStripMenuItem
            // 
            this.зберегтиПоточніДаніToolStripMenuItem.Name = "зберегтиПоточніДаніToolStripMenuItem";
            this.зберегтиПоточніДаніToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.зберегтиПоточніДаніToolStripMenuItem.Text = "Зберегти список поставників";
            this.зберегтиПоточніДаніToolStripMenuItem.Click += new System.EventHandler(this.зберегтиПоточніДаніToolStripMenuItem_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 142);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.RowTemplate.Height = 24;
            this.dataGridViewMain.Size = new System.Drawing.Size(989, 233);
            this.dataGridViewMain.TabIndex = 1;
            this.dataGridViewMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellClick);
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
            // dESSERTSTableAdapter
            // 
            this.dESSERTSTableAdapter.ClearBeforeFill = true;
            // 
            // dESSERTSBindingSource
            // 
            this.dESSERTSBindingSource.DataMember = "DESSERTS";
            this.dESSERTSBindingSource.DataSource = this.cond_departmentDataSet;
            // 
            // mANUFACTURERSTableAdapter
            // 
            this.mANUFACTURERSTableAdapter.ClearBeforeFill = true;
            // 
            // поставникиToolStripMenuItem
            // 
            this.поставникиToolStripMenuItem.Name = "поставникиToolStripMenuItem";
            this.поставникиToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.поставникиToolStripMenuItem.Text = "Поставники";
            this.поставникиToolStripMenuItem.Click += new System.EventHandler(this.поставникиToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поставкиToolStripMenuItem,
            this.заказиToolStripMenuItem,
            this.заказиДесертівToolStripMenuItem,
            this.покупкаТоваруToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поставкиToolStripMenuItem
            // 
            this.поставкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.створитиПоставкуToolStripMenuItem});
            this.поставкиToolStripMenuItem.Name = "поставкиToolStripMenuItem";
            this.поставкиToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.поставкиToolStripMenuItem.Text = "Поставки";
            this.поставкиToolStripMenuItem.Click += new System.EventHandler(this.поставкиToolStripMenuItem_Click);
            // 
            // заказиToolStripMenuItem
            // 
            this.заказиToolStripMenuItem.Name = "заказиToolStripMenuItem";
            this.заказиToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.заказиToolStripMenuItem.Text = "Закази";
            this.заказиToolStripMenuItem.Click += new System.EventHandler(this.заказиToolStripMenuItem_Click);
            // 
            // заказиДесертівToolStripMenuItem
            // 
            this.заказиДесертівToolStripMenuItem.Name = "заказиДесертівToolStripMenuItem";
            this.заказиДесертівToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.заказиДесертівToolStripMenuItem.Text = "Закази десертів";
            this.заказиДесертівToolStripMenuItem.Click += new System.EventHandler(this.заказиДесертівToolStripMenuItem_Click);
            // 
            // створитиПоставкуToolStripMenuItem
            // 
            this.створитиПоставкуToolStripMenuItem.Name = "створитиПоставкуToolStripMenuItem";
            this.створитиПоставкуToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.створитиПоставкуToolStripMenuItem.Text = "Створити поставку";
            this.створитиПоставкуToolStripMenuItem.Click += new System.EventHandler(this.створитиПоставкуToolStripMenuItem_Click);
            // 
            // покупкаТоваруToolStripMenuItem
            // 
            this.покупкаТоваруToolStripMenuItem.Name = "покупкаТоваруToolStripMenuItem";
            this.покупкаТоваруToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.покупкаТоваруToolStripMenuItem.Text = "Покупка товару";
            this.покупкаТоваруToolStripMenuItem.Click += new System.EventHandler(this.покупкаТоваруToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 528);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кондитерський відділ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mANUFACTURERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cond_departmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dESSERTSBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conditerDepartmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem десертиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem виробникиToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.BindingSource conditerDepartmentBindingSource;
        private cond_departmentDataSet cond_departmentDataSet;
        private cond_departmentDataSetTableAdapters.DESSERTSTableAdapter dESSERTSTableAdapter;
        private System.Windows.Forms.BindingSource dESSERTSBindingSource;
        private System.Windows.Forms.BindingSource mANUFACTURERSBindingSource;
        private cond_departmentDataSetTableAdapters.MANUFACTURERSTableAdapter mANUFACTURERSTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem додатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиВиробникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиВиробникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиВиробникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найпопулярнішіДесертиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem модаВиробниківToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рядРозподілуВиробниківЗаКількістюТоварівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЧекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отриматиРекомендацїіToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відхиленняВідСередньоїЦіниДесертівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиПоточніДаніToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставникиToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поставкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказиДесертівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиПоставкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупкаТоваруToolStripMenuItem;
    }
}

