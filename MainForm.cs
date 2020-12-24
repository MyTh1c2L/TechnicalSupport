using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            if(System.IO.File.Exists("Problem.txt"))
            {
                var ProblemList = System.IO.File.ReadLines("Problem.txt").ToList();
                DataBase.Initialize1(ProblemList);

                for (int i = 0; i < ProblemList.Count; i += 2)
                {
                    string NameText = ProblemList[i];

                    ProblemBox.Items.Add(NameText);
                }

                if (System.IO.File.Exists("Tariff.txt"))
                {
                    var TariffList = System.IO.File.ReadLines("Tariff.txt").ToList();
                    DataBase.Initialize2(TariffList);

                    for (int i = 0; i < TariffList.Count; i += 2)
                    {
                        string NameText = TariffList[i];

                        TariffBox.Items.Add(NameText);
                    }
                }
                else
                {
                    MessageBox.Show("Отсутствуют данные про наши возможные тарифы\n" +
                        "Пожалуйста, обновите информацию в соответствующем пункте");
                }
            }
            else if (System.IO.File.Exists("Tariff.txt"))
            {
                var TariffList = System.IO.File.ReadLines("Tariff.txt").ToList();
                DataBase.Initialize2(TariffList);

                for (int i = 0; i < TariffList.Count; i += 2)
                {
                    string NameText = TariffList[i];

                    TariffBox.Items.Add(NameText);
                }

                MessageBox.Show("Отсутствуют данные о возможных проблемах и их решениях\n" +
                        "Пожалуйста, обновите информацию в соответствующем пункте");
            }
            else
            {
                MessageBox.Show("Отсутствуют все необходимые данные для работы программы\n" +
                                "Пожалуйста, обновите информацию в соответствующем пункте");
            }

            timer1.Enabled = true;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Номер справочной службы:\n +7 800 555 35 35");
        }

        private void ProblemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ProblemBox.SelectedIndex;
            string ProblemText = DataBase.Problem(index);

            var ProblemList = ProblemText.Split('\\').ToList();
            this.ProblemText.Clear();

            for (int j = 0; j < ProblemList.Count(); j++)
            {
                this.ProblemText.Text += ProblemList[j].ToString() + "\r\n";
            }
        }

        private void TariffBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TariffBox.SelectedIndex;
            string TariffText = DataBase.Tariff(index);

            var TariffList = TariffText.Split('\\').ToList();
            this.TariffText.Clear();

            for (int j = 0; j < TariffList.Count(); j++)
            {
                this.TariffText.Text += TariffList[j].ToString() + "\r\n";
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для получения решения проблемы выберите соответствующую проблему в выпадающем окне. " +
                            "После этого в поле ниже появится несколько возможных вариантов решения проблемы.\n\n" +
                            "Если же данные решения Вам не помогли, обратитесь в службу технической поддержки, " +
                            "номер которой будет дан по нажатию соответствующей кнопки.\n\n" +
                            "Также вы можете узнать о существующих на данный момент тарифах подключения к интернету и " +
                            "о вашей текущей скорости Интернет-подключения.\n\n" +
                            "Вы можете обновить базу данных с данными о тарифах и проблемах из программы в " +
                            "соответствующем пункте в левом верхнем углу.");
        }

        private void бДПроблемИИхРешенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            if (filePath != "")
            {
                var ProblemList = System.IO.File.ReadLines(@filePath).ToList();
                System.IO.File.WriteAllLines("Problem.txt", ProblemList);

                ProblemBox.Items.Clear();
                ProblemText.Clear();

                DataBase.Initialize1(ProblemList);

                for (int i = 0; i < ProblemList.Count; i += 2)
                {
                    string NameText = ProblemList[i];

                    ProblemBox.Items.Add(NameText);
                }
            }
        }

        private void бДТарифовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
            }
            if (filePath != "")
            {
                var TariffList = System.IO.File.ReadLines(@filePath).ToList();
                System.IO.File.WriteAllLines("Tariff.txt", TariffList);

                TariffBox.Items.Clear();
                TariffText.Clear();

                DataBase.Initialize2(TariffList);

                for (int i = 0; i < TariffList.Count; i += 2)
                {
                    string NameText = TariffList[i];

                    TariffBox.Items.Add(NameText);
                }
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            Internet i = new Internet();

            string result = await Task.Factory.StartNew<string>(
                                             () => i.Speed());

            this.Speedlabel.Text = result;
        }
    }
}
