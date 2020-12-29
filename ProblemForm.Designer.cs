namespace TechnicalSupport
{
    partial class ProblemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProblemForm));
            this.ProblemBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ProblemText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProblemBox
            // 
            this.ProblemBox.FormattingEnabled = true;
            this.ProblemBox.Location = new System.Drawing.Point(17, 40);
            this.ProblemBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProblemBox.Name = "ProblemBox";
            this.ProblemBox.Size = new System.Drawing.Size(578, 24);
            this.ProblemBox.TabIndex = 0;
            this.ProblemBox.SelectedIndexChanged += new System.EventHandler(this.ProblemBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите вашу проблему:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 424);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(587, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ProblemText);
            this.groupBox1.Location = new System.Drawing.Point(17, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 346);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // ProblemText
            // 
            this.ProblemText.AutoEllipsis = true;
            this.ProblemText.Location = new System.Drawing.Point(5, 12);
            this.ProblemText.Name = "ProblemText";
            this.ProblemText.Size = new System.Drawing.Size(572, 331);
            this.ProblemText.TabIndex = 0;
            // 
            // ProblemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProblemBox);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(625, 507);
            this.MinimumSize = new System.Drawing.Size(625, 507);
            this.Name = "ProblemForm";
            this.Text = "Решение вашей проблемы";
            this.Load += new System.EventHandler(this.ProblemForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProblemBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ProblemText;
    }
}