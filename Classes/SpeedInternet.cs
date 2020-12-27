using System;

namespace TechnicalSupport
{
    public class Internet
    {
        public double InternetSpeed()
        {
            System.Net.WebClient wc = new System.Net.WebClient();

            DateTime dt1 = DateTime.Now;

            byte[] data = wc.DownloadData("http://yandex.ru");

            DateTime dt2 = DateTime.Now;

            return Math.Round((data.Length / 1024) / (dt2 - dt1).TotalSeconds, 2);
        }

        public string Speed()
        {
            string textspeed = InternetSpeed() + " КБ/с";

            return textspeed;
        }
    }
}
