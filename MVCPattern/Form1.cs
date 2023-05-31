using MVCPattern.Controller;
using MVCPattern.Model;
using MVCPattern.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MainView_Click(object sender, EventArgs e)
        {
            var mainView = new MainView();
            var personRepository = new StaffRepository();
            var mainController = new MainController(mainView, personRepository);
            this.panel1.Controls.Add(mainView);
        }
    }
}
