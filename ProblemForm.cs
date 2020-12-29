using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TechnicalSupport
{
    public partial class ProblemForm : Form
    {
        SettingsJSON ConectionSettings;

        public ProblemForm()
        {
            InitializeComponent();
        }

        private void ProblemForm_Load(object sender, EventArgs e)
        {
            ConectionSettings = (SettingsJSON)new WorkWithFileJson().GetJSONDataWithFile(@"JSONFile/DataBase.json", typeof(SettingsJSON));

            for (int i = 0; i < ConectionSettings.DataBase.Problem.nameProblem.Count; i++)
            {
                ProblemBox.Items.Add(ConectionSettings.DataBase.Problem.nameProblem[i]);
            }
        }

        private void ProblemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ProblemBox.SelectedIndex;

            ProblemText.Text = "";

            List<string> reshProblem = ConectionSettings.DataBase.Problem.ListReshProblem[index];

            for (int i = 0; i < reshProblem.Count; i++)
            {
                ProblemText.Text += reshProblem[i] + "\r\n\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
