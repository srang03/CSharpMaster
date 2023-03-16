using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitAsync
{
    public partial class CancellationTokenForm : Form
    {
        CancellationTokenSource tokenSource;
        public CancellationTokenForm()
        {
            InitializeComponent();

        }

        private async Task RunAsync(CancellationToken token)
        {
            await Task.Run(() =>
            {
                while (true)
                {
                    token.ThrowIfCancellationRequested();
                    Thread.Sleep(100);
                    if (label1.InvokeRequired) label1.Invoke(new Action(delegate
                    {
                        label1.Text = (Int32.Parse(label1.Text) + 1).ToString();
                    }));
                    else label1.Text = (Int32.Parse(label1.Text) + 1).ToString();
                }
            });
        }


        private  void CancellationTokenForm_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            try
            {
                await RunAsync(token);
            }
            catch(OperationCanceledException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }
    }
}

