using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace TechnicalSupport
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("Problem.txt"))
            {
                var ProblemList = System.IO.File.ReadLines("Problem.txt").ToList();
                for (int i = 0; i < ProblemList.Count; i += 2)
                {
                    string NameText = ProblemList[i];

                    ProblemBox.Items.Add(NameText);
                }
            }

            if (System.IO.File.Exists("Tariff.txt"))
            {
                var TariffList = System.IO.File.ReadLines("Tariff.txt").ToList();
                for (int i = 0; i < TariffList.Count; i += 2)
                {
                    string NameText = TariffList[i];

                    TariffBox.Items.Add(NameText);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Номер справочной службы:\n +7 800 555 35 35");
        }

        private void TariffBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var TariffList = System.IO.File.ReadLines("Tariff.txt").ToList();

            int index = TariffBox.SelectedIndex;
            int i = (index + 1) * 2 - 1;

            string TariffText = TariffList[i];
            var OpisList = TariffText.Split('\\').ToList();

            this.TariffText.Clear();

            for (int j = 0; j < OpisList.Count(); j++)
            {
                this.TariffText.Text += OpisList[j].ToString() + "\r\n";
            }
        }

        private void ProblemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ProblemList = System.IO.File.ReadLines("Problem.txt").ToList();

            int index = ProblemBox.SelectedIndex;
            int i = (index + 1) * 2 - 1;

            string ReshText = ProblemList[i];
            var ReshList = ReshText.Split('\\').ToList();

            ProblemText.Clear();

            for (int j = 0; j < ReshList.Count(); j++)
            {
                ProblemText.Text += ReshList[j].ToString() + "\r\n";
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для получения решения проблемы выберите соответствующую проблему в выпадающем окне. " +
                            "После этого в поле ниже появится несколько возможных вариантов решения проблемы.\n\n" +
                            "Если же данные решения Вам не помогли, обратитесь в службу технической поддержки, " +
                            "номер которой будет дан по нажатию соответствующей кнопки.\n\n" +
                            "Также вы можете узнать о существующих на данный момент тарифах подключения к интернету");
        }
    }
}
