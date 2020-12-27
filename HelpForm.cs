﻿using System;
using System.Windows.Forms;

namespace TechnicalSupport
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {
            HelpText.Text = "Для получения решения проблемы нажмите соответствующую кнопку. Откроется окно, в котором " +
                            "предлагаются несколько проблем на выбор в выпадающем окне. " +
                            "После этого в поле ниже появится несколько возможных вариантов решения проблемы.\r\n\r\n" +
                            "Если же данные решения Вам не помогли, обратитесь в службу технической поддержки, " +
                            "номер которой вы можете увидеть на главном окне программы. Там же указан адрес электронной почты.\r\n\r\n" +
                            "Также вы можете узнать о существующих на данный момент тарифах подключения к интернету и " +
                            "о вашей текущей скорости Интернет-подключения.\r\n\r\n" +
                            "Вы можете обновить базу данных с данными о тарифах и проблемах из программы в " +
                            "соответствующем пункте.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
