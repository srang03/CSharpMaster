
using READDLL;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GetBoardSerialNumberFromCDLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Read rd = new Read();
            Read.GetBoardInfo();
        }

        //[DllImport("BoardInfoDll.dll")]
        //public static extern string GetBoardInfo();


    }
}
