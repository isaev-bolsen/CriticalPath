namespace CriticalPathBranch2
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dispercy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.workNameDataGridViewTextBoxColumn,
            this.previousDataGridViewTextBoxColumn,
            this.a,
            this.m,
            this.b,
            this.timeDataGridViewTextBoxColumn,
            this.Dispercy,
            this.eSDataGridViewTextBoxColumn,
            this.eFDataGridViewTextBoxColumn,
            this.lSDataGridViewTextBoxColumn,
            this.lFDataGridViewTextBoxColumn,
            this.rDataGridViewTextBoxColumn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1040, 408);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.ToolTipText = "Номер работы. Для использования в поле \"предшедствующие\"";
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // workNameDataGridViewTextBoxColumn
            // 
            this.workNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workNameDataGridViewTextBoxColumn.DataPropertyName = "WorkName";
            this.workNameDataGridViewTextBoxColumn.HeaderText = "Наименование Работы";
            this.workNameDataGridViewTextBoxColumn.Name = "workNameDataGridViewTextBoxColumn";
            this.workNameDataGridViewTextBoxColumn.ToolTipText = "Наименование Работы";
            this.workNameDataGridViewTextBoxColumn.Width = 136;
            // 
            // previousDataGridViewTextBoxColumn
            // 
            this.previousDataGridViewTextBoxColumn.DataPropertyName = "Previous";
            this.previousDataGridViewTextBoxColumn.HeaderText = "Предшедствующие";
            this.previousDataGridViewTextBoxColumn.Name = "previousDataGridViewTextBoxColumn";
            this.previousDataGridViewTextBoxColumn.ToolTipText = "Номера работ из поля ID через запятую";
            // 
            // a
            // 
            this.a.DataPropertyName = "a";
            this.a.HeaderText = "a";
            this.a.Name = "a";
            this.a.ToolTipText = "Оптимистический прогноз времени выполнения работы";
            this.a.Width = 40;
            // 
            // m
            // 
            this.m.DataPropertyName = "m";
            this.m.HeaderText = "m";
            this.m.Name = "m";
            this.m.ToolTipText = "Прогноз наиболее вероятного времени выполнения работы";
            this.m.Width = 40;
            // 
            // b
            // 
            this.b.DataPropertyName = "b";
            this.b.HeaderText = "b";
            this.b.Name = "b";
            this.b.ToolTipText = "Пессемистический прогноз времени выполнения работы";
            this.b.Width = 40;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            dataGridViewCellStyle8.Format = "N4";
            dataGridViewCellStyle8.NullValue = null;
            this.timeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.timeDataGridViewTextBoxColumn.HeaderText = "T";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ToolTipText = "Среднее время выполнения, вычисляется как (a+4m+b)/6";
            this.timeDataGridViewTextBoxColumn.Width = 39;
            // 
            // Dispercy
            // 
            this.Dispercy.DataPropertyName = "Dispercy";
            dataGridViewCellStyle9.Format = "N4";
            dataGridViewCellStyle9.NullValue = null;
            this.Dispercy.DefaultCellStyle = dataGridViewCellStyle9;
            this.Dispercy.HeaderText = "Дисперсия";
            this.Dispercy.Name = "Dispercy";
            this.Dispercy.ReadOnly = true;
            this.Dispercy.ToolTipText = "Мера отклонения времени выполнения от математического ожидания (a-b)/6";
            this.Dispercy.Width = 55;
            // 
            // eSDataGridViewTextBoxColumn
            // 
            this.eSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.eSDataGridViewTextBoxColumn.DataPropertyName = "ES";
            dataGridViewCellStyle10.Format = "N4";
            dataGridViewCellStyle10.NullValue = null;
            this.eSDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.eSDataGridViewTextBoxColumn.HeaderText = "ES";
            this.eSDataGridViewTextBoxColumn.Name = "eSDataGridViewTextBoxColumn";
            this.eSDataGridViewTextBoxColumn.ReadOnly = true;
            this.eSDataGridViewTextBoxColumn.ToolTipText = "Ранний старт";
            this.eSDataGridViewTextBoxColumn.Width = 46;
            // 
            // eFDataGridViewTextBoxColumn
            // 
            this.eFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.eFDataGridViewTextBoxColumn.DataPropertyName = "EF";
            dataGridViewCellStyle11.Format = "N4";
            dataGridViewCellStyle11.NullValue = null;
            this.eFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.eFDataGridViewTextBoxColumn.HeaderText = "EF";
            this.eFDataGridViewTextBoxColumn.Name = "eFDataGridViewTextBoxColumn";
            this.eFDataGridViewTextBoxColumn.ReadOnly = true;
            this.eFDataGridViewTextBoxColumn.ToolTipText = "Ранний финиш";
            this.eFDataGridViewTextBoxColumn.Width = 45;
            // 
            // lSDataGridViewTextBoxColumn
            // 
            this.lSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lSDataGridViewTextBoxColumn.DataPropertyName = "LS";
            dataGridViewCellStyle12.Format = "N4";
            dataGridViewCellStyle12.NullValue = null;
            this.lSDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.lSDataGridViewTextBoxColumn.HeaderText = "LS";
            this.lSDataGridViewTextBoxColumn.Name = "lSDataGridViewTextBoxColumn";
            this.lSDataGridViewTextBoxColumn.ReadOnly = true;
            this.lSDataGridViewTextBoxColumn.ToolTipText = "Поздний старт";
            this.lSDataGridViewTextBoxColumn.Width = 45;
            // 
            // lFDataGridViewTextBoxColumn
            // 
            this.lFDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lFDataGridViewTextBoxColumn.DataPropertyName = "LF";
            dataGridViewCellStyle13.Format = "N4";
            dataGridViewCellStyle13.NullValue = null;
            this.lFDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.lFDataGridViewTextBoxColumn.HeaderText = "LF";
            this.lFDataGridViewTextBoxColumn.Name = "lFDataGridViewTextBoxColumn";
            this.lFDataGridViewTextBoxColumn.ReadOnly = true;
            this.lFDataGridViewTextBoxColumn.ToolTipText = "Поздний финиш";
            this.lFDataGridViewTextBoxColumn.Width = 44;
            // 
            // rDataGridViewTextBoxColumn
            // 
            this.rDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.rDataGridViewTextBoxColumn.DataPropertyName = "R";
            dataGridViewCellStyle14.Format = "N4";
            dataGridViewCellStyle14.NullValue = null;
            this.rDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.rDataGridViewTextBoxColumn.HeaderText = "R";
            this.rDataGridViewTextBoxColumn.Name = "rDataGridViewTextBoxColumn";
            this.rDataGridViewTextBoxColumn.ReadOnly = true;
            this.rDataGridViewTextBoxColumn.ToolTipText = "Резерв времени";
            this.rDataGridViewTextBoxColumn.Width = 40;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1040, 53);
            this.button1.TabIndex = 1;
            this.button1.Text = "Red Button";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(197, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дисперсия для критического пути";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Желаемый срок";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(654, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(760, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вероятность успеть:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(878, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Среднее полное время:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(439, 69);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Стандартное отклонение";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(197, 99);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 136);
            this.panel1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 544);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "CriticalPathBr2 Mamistov";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
        private System.Windows.Forms.DataGridViewTextBoxColumn m;
        private System.Windows.Forms.DataGridViewTextBoxColumn b;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dispercy;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}

