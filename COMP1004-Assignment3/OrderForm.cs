using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_Assignment3
{
    public partial class OrderForm : Form
    {
        public SelectionForm previousForm { get; set; }

        public OrderForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void streamButton_Click(object sender, EventArgs e)
        {
            Hide();

            StreamForm streamForm = new StreamForm();

            streamForm.Show();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print preview for the order", "Print Preview", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
    }
}
