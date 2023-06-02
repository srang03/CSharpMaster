using ExampleMVC.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleMVC.View
{
    public partial class UserView : UserControl, IView
    {
        IStringController _controller;

        public UserView()
        {
            InitializeComponent();
        }

        void IView.SetController(IStringController controller)
        {
            _controller = controller;
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            string value = txb_result.Text;
            _controller.ChangeValue(value);
            txb_result.Text = _controller.GetValue();
        }
    }
}
