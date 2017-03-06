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
    public partial class StreamForm : Form
    {
        public StreamForm()
        {
            InitializeComponent();
        }

        //Load the grand total and movie title into the message
        private void StreamForm_Load(object sender, EventArgs e)
        {
            billedAmountLabel.Text = Program.selectedMovie.GrandTotal.ToString("C2");
            selectedMovieLabel.Text = (Program.selectedMovie.Title + ",");
        }

        //exit the application
        private void okButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
