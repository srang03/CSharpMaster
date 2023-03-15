using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_WhenAll_WhenAny
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        private double ArriveTime => Math.Round(sw.ElapsedMilliseconds / 1000d, 2);
        public Form1()
        {
            InitializeComponent();
            ResetBugs();
        }

        private void Start()
        {
            sw.Start();
            ClearLogs();
            ResetBugs();
        }

        private void End()
        {
            AddLogs($"총 소요시간은 : {ArriveTime} 초");
            sw.Stop();
            sw.Reset();
        }

        private void ResetBugs()
        {
            var labels = new List<Label> { label1, label2, label3, label4 };
            foreach( var label in labels )
            {
                label.Left = 100;

            }
            
        }

        private void ClearLogs()
        {
            this.listBox1.Items.Clear();
        }

        private void AddLogs(params string[] texts) => this.listBox1.Items.AddRange(texts);
        private void AddLog(string text) => this.listBox1.Items.Add(text);

        private async Task<string> MoveLabel(Label label, int speed)
        {
            int endX = line.Left - label.Width;
            while(label.Left < endX)
            {

                label.Location = new Point(label.Left + speed * 4, label.Top);
                await Task.Delay(10);
            }
            label.Left = endX;
            return $"{label.Text} 도착시간: {ArriveTime}초";
        }
        

        private async void button1_Click(object sender, EventArgs e)
        {
            Start();
            AddLog(await MoveLabel(label1, 1));
            AddLog(await MoveLabel(label2, 2));
            AddLog(await MoveLabel(label3, 3));
            AddLog(await MoveLabel(label4, 4));
            End();

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            Start();
            Task<string> t1 = MoveLabel(label1, 1);
            Task<string> t2 = MoveLabel(label2, 2);
            var results = await Task.WhenAll(t1, t2);
            AddLogs(results);

            Task<string> t3 = MoveLabel(label3, 3);
            Task<string> t4 = MoveLabel(label4, 4);

            results = await Task.WhenAll(t3, t4);
            AddLogs(results);

            End();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Start();
            Task<string> t1 = MoveLabel(label1, 1);
            Task<string> t2 = MoveLabel(label2, 2);
            Task<string> t3 = MoveLabel(label3, 3);
            Task<string> t4 = MoveLabel(label4, 4);

            AddLog(await t1);
            AddLog(await t2);
            AddLog(await t3);
            AddLog(await t4);
            
            End();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            Start();
            Task<string> t1 = MoveLabel(label1, 1);
            Task<string> t2 = MoveLabel(label2, 2);
            Task<string> t3 = MoveLabel(label3, 3);
            Task<string> t4 = MoveLabel(label4, 4);

            var tasks = new List<Task>() { t1, t2, t3, t4 };

            while (tasks.Count > 0)
            {
                Task task = await Task.WhenAny(tasks);

                string log = await(Task<string>)task;
                AddLogs(log);

                tasks.Remove(task);
            }

            End();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void space_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Cursor.Position.X.ToString());
            Console.WriteLine(Cursor.Position.Y.ToString()); 
        }
    }
}
