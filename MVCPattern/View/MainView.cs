using MVCPattern.Controller;
using MVCPattern.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MVCPattern.View
{
    public partial class MainView : UserControl, IMainView
    {
        private MainController _controller;
        public MainView()
        {
            InitializeComponent();
        }

        public IEnumerable<Staff> ItemSource { get => (IEnumerable<Staff>)dataGridView1.DataSource; set => dataGridView1.DataSource = value; }
        string IMainView.ID { get => txb_id.Text; set => txb_id.Text = value; }
        string IMainView.Name { get => txb_name.Text.Trim(); set => txb_name.Text = value.Trim(); }
        int IMainView.Age { get { int.TryParse(txb_age.Text, out int value); return value; } set => txb_age.Text = value.ToString(); }
        bool IMainView.Active { get => cbx_active.Checked; set => cbx_active.Checked = value; }

        public void SetController(MainController controller)
        {
            _controller = controller;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _controller.Cancel();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_controller.Delete())
            {
                _controller.Cancel();
                _controller.Display();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (_controller.Save())
            {
                _controller.Cancel();
                _controller.Display();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainView_Load(object sender, EventArgs e)
        {
            _controller.Display();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;

            var temp = dataGridView1.Rows[e.RowIndex];
        }
    }
}
