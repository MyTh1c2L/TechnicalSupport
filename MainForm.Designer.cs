namespace TechnicalSupport
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProblemButton = new System.Windows.Forms.Button();
            this.TarifButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dbproblem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dbtarif = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(860, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(552, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Скорость интернет соединения:";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpeedLabel.ForeColor = System.Drawing.Color.Blue;
            this.SpeedLabel.Location = new System.Drawing.Point(606, 292);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(98, 19);
            this.SpeedLabel.TabIndex = 2;
            this.SpeedLabel.Text = "000,00 КБ/с";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Найти решение своей проблемы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Информация про наши тарифы:";
            // 
            // ProblemButton
            // 
            this.ProblemButton.Location = new System.Drawing.Point(7, 40);
            this.ProblemButton.Name = "ProblemButton";
            this.ProblemButton.Size = new System.Drawing.Size(400, 81);
            this.ProblemButton.TabIndex = 5;
            this.ProblemButton.Text = "Нажми на меня!";
            this.ProblemButton.UseVisualStyleBackColor = true;
            this.ProblemButton.Click += new System.EventHandler(this.ProblemButton_Click);
            // 
            // TarifButton
            // 
            this.TarifButton.Location = new System.Drawing.Point(7, 40);
            this.TarifButton.Name = "TarifButton";
            this.TarifButton.Size = new System.Drawing.Size(400, 81);
            this.TarifButton.TabIndex = 6;
            this.TarifButton.Text = "Нажми на меня!";
            this.TarifButton.UseVisualStyleBackColor = true;
            this.TarifButton.Click += new System.EventHandler(this.TarifButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dbproblem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProblemButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 195);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // dbproblem
            // 
            this.dbproblem.Location = new System.Drawing.Point(10, 151);
            this.dbproblem.Name = "dbproblem";
            this.dbproblem.Size = new System.Drawing.Size(395, 29);
            this.dbproblem.TabIndex = 10;
            this.dbproblem.Text = "Открыть";
            this.dbproblem.UseVisualStyleBackColor = true;
            this.dbproblem.Click += new System.EventHandler(this.dbproblem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Загрузить базу данных:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dbtarif);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TarifButton);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(433, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 195);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // dbtarif
            // 
            this.dbtarif.Location = new System.Drawing.Point(12, 151);
            this.dbtarif.Name = "dbtarif";
            this.dbtarif.Size = new System.Drawing.Size(395, 29);
            this.dbtarif.TabIndex = 8;
            this.dbtarif.Text = "Открыть";
            this.dbtarif.UseVisualStyleBackColor = true;
            this.dbtarif.Click += new System.EventHandler(this.dbtarif_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Загрузить базу данных:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Обратная связь:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(13, 252);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(412, 109);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Номера справочной службы:\r\n+7 (3412) 553-535\r\n+7 (3412) 553-123\r\n\r\nEmail:\r\ntechsu" +
    "pport@ya.ru";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(860, 377);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(876, 416);
            this.MinimumSize = new System.Drawing.Size(876, 416);
            this.Name = "MainForm";
            this.Text = "Техническая поддержка абонентов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ProblemButton;
        private System.Windows.Forms.Button TarifButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dbproblem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dbtarif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

