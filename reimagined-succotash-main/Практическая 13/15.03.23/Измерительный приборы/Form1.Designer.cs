namespace Измерительный_приборы
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yesBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inBox = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.addObject = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.producer = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.allChoice = new System.Windows.Forms.RadioButton();
            this.grosChoice = new System.Windows.Forms.RadioButton();
            this.manuChoice = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1166, 583);
            this.splitContainer1.SplitterDistance = 706;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 583);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(706, 583);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.yesBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.change);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.count);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inBox);
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.addObject);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.producer);
            this.panel1.Controls.Add(this.name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 583);
            this.panel1.TabIndex = 0;
            // 
            // yesBox
            // 
            this.yesBox.AutoSize = true;
            this.yesBox.Location = new System.Drawing.Point(191, 374);
            this.yesBox.Name = "yesBox";
            this.yesBox.Size = new System.Drawing.Size(15, 14);
            this.yesBox.TabIndex = 20;
            this.yesBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(126, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Хрупкий";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "Промышленный";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Продуктовый";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(123, 474);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(89, 28);
            this.change.TabIndex = 14;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(218, 439);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(89, 28);
            this.delete.TabIndex = 13;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(126, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Количество";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(129, 229);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(127, 20);
            this.count.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(126, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Срок годности";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(126, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество в коробке";
            // 
            // inBox
            // 
            this.inBox.Location = new System.Drawing.Point(129, 348);
            this.inBox.Name = "inBox";
            this.inBox.Size = new System.Drawing.Size(127, 20);
            this.inBox.TabIndex = 8;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(129, 308);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(127, 20);
            this.time.TabIndex = 7;
            // 
            // addObject
            // 
            this.addObject.Location = new System.Drawing.Point(123, 439);
            this.addObject.Name = "addObject";
            this.addObject.Size = new System.Drawing.Size(89, 28);
            this.addObject.TabIndex = 6;
            this.addObject.Text = "Добавить";
            this.addObject.UseVisualStyleBackColor = true;
            this.addObject.Click += new System.EventHandler(this.addObject_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(126, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(126, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фирма производитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(126, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(129, 269);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(127, 20);
            this.price.TabIndex = 2;
            // 
            // producer
            // 
            this.producer.Location = new System.Drawing.Point(129, 189);
            this.producer.Name = "producer";
            this.producer.Size = new System.Drawing.Size(127, 20);
            this.producer.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(129, 150);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(127, 20);
            this.name.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.manuChoice);
            this.panel3.Controls.Add(this.allChoice);
            this.panel3.Controls.Add(this.grosChoice);
            this.panel3.Location = new System.Drawing.Point(6, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(129, 74);
            this.panel3.TabIndex = 24;
            // 
            // allChoice
            // 
            this.allChoice.AutoSize = true;
            this.allChoice.Checked = true;
            this.allChoice.Location = new System.Drawing.Point(3, 3);
            this.allChoice.Name = "allChoice";
            this.allChoice.Size = new System.Drawing.Size(84, 17);
            this.allChoice.TabIndex = 25;
            this.allChoice.TabStop = true;
            this.allChoice.Text = "Все товары";
            this.allChoice.UseVisualStyleBackColor = true;
            this.allChoice.CheckedChanged += new System.EventHandler(this.allChoice_CheckedChanged);
            // 
            // grosChoice
            // 
            this.grosChoice.AutoSize = true;
            this.grosChoice.Location = new System.Drawing.Point(3, 26);
            this.grosChoice.Name = "grosChoice";
            this.grosChoice.Size = new System.Drawing.Size(93, 17);
            this.grosChoice.TabIndex = 26;
            this.grosChoice.Text = "Продуктовые";
            this.grosChoice.UseVisualStyleBackColor = true;
            this.grosChoice.CheckedChanged += new System.EventHandler(this.grosChoice_CheckedChanged);
            // 
            // manuChoice
            // 
            this.manuChoice.AutoSize = true;
            this.manuChoice.Location = new System.Drawing.Point(3, 49);
            this.manuChoice.Name = "manuChoice";
            this.manuChoice.Size = new System.Drawing.Size(107, 17);
            this.manuChoice.TabIndex = 27;
            this.manuChoice.Text = "Промышленные";
            this.manuChoice.UseVisualStyleBackColor = true;
            this.manuChoice.CheckedChanged += new System.EventHandler(this.manuChoice_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1166, 583);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Коллекции";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addObject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox producer;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inBox;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox count;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox yesBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton manuChoice;
        private System.Windows.Forms.RadioButton allChoice;
        private System.Windows.Forms.RadioButton grosChoice;
    }
}

