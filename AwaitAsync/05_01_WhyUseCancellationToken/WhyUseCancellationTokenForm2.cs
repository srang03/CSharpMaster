using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitAsync._05_01_WhyUseCancellationToken
{
    public partial class WhyUseCancellationTokenForm2 : Form
    {
        CancellationTokenSource cts;
        public WhyUseCancellationTokenForm2()
        {
            InitializeComponent();
            Initation();
          
        }

        private void Initation()
        {
            this.progressBar1.Value = 0;
            this.progressBar2.Value = 100;
            this.lbl_pb1.Text = $"0%";
            this.lbl_pb2.Text = $"100%";
        }

        private void RunProgressBar(ProgressBar progressBar, Label lbl, int count) 
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(delegate
                {
                    progressBar.Value = count;
                    lbl.Text = $"{count}%";
                }));
            }
            else
            {
                progressBar.Value = count;
                lbl.Text = $"{count}%";
            }
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            List<Task> tasks = new List<Task>();
            Task t1 = new ZeroToHundredManager().Run((count)=> RunProgressBar(progressBar1, lbl_pb1, count), token);
            Task t2 = new HundredToOnManager().Run((count)=> RunProgressBar(progressBar2, lbl_pb2, count), token);

            tasks.Add(t1);
            tasks.Add(t2);

            await Task.WhenAll(tasks);

        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        private void WhyUseCancellationTokenForm2_Load(object sender, EventArgs e)
        {

        }

        private void WhyUseCancellationTokenForm2_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts.Cancel();
        }
    }

    public class ZeroToHundredManager
    {
        public async Task Run(Action<int> func, CancellationToken token)
        {
            int count = 0;
            func?.Invoke(count);

            await Task.Run(() =>
            {
                while (count < 100)
                {
                    if(token.IsCancellationRequested) break;
                    func?.Invoke(++count);
                    Thread.Sleep(50);
                }
            });
        }
    }

    public class HundredToOnManager
    {
        public async Task Run(Action<int> func, CancellationToken token)
        {
            int count = 100;
            func?.Invoke(count);

            await Task.Run(() =>
            {
                while (count > 0) { 
                    if (token.IsCancellationRequested) break;
                    func?.Invoke(--count);
                    Thread.Sleep(50);
                }
            });
        }
    }
}
