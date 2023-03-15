using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thread_Pool
{
    public partial class Form1 : Form
    {
        private const string SOURCE_FILE = "android-studio-2022.1.1.21-windows.exe";
        private const string DESTINATION_FILE = "android-studio-2022.1.1.21-windows2.exe";
        private int CurrentThreadId => Thread.CurrentThread.ManagedThreadId;

        public Form1()
        {
            InitializeComponent();
        }


        private async Task FileCopyBackAsyc()
        {
            await Task.Run(() =>
            {
                FileUtil.Copy(SOURCE_FILE, DESTINATION_FILE, fileProgress: FileProgress);
                Debug.Print($"시작: {CurrentThreadId}");
            });
        }


        private async void btn_backgroundThread_Click(object sender, EventArgs e)
        {
            Debug.Print($"FileCopey: {CurrentThreadId}");
            await FileCopyBackAsyc();
        }

        private void FileProgress(string currentUnits, string TotalUnits, int Percentage)
        {
            if (this.label2.InvokeRequired)
            {
                this.label2.Invoke(new MethodInvoker(delegate
                {
                    label2.Text = $"{currentUnits} / {TotalUnits} ({Percentage}%)";
                    progressBar2.Value = Percentage;

                }));

            }
            else
            {
                label2.Text = $"{currentUnits} / {TotalUnits} ({Percentage}%)";
                progressBar2.Value = Percentage;
            }
        }
    }
}
