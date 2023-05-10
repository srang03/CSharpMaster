using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_AsyncAwait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void RunAnythingWithSync(Label label)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                label.Text = i.ToString();
                label.Refresh();
            }
        }

        private async void RunAnythingWithAsync(Label label)
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                label.Text = i.ToString();
                //label.Refresh();
            }
        }

        // Task를 반환해야 await 키워드를 사용할 수 있음
        private async Task RunAllAsync(Label label)
        {
            for (int i = 0; i < 20; i++)
            {
                await Task.Delay(100);
                listBox1.Items.Add($"{i.ToString()} {label.Text}");
            }
        }

        private void btn_run1(object sender, EventArgs e)
        {
            RunAnythingWithAsync(this.lbl_walking);
        }

        private void btn_run2(object sender, EventArgs e)
        {
            RunAnythingWithAsync(this.lbl_phone);
        }

        private void btn_run3(object sender, EventArgs e)
        {
            RunAnythingWithAsync(this.lbl_talking);
        }

        private async void btn_all_Click(object sender, EventArgs e)
        {
            await RunAllAsync(this.lbl_walking);
            await RunAllAsync(this.lbl_phone);
            await RunAllAsync(this.lbl_talking);
        }
    }
}
