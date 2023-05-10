using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_CAncellationTokenSource
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts;
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            var token = cts.Token;

            await DoWorkAsync(token);
            this.lbl_result.Text = "0";
            await DoWorkAsync2(token);
        }

        private async Task DoWorkAsync(CancellationToken token)
        {
            bool isRun = false;
            while (!isRun)
            {
                if (token.IsCancellationRequested)
                {
                    isRun = true;
                    return;
                }
                await Task.Delay(200);
                int.TryParse(this.lbl_result.Text, out int value);
                this.lbl_result.Text = (value + 1).ToString();
                if (value == 10)
                {
                    isRun = true;
                }
            }

        }

        private async Task DoWorkAsync2(CancellationToken token)
        {
            bool isRun = false;
            while (!isRun)
            {
                if (token.IsCancellationRequested)
                {
                    isRun = true;
                    return;
                }
                await Task.Delay(200);
                int.TryParse(this.lbl_result.Text, out int value);
                this.lbl_result.Text = (value + 1).ToString();
                if (value == 10)
                {
                    isRun = true;
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }
    }
}
