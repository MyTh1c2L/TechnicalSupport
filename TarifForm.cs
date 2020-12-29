using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TechnicalSupport
{
    public partial class TarifForm : Form
    {
        SettingsJSON ConectionSettings;

        public TarifForm()
        {
            InitializeComponent();
        }

        private void TarifForm_Load(object sender, EventArgs e)
        {
            ConectionSettings = (SettingsJSON)new WorkWithFileJson().GetJSONDataWithFile(@"JSONFile/DataBase.json", typeof(SettingsJSON));

            for (int i = 0; i < ConectionSettings.DataBase.Tarif.nameTarif.Count; i++)
            {
                TarifBox.Items.Add(ConectionSettings.DataBase.Tarif.nameTarif[i]);
            }
        }

        private void TarifBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TarifBox.SelectedIndex;

            TarifText.Text = "";

            List<string> textTarif = ConectionSettings.DataBase.Tarif.ListTextTarif[index];

            for (int i = 0; i < textTarif.Count; i++)
            {
                TarifText.Text += textTarif[i] + "\r\n\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
