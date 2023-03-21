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

namespace SyncAndAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_func_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            await Task.Run(() => { Run(btn); });

        }

   
        private void Run(Button btn)
        {
            int count = 0;
            while(count < 10)
            {
                Thread.Sleep(100);
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(delegate
                    {
                        this.listBox1.Items.Add($"{btn.Text}: {++count}");
                    }));
                }

            }
        }

        private async Task RunAsync(Button btn)
        {
            int count = 0;
            while (count < 10)
            {
                await Task.Delay(500);
                this.listBox1.Items.Add($"{btn.Text}: {++count}");
            }
        }

        private async Task RunAsyncAwait(Button btn)
        {
            int count = 0;
            await Task.Run(() =>
            {
                while (count < 10)
                {
                    Thread.Sleep(500);
                    if(this.InvokeRequired)
                    {
                        this.Invoke(new Action(delegate
                        {
                            this.listBox1.Items.Add($"{btn.Text}: {++count}");
                        }));
                    }
                }
            });
        }
    }
}
