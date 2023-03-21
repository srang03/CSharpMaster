using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AwaitAsync
{
    public class SyncAndAsyncFunction
    {
        public static void Run(Label lbl)
        {
            for(int i = 0; i < 30; i++)
            {
                Thread.Sleep(100);
                lbl.Text = i.ToString();
                lbl.Refresh();
            }    
        }

        public async static void RunWithawait(Label lbl)
        {
            for (int i = 0; i< 30; i++) 
            {
                await Task.Delay(100);
                lbl.Text = i.ToString();
            }
        }


        public async static void RunAsync(Label lbl)
        {
            await Task.Run(() =>
            {
                for(int i = 0; i< 30; i++)
                {
                    Thread.Sleep(100);
                    if (lbl.InvokeRequired) lbl. Invoke(new Action(delegate
                    {
                        lbl.Text = i.ToString();
                    }));
                    else lbl.Text = i.ToString();
                }
            });
        }
        
        public async static Task RunAllAsync(Label lbl, ListBox lb)
        {
            await Task.Run(() =>
            {
                for(int i = 0; i< 30; i++)
                {
                    Thread.Sleep(100);
                    if (lb.InvokeRequired) lbl.Invoke(new Action(delegate
                    {
                        lb.Items.Add($"{lbl.Name}: {i}");
                    }));
                    else
                    {
                        lb.Items.Add($"{lbl.Name}: {i}");
                    }
                }
            });
                
        }
    }
}
