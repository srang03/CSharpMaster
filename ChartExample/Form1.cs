using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, },
                StrokeThickness = 4,

            }) ;

            
        }
    }
}
