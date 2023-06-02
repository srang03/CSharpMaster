using ExampleMVC.Controller;
using ExampleMVC.Model;
using ExampleMVC.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleMVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UserView Userview = new UserView();
            IStringRepository repository = new StringRepository();
            IStringController controller = new StringController(Userview, repository);
            this.panel1.Controls.Add(Userview);
        }
    }
}
