using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ConfigurationWinform
{
    public partial class Form1 : Form
    {
        string key = "test";
        string key2 = "test2";
        string key3 = "test3";
        public Form1()
        {
            InitializeComponent();

            var temp = ConfigurationManager.AppSettings[key];
            this.lbl_result.Text = temp;

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string input = txt_input.Text;
            saveConfiguration(key, input);
            saveConfiguration(key2, input);
            saveConfiguration(key3, input);
            this.lbl_result.Text = loadConfiguration(key);

            TimeSpan.TryParse("09:00:00", out TimeSpan res);

            Boolean.TryParse("True", out Boolean result);
        }

        private void saveConfiguration(string key, string input)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[key].Value = input;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");

        }
        private string loadConfiguration(string key)
        {
            string temp = ConfigurationManager.AppSettings[key];
            return temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Folder> list = new List<Folder>();
            list.Add(new Folder("test1", Apptype.Camera, DateTime.Now.AddHours(1)));
            list.Add(new Folder("test2", Apptype.Camera, DateTime.Now.AddHours(2)));
            list.Add(new Folder("test3", Apptype.Whatsapp, DateTime.Now.AddHours(2)));
            list.Add(new Folder("test4", Apptype.Camera, DateTime.Now.AddHours(3)));
            list.Add(new Folder("test5", Apptype.Camera, DateTime.Now.AddHours(2)));
            list.Add(new Folder("test6", Apptype.Camera, DateTime.Now.AddHours(1)));
            list.Add(new Folder("test6", Apptype.Kakao, DateTime.Now.AddHours(2)));
            list.Add(new Folder("test6", Apptype.Kakao, DateTime.Now.AddHours(2)));
            list.Add(new Folder("test6", Apptype.Kakao, DateTime.Now.AddHours(2)));
            list.Add(new Folder("test6", Apptype.Kakao, DateTime.Now.AddHours(3)));
            int startHour = 9;
            int endHour = 18;

            chart1.ChartAreas[0].AxisX.Minimum = startHour;
            chart1.ChartAreas[0].AxisX.Maximum = endHour;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 10;


            int[] chart_01 = new int[endHour - startHour];
            int[] chart_02 = new int[endHour - startHour];
            int[] chart_03 = new int[endHour - startHour];
            foreach (var item in list)
            {
                switch (item.apptype)
                {
                    case Apptype.Camera:
                        chart_01[item.modifiedDateTime.Hour - startHour] += 1;
                        break;
                    case Apptype.Kakao:
                        chart_02[item.modifiedDateTime.Hour - startHour] += 1;
                        break;
                    case Apptype.Whatsapp:
                        chart_03[item.modifiedDateTime.Hour - startHour] += 1;
                        break;


                }


                chart_03[item.modifiedDateTime.Hour - startHour] += 1;
            }

            for (int i = 0; i < chart_01.Length; i++)
            {
                if (chart_01[i] > 0)
                    chart1.Series[0].Points.AddXY(i + startHour, chart_01[i]);
            }

            for (int i = 0; i < chart_02.Length; i++)
            {
                if (chart_02[i] > 0)

                    chart1.Series[1].Points.AddXY(i + startHour, chart_02[i]);
            }
            for (int i = 0; i < chart_03.Length; i++)
            {
                if (chart_03[i] > 0)
                    chart1.Series[2].Points.AddXY(i + startHour, chart_03[i]);
            }


            chart1.SaveImage("Image", ChartImageFormat.Png);

        }



    }

    enum Apptype
    {
        Camera,
        Whatsapp,
        Kakao
    }
    class Folder
    {
        string name;
        public Apptype apptype;
        public DateTime modifiedDateTime;

        public Folder(string name, Apptype apptype, DateTime dateTime)
        {
            this.name = name;
            this.apptype = apptype;
            this.modifiedDateTime = dateTime;
        }

    }
}
