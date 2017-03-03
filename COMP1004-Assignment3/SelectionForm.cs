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
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Program.userSelections[0] = titleTextBox.Text;
            Program.userSelections[1] = categoryTextBox.Text;
            Program.userSelections[2] = costTextBox.Text;

            Hide();

            OrderForm orderForm = new OrderForm();

            orderForm.Show();
        }
    }
}
