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

namespace AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run(string name)
        {
            for(int i = 0; i < 30; i++) 
            {
                Thread.Sleep(100);
                lbx_list.Items.Add($"[{name}] {i}");
                lbx_list.Refresh();
            }
        }

        private async void RunAsync(string name)
        {
            for (int i = 0; i < 30; i++)
            {
                await Task.Delay(100);
                lbx_list.Items.Add($"[{name}] {i}");
            }
        }

        private string GetButtonText(object sender)
        {
            Button button = (Button)sender;
            return button.Text;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            RunAsync(GetButtonText(sender));
        }

        private void btn_Listening_Click(object sender, EventArgs e)
        {
            RunAsync(GetButtonText(sender));
        }

        private void btn_Dance_Click(object sender, EventArgs e)
        {
            RunAsync(GetButtonText(sender));
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.lbx_list.Items.Clear();
        }
    }
}
