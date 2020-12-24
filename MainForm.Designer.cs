namespace TechnicalSupport
{
    partial class MainForm
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
            this.ProblemBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TariffBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Speedlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьНовуюБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бДПроблемИИхРешенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бДТарифовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProblemText = new System.Windows.Forms.TextBox();
            this.TariffText = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProblemBox
            // 
            this.ProblemBox.FormattingEnabled = true;
            this.ProblemBox.Location = new System.Drawing.Point(10, 44);
            this.ProblemBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProblemBox.Name = "ProblemBox";
            this.ProblemBox.Size = new System.Drawing.Size(259, 23);
            this.ProblemBox.TabIndex = 0;
            this.ProblemBox.SelectedIndexChanged += new System.EventHandler(this.ProblemBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите вашу проблему:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 490);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Проблема не решена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 473);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Если вы не нашли решение своей проблемы:";
            // 
            // TariffBox
            // 
            this.TariffBox.FormattingEnabled = true;
            this.TariffBox.Location = new System.Drawing.Point(10, 268);
            this.TariffBox.Margin = new System.Windows.Forms.Padding(2);
            this.TariffBox.Name = "TariffBox";
            this.TariffBox.Size = new System.Drawing.Size(255, 23);
            this.TariffBox.TabIndex = 5;
            this.TariffBox.SelectedIndexChanged += new System.EventHandler(this.TariffBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 473);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Скорость интернет соединения:";
            // 
            // Speedlabel
            // 
            this.Speedlabel.AutoSize = true;
            this.Speedlabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Speedlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Speedlabel.Location = new System.Drawing.Point(548, 493);
            this.Speedlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Speedlabel.Name = "Speedlabel";
            this.Speedlabel.Size = new System.Drawing.Size(45, 17);
            this.Speedlabel.TabIndex = 7;
            this.Speedlabel.Text = "0 Кб/с";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Узнайте больше про тарифы:";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(916, 28);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьНовуюБДToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьНовуюБДToolStripMenuItem
            // 
            this.открытьНовуюБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бДПроблемИИхРешенийToolStripMenuItem,
            this.бДТарифовToolStripMenuItem});
            this.открытьНовуюБДToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.открытьНовуюБДToolStripMenuItem.Name = "открытьНовуюБДToolStripMenuItem";
            this.открытьНовуюБДToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.открытьНовуюБДToolStripMenuItem.Text = "Обновить БД";
            // 
            // бДПроблемИИхРешенийToolStripMenuItem
            // 
            this.бДПроблемИИхРешенийToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.бДПроблемИИхРешенийToolStripMenuItem.Name = "бДПроблемИИхРешенийToolStripMenuItem";
            this.бДПроблемИИхРешенийToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.бДПроблемИИхРешенийToolStripMenuItem.Text = "БД проблем и их решений";
            this.бДПроблемИИхРешенийToolStripMenuItem.Click += new System.EventHandler(this.бДПроблемИИхРешенийToolStripMenuItem_Click);
            // 
            // бДТарифовToolStripMenuItem
            // 
            this.бДТарифовToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.бДТарифовToolStripMenuItem.Name = "бДТарифовToolStripMenuItem";
            this.бДТарифовToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.бДТарифовToolStripMenuItem.Text = "БД тарифов";
            this.бДТарифовToolStripMenuItem.Click += new System.EventHandler(this.бДТарифовToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // ProblemText
            // 
            this.ProblemText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProblemText.Location = new System.Drawing.Point(10, 75);
            this.ProblemText.Multiline = true;
            this.ProblemText.Name = "ProblemText";
            this.ProblemText.ReadOnly = true;
            this.ProblemText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProblemText.Size = new System.Drawing.Size(721, 168);
            this.ProblemText.TabIndex = 11;
            // 
            // TariffText
            // 
            this.TariffText.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TariffText.Location = new System.Drawing.Point(10, 299);
            this.TariffText.Multiline = true;
            this.TariffText.Name = "TariffText";
            this.TariffText.ReadOnly = true;
            this.TariffText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TariffText.Size = new System.Drawing.Size(721, 170);
            this.TariffText.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(749, 534);
            this.Controls.Add(this.TariffText);
            this.Controls.Add(this.ProblemText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Speedlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TariffBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProblemBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Техническая поддержка абонентов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label Speedlabel;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        public System.Windows.Forms.ComboBox ProblemBox;
        public System.Windows.Forms.ComboBox TariffBox;
        private System.Windows.Forms.ToolStripMenuItem открытьНовуюБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бДПроблемИИхРешенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бДТарифовToolStripMenuItem;
        private System.Windows.Forms.TextBox ProblemText;
        private System.Windows.Forms.TextBox TariffText;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label3;
    }
}

