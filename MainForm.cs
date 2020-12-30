using System;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalSupport
{
    public partial class MainForm : Form
    {
        HelpForm hf;
        ProblemForm pf;
        TarifForm tf;
        SettingsJSON ConectionSettings;

        public MainForm()
        {
            InitializeComponent();

            hf = new HelpForm();
        }

        private void ProblemFormClosed(object sender, EventArgs e)
        {
            pf = null;
        }

        private void TarifFormClosed(object sender, EventArgs e)
        {
            tf = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists("JSONFile/DataBase.json"))
            {
                ProblemButton.Text = "База данных не найдена";
                TarifButton.Text = "База данных не найдена";
                ProblemButton.Enabled = false;
                TarifButton.Enabled = false;
            }
            else
            {
                ConectionSettings = (SettingsJSON)new WorkWithFileJson().GetJSONDataWithFile(@"JSONFile/DataBase.json", typeof(SettingsJSON));

                for (int i = 0; i < ConectionSettings.DataBase.Communication.phone.Count; i++)
                    phoneTextBox.Text += ConectionSettings.DataBase.Communication.phone[i] + "\r\n";

                for (int i = 0; i < ConectionSettings.DataBase.Communication.email.Count; i++)
                    emailTextBox.Text += ConectionSettings.DataBase.Communication.email[i] + "\r\n";
            }

            timer1.Enabled = true;
            timer1.Start();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hf.Visible = true;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            Internet i = new Internet();

            string result = await Task.Factory.StartNew<string>(
                                             () => i.Speed());

            this.SpeedLabel.Text = result;
        }

        private void ProblemButton_Click(object sender, EventArgs e)
        {
            if(pf == null)
            {
                pf = new ProblemForm();
                pf.FormClosed += new FormClosedEventHandler(ProblemFormClosed);
                pf.Show();
            }
        }

        private void TarifButton_Click(object sender, EventArgs e)
        {
            if (tf == null)
            {
                tf = new TarifForm();
                tf.FormClosed += new FormClosedEventHandler(TarifFormClosed);
                tf.Show();
            }
        }

        private void BDOpen_Click(object sender, EventArgs e)
        {
            if (pf != null)
            {
                pf.Close();
                pf = null;
            }

            if (tf != null)
            {
                tf.Close();
                tf = null;
            }

            new WorkWithFileJson().NewFile();

            if (System.IO.File.Exists("JSONFile/DataBase.json"))
            {
                ProblemButton.Text = "Решить проблему";
                TarifButton.Text = "Узнать про тарифы";

                ProblemButton.Enabled = true;
                TarifButton.Enabled = true;

                ConectionSettings = (SettingsJSON)new WorkWithFileJson().GetJSONDataWithFile(@"JSONFile/DataBase.json", typeof(SettingsJSON));

                phoneTextBox.Text = "";
                for (int i = 0; i < ConectionSettings.DataBase.Communication.phone.Count; i++)
                    phoneTextBox.Text += ConectionSettings.DataBase.Communication.phone[i] + "\r\n";

                emailTextBox.Text = "";
                for (int i = 0; i < ConectionSettings.DataBase.Communication.email.Count; i++)
                    emailTextBox.Text += ConectionSettings.DataBase.Communication.email[i] + "\r\n";
            }
        }
    }
}
