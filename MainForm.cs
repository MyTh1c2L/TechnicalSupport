using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechnicalSupport
{
    public partial class MainForm : Form
    {
        HelpForm hf;
        ProblemForm pf;
        TarifForm tf;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists("Problem.txt"))
            {
                ProblemButton.Text = "База данных не найдена";
                ProblemButton.Enabled = false;
            }

            if (!System.IO.File.Exists("Tarif.txt"))
            {
                TarifButton.Text = "База данных не найдена";
                TarifButton.Enabled = false;
            }

            timer1.Enabled = true;
            timer1.Start();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hf = new HelpForm();
            hf.Show();
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
            pf = new ProblemForm();
            pf.Show();
        }

        private void TarifButton_Click(object sender, EventArgs e)
        {
            tf = new TarifForm();
            tf.Show();
        }

        private void dbproblem_Click(object sender, EventArgs e)
        {
            if (pf != null)
                pf.Close();

            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            if (filePath != "")
            {
                var ProblemList = System.IO.File.ReadLines(@filePath).ToList();
                System.IO.File.WriteAllLines("Problem.txt", ProblemList);

                ProblemButton.Text = "Нажми на меня!";
                ProblemButton.Enabled = true;
            }
        }

        private void dbtarif_Click(object sender, EventArgs e)
        {
            if (tf != null)
                tf.Close();

            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            if (filePath != "")
            {
                var ProblemList = System.IO.File.ReadLines(@filePath).ToList();
                System.IO.File.WriteAllLines("Tarif.txt", ProblemList);

                TarifButton.Text = "Нажми на меня!";
                TarifButton.Enabled = true;
            }
        }
    }
}
