﻿namespace TechnicalSupport
{
    partial class TarifForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarifForm));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TarifBox = new System.Windows.Forms.ComboBox();
            this.TarifText = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 421);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(585, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Выберите тариф:";
            // 
            // TarifBox
            // 
            this.TarifBox.FormattingEnabled = true;
            this.TarifBox.Location = new System.Drawing.Point(17, 35);
            this.TarifBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TarifBox.Name = "TarifBox";
            this.TarifBox.Size = new System.Drawing.Size(578, 24);
            this.TarifBox.TabIndex = 5;
            this.TarifBox.SelectedIndexChanged += new System.EventHandler(this.TarifBox_SelectedIndexChanged);
            // 
            // TarifText
            // 
            this.TarifText.AutoEllipsis = true;
            this.TarifText.Location = new System.Drawing.Point(6, 10);
            this.TarifText.Name = "TarifText";
            this.TarifText.Size = new System.Drawing.Size(570, 335);
            this.TarifText.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.TarifText);
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 348);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // TarifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TarifBox);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(625, 507);
            this.MinimumSize = new System.Drawing.Size(625, 507);
            this.Name = "TarifForm";
            this.Text = "Информация о тарифных планах";
            this.Load += new System.EventHandler(this.TarifForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TarifBox;
        private System.Windows.Forms.Label TarifText;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}