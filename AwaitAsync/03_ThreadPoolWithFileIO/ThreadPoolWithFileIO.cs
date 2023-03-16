using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitAsync
{
    public partial class ThreadPoolWithFileIO : Form
    {
        string fileName = "android-studio-2022.1.1.21-windows.exe";

        public ThreadPoolWithFileIO()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await CopyFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private async Task CopyFile()
        {
            await Task.Run(() =>
            {
                FileUtil.FileCopy(fileName, $"{fileName}2", FileProgress);
            });
        }

        private void FileProgress(string currentUnit, string TotalUnit, int percent)
        {
            if (this.InvokeRequired) this.Invoke(new Action(delegate
            {
                this.label1.Text = $"{currentUnit} / {TotalUnit} ({percent}%)";
                progressBar1.Value = percent;
            }));
            else this.label1.Text = $"{currentUnit} / {TotalUnit} ({percent}%)";

        }

        private void ThreadPoolWithFileIO_Load(object sender, EventArgs e)
        {

        }
    }
}
