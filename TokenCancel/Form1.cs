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

namespace TokenCancel
{
    public partial class Form1 : Form
    {
        // 비동기 취소 : CancellationTokenSource
        // 비동기 취소 여부 추적 : CancellationToken

        CancellationTokenSource cts;
        public Form1()
        {
            InitializeComponent();
        }

        private async Task DoWorkAsync(CancellationToken token)
        {
            //while(!token.IsCancellationRequested)
            //{
            //    await Task.Delay(100);
            //    int.TryParse(lbl_value.Text, out int value);
            //    lbl_value.Text = (value += 1).ToString();
            //}

            while (true)
            {
                token.ThrowIfCancellationRequested();
                await Task.Delay(100);
                int.TryParse(lbl_value.Text, out int value);
                lbl_value.Text = (value += 1).ToString();
            }
        }

        private async void btn_start_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            var token = cts.Token;
            try
            {
                await DoWorkAsync(token);
            }
            catch(OperationCanceledException)
            {
                MessageBox.Show("Token Cancel");
            }
            catch
            {
                MessageBox.Show("Exception");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if(cts.Token != null)
            {
                cts.Cancel();
            }
        }
    }
}
