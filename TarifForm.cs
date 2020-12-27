using System;
using System.Linq;
using System.Windows.Forms;

namespace TechnicalSupport
{
    public partial class TarifForm : Form
    {
        public TarifForm()
        {
            InitializeComponent();
        }

        private void TarifForm_Load(object sender, EventArgs e)
        {
            var TarifList = System.IO.File.ReadLines("Tarif.txt").ToList();
            DataBase.Initialize2(TarifList);

            for (int i = 0; i < TarifList.Count; i += 2)
            {
                string NameText = TarifList[i];

                TarifBox.Items.Add(NameText);
            }
        }

        private void TarifBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TarifBox.SelectedIndex;
            string text = DataBase.Tarif(index);

            var TarifList = text.Split('\\').ToList();
            TarifText.Text = "";

            for (int j = 0; j < TarifList.Count(); j++)
            {
                TarifText.Text += TarifList[j].ToString() + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
