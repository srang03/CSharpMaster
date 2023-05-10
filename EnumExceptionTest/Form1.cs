using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumExceptionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(this.textBox1.Text, out int value))
            {
                if(typeof(AnalysisMethod).IsEnumDefined(value))
                {
                    var temp = (AnalysisMethod)value;
                }
            }
        }
    }

    enum AnalysisMethod
    {
        Basic  = 1,
        Detail = 2
    }
}
