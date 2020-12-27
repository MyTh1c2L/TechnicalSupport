namespace TechnicalSupport
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
            this.TarifText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TarifBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 397);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(585, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TarifText
            // 
            this.TarifText.Location = new System.Drawing.Point(14, 44);
            this.TarifText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TarifText.Multiline = true;
            this.TarifText.Name = "TarifText";
            this.TarifText.Size = new System.Drawing.Size(583, 346);
            this.TarifText.TabIndex = 7;
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
            this.TarifBox.Location = new System.Drawing.Point(131, 11);
            this.TarifBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TarifBox.Name = "TarifBox";
            this.TarifBox.Size = new System.Drawing.Size(466, 24);
            this.TarifBox.TabIndex = 5;
            this.TarifBox.SelectedIndexChanged += new System.EventHandler(this.TarifBox_SelectedIndexChanged);
            // 
            // TarifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TarifText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TarifBox);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(625, 477);
            this.MinimumSize = new System.Drawing.Size(625, 477);
            this.Name = "TarifForm";
            this.Text = "Информация о тарифных планах";
            this.Load += new System.EventHandler(this.TarifForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TarifText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TarifBox;
    }
}