using InventoryControl.Forms;
using System;
using System.Windows.Forms;

namespace InventoryControl
{
    public partial class PanelForm : Form
    {
        public PanelForm()
        {
            InitializeComponent();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SellForm form = new SellForm();
            form.Show();
        }
    }
}
