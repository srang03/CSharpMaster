using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitAsync._04_Task
{
    public partial class TaskWhenWhenAny : Form
    {
        public TaskWhenWhenAny()
        {
            InitializeComponent();
        }

        private void TaskWhenWhenAny_Load(object sender, EventArgs e)
        {
            PlayerClear();
        }

        private void PlayerClear()
        {
            this.label1.Left = 110;
            this.label2.Left = 110;
            this.label3.Left = 110;
            this.label4.Left = 110;
        }

        private void Run(Label lbl, byte speed)
        {
            int endPosition = panel1.Left;
            while(lbl.Left < endPosition)
            {
                Thread.Sleep(100);
                lbl.Left = lbl.Left + (10 * speed);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Run(this.label1, 1);
        }
    }
}
