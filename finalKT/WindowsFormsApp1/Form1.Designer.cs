namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.db44DataSet1 = new WindowsFormsApp1.db44DataSet();
            this.tableAdapterManager1 = new WindowsFormsApp1.db44DataSetTableAdapters.TableAdapterManager();
            this.учетTableAdapter1 = new WindowsFormsApp1.db44DataSetTableAdapters.УчетTableAdapter();
            this.db44DataSet2 = new WindowsFormsApp1.db44DataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.учетBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годВыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.госномерDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.страховаяСтоимостьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОВладельцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.данныеПаспортаВладельцаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видНарушенияПДДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.размерШтрафаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНарушенияПДДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОВодителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.правоУправленияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.страховойВзносDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db44DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db44DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.годВыпускаDataGridViewTextBoxColumn,
            this.госномерDataGridViewTextBoxColumn,
            this.страховаяСтоимостьDataGridViewTextBoxColumn,
            this.фИОВладельцаDataGridViewTextBoxColumn,
            this.данныеПаспортаВладельцаDataGridViewTextBoxColumn,
            this.видНарушенияПДДDataGridViewTextBoxColumn,
            this.размерШтрафаDataGridViewTextBoxColumn,
            this.датаНарушенияПДДDataGridViewTextBoxColumn,
            this.фИОВодителяDataGridViewTextBoxColumn,
            this.правоУправленияDataGridViewTextBoxColumn,
            this.страховойВзносDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.учетBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(40, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(940, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(230, 429);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 58);
            this.button4.TabIndex = 4;
            this.button4.Text = "удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(645, 394);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 58);
            this.button5.TabIndex = 5;
            this.button5.Text = "Запросы";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // db44DataSet1
            // 
            this.db44DataSet1.DataSetName = "db44DataSet";
            this.db44DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.db44DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.УчетTableAdapter = this.учетTableAdapter1;
            // 
            // учетTableAdapter1
            // 
            this.учетTableAdapter1.ClearBeforeFill = true;
            // 
            // db44DataSet2
            // 
            this.db44DataSet2.DataSetName = "db44DataSet";
            this.db44DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.db44DataSet1;
            this.bindingSource1.Position = 0;
            // 
            // учетBindingSource
            // 
            this.учетBindingSource.DataMember = "Учет";
            this.учетBindingSource.DataSource = this.bindingSource1;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            // 
            // годВыпускаDataGridViewTextBoxColumn
            // 
            this.годВыпускаDataGridViewTextBoxColumn.DataPropertyName = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.HeaderText = "Год выпуска";
            this.годВыпускаDataGridViewTextBoxColumn.Name = "годВыпускаDataGridViewTextBoxColumn";
            // 
            // госномерDataGridViewTextBoxColumn
            // 
            this.госномерDataGridViewTextBoxColumn.DataPropertyName = "Госномер";
            this.госномерDataGridViewTextBoxColumn.HeaderText = "Госномер";
            this.госномерDataGridViewTextBoxColumn.Name = "госномерDataGridViewTextBoxColumn";
            // 
            // страховаяСтоимостьDataGridViewTextBoxColumn
            // 
            this.страховаяСтоимостьDataGridViewTextBoxColumn.DataPropertyName = "Страховая стоимость";
            this.страховаяСтоимостьDataGridViewTextBoxColumn.HeaderText = "Страховая стоимость";
            this.страховаяСтоимостьDataGridViewTextBoxColumn.Name = "страховаяСтоимостьDataGridViewTextBoxColumn";
            // 
            // фИОВладельцаDataGridViewTextBoxColumn
            // 
            this.фИОВладельцаDataGridViewTextBoxColumn.DataPropertyName = "ФИО владельца";
            this.фИОВладельцаDataGridViewTextBoxColumn.HeaderText = "ФИО владельца";
            this.фИОВладельцаDataGridViewTextBoxColumn.Name = "фИОВладельцаDataGridViewTextBoxColumn";
            // 
            // данныеПаспортаВладельцаDataGridViewTextBoxColumn
            // 
            this.данныеПаспортаВладельцаDataGridViewTextBoxColumn.DataPropertyName = "Данные паспорта владельца";
            this.данныеПаспортаВладельцаDataGridViewTextBoxColumn.HeaderText = "Данные паспорта владельца";
            this.данныеПаспортаВладельцаDataGridViewTextBoxColumn.Name = "данныеПаспортаВладельцаDataGridViewTextBoxColumn";
            // 
            // видНарушенияПДДDataGridViewTextBoxColumn
            // 
            this.видНарушенияПДДDataGridViewTextBoxColumn.DataPropertyName = "Вид нарушения ПДД";
            this.видНарушенияПДДDataGridViewTextBoxColumn.HeaderText = "Вид нарушения ПДД";
            this.видНарушенияПДДDataGridViewTextBoxColumn.Name = "видНарушенияПДДDataGridViewTextBoxColumn";
            // 
            // размерШтрафаDataGridViewTextBoxColumn
            // 
            this.размерШтрафаDataGridViewTextBoxColumn.DataPropertyName = "Размер штрафа";
            this.размерШтрафаDataGridViewTextBoxColumn.HeaderText = "Размер штрафа";
            this.размерШтрафаDataGridViewTextBoxColumn.Name = "размерШтрафаDataGridViewTextBoxColumn";
            // 
            // датаНарушенияПДДDataGridViewTextBoxColumn
            // 
            this.датаНарушенияПДДDataGridViewTextBoxColumn.DataPropertyName = "Дата нарушения ПДД";
            this.датаНарушенияПДДDataGridViewTextBoxColumn.HeaderText = "Дата нарушения ПДД";
            this.датаНарушенияПДДDataGridViewTextBoxColumn.Name = "датаНарушенияПДДDataGridViewTextBoxColumn";
            // 
            // фИОВодителяDataGridViewTextBoxColumn
            // 
            this.фИОВодителяDataGridViewTextBoxColumn.DataPropertyName = "ФИО водителя";
            this.фИОВодителяDataGridViewTextBoxColumn.HeaderText = "ФИО водителя";
            this.фИОВодителяDataGridViewTextBoxColumn.Name = "фИОВодителяDataGridViewTextBoxColumn";
            // 
            // правоУправленияDataGridViewTextBoxColumn
            // 
            this.правоУправленияDataGridViewTextBoxColumn.DataPropertyName = "Право управления";
            this.правоУправленияDataGridViewTextBoxColumn.HeaderText = "Право управления";
            this.правоУправленияDataGridViewTextBoxColumn.Name = "правоУправленияDataGridViewTextBoxColumn";
            // 
            // страховойВзносDataGridViewTextBoxColumn
            // 
            this.страховойВзносDataGridViewTextBoxColumn.DataPropertyName = "Страховой взнос";
            this.страховойВзносDataGridViewTextBoxColumn.HeaderText = "Страховой взнос";
            this.страховойВзносDataGridViewTextBoxColumn.Name = "страховойВзносDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 535);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db44DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db44DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учетBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годВыпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn госномерDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn страховаяСтоимостьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОВладельцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn данныеПаспортаВладельцаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn видНарушенияПДДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn размерШтрафаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНарушенияПДДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОВодителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn правоУправленияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn страховойВзносDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource учетBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private db44DataSet db44DataSet1;
        private db44DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private db44DataSetTableAdapters.УчетTableAdapter учетTableAdapter1;
        private db44DataSet db44DataSet2;
    }
}

