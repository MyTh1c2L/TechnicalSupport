using System;
using System.Linq;
using System.Windows.Forms;

namespace TechnicalSupport
{
    public partial class ProblemForm : Form
    {
        public ProblemForm()
        {
            InitializeComponent();
        }

        private void ProblemForm_Load(object sender, EventArgs e)
        {
            var ProblemList = System.IO.File.ReadLines("Problem.txt").ToList();
            DataBase.Initialize1(ProblemList);

            for (int i = 0; i < ProblemList.Count; i += 2)
            {
                string NameText = ProblemList[i];

                ProblemBox.Items.Add(NameText);
            }
        }

        private void ProblemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ProblemBox.SelectedIndex;
            string text = DataBase.Problem(index);

            var ProblemList = text.Split('\\').ToList();
            ProblemText.Text = "";

            for (int j = 0; j < ProblemList.Count(); j++)
            {
                ProblemText.Text += ProblemList[j].ToString() + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
