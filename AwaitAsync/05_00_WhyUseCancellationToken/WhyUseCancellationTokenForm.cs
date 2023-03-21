using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitAsync._05_WhyUseCancellationToken
{
    public partial class WhyUseCancellationTokenForm : Form
    {
        private CancellationTokenSource _cts;
        public WhyUseCancellationTokenForm()
        {
            InitializeComponent();
        }

        private void SetProgressBar(ProgressBar pb, Label lbl, int count) {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    pb.Value = count;
                    lbl.Text = $"{count}%";
                }));
            }
            else
            {
                pb.Value = count;
                lbl.Text = $"{count}%";
            }
        }

        private void temp(int count)
        {
            SetProgressBar(this.progressBar1, lbl_progress1, count);
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            CancellationToken token = _cts.Token;

             await new ZeroToHundredManager().Run(temp, token);
            await Task.Delay(1000);
            await new HundredManagerToZero().Run((count) => SetProgressBar(this.progressBar2, lbl_progress2, count), token);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
        }
    }
}
