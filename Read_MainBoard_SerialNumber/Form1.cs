using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_MainBoard_SerialNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var managementObjectSearcher = new ManagementObjectSearcher("SELECT Product, SerialNumber From Win32_BaseBoard");
            var sb = new StringBuilder();
            foreach (var managementObject in managementObjectSearcher.Get())
            {
                foreach(var data in managementObject.Properties)
                {
                    var name = data.Name;
                    var value = data.Value;
                }
            }
            textBox1.Text = sb.ToString();

            sb.Clear();
        }
    }
}
