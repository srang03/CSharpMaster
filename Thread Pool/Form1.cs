using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Thread_Pool.FileUtil;

namespace Thread_Pool
{
    public partial class Form1 : Form
    {
        private const string SOURCE_FILE = "ArtEx.zip";
        private const string DESTINATION_FILE = "ArtEx2.zip";
        private int CurrentThreadId => Thread.CurrentThread.ManagedThreadId;

        public Form1()
        {
            InitializeComponent();
        }



        private async Task FileCopyBackAsyc()
        {
            await Task.Run(() =>
            {
                Debug.Print($"시작: {CurrentThreadId}");
                FileUtil.Copy(SOURCE_FILE, DESTINATION_FILE, fileProgress: FileProgress);
            });
        }


        private async void btn_backgroundThread_Click(object sender, EventArgs e)
        {
            Debug.Print($"FileCopey: {CurrentThreadId}");
            await FileCopyBackAsyc();
        }

        private void FileProgress(string currentUnits, string TotalUnits, int Percentage)
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new FileProgressDelegate(FileProgress), currentUnits, TotalUnits, Percentage);
            }
            else
            {
                label2.Text = $"{currentUnits} / {TotalUnits} ({Percentage}%)";
                progressBar2.Value = Percentage;
            }
        }
    }
}
