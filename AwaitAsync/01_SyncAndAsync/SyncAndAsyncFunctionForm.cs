using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitAsync
{
    public partial class SyncAndAsyncFunctionForm : Form
    {
        private int CurrentThreadId => Thread.CurrentThread.ManagedThreadId;
        public SyncAndAsyncFunctionForm()
        {
            InitializeComponent();
        }

        private void btnfunc3_Click(object sender, EventArgs e)
        {
            Debug.Print($"버튼 3: {CurrentThreadId}");
            SyncAndAsyncFunction.RunAsync(lbl_func3);
        }

        private void btn_func2_Click(object sender, EventArgs e)
        {
            Debug.Print($"버튼 2: {CurrentThreadId}");
            SyncAndAsyncFunction.RunAsync(lbl_func2);
        }

        private void btn_func1_Click(object sender, EventArgs e)
        {
            Debug.Print($"버튼 1: {CurrentThreadId}");
            SyncAndAsyncFunction.RunAsync(lbl_func1);
        }

        private async void btn_all_Click(object sender, EventArgs e)
        {
            await SyncAndAsyncFunction.RunAllAsync(lbl_func1, listBox1);
            await SyncAndAsyncFunction.RunAllAsync(lbl_func2, listBox1);
            await SyncAndAsyncFunction.RunAllAsync(lbl_func3, listBox1);
        }


    }
}
