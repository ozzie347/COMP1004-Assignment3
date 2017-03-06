using System;
using System.Windows.Forms;

namespace COMP1004_Assignment3
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        //Cancel button will exit the user from the app
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Proceed to the next form with the user's choice of movie
        /// Hide the current form, show the next
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void streamButton_Click(object sender, EventArgs e)
        {
            //save the grand total to the selectedmovie class
            Program.selectedMovie.GrandTotal = Convert.ToDouble(grandTotalTextBox.Text.Substring(1));

            Hide();

            StreamForm streamForm = new StreamForm();

            streamForm.Show();
        }

        //Show the user a print preview(mock)
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print preview for the order", "Print Preview", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }

        //Show the user the AboutBox
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        /// <summary>
        /// Takes the user back to the selection form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm();

            Hide();

            selectionForm.Show();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            titleTextBox.Text = Program.selectedMovie.Title;
            categoryTextBox.Text = Program.selectedMovie.Category;
            posterPictureBox.Image = Program.selectedMovie.Poster;
            costTextBox.Text = Program.selectedMovie.Cost.ToString("C2");
            dvdTextBox.Text = "$0";
            subtotalTextBox.Text = (Program.selectedMovie.Cost + Convert.ToDouble(dvdTextBox.Text.Substring(1))).ToString("C2");
            salesTaxTextBox.Text = ((Program.selectedMovie.Cost + Convert.ToDouble(dvdTextBox.Text.Substring(1))) * 0.13).ToString("C2");
            grandTotalTextBox.Text = (Program.selectedMovie.Cost + Convert.ToDouble(dvdTextBox.Text.Substring(1)) + Convert.ToDouble(salesTaxTextBox.Text.Substring(1))).ToString("C2");
        }

        private void addDVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(addDVDCheckBox.Checked == true)
            {
                dvdLabel.Visible = true;
                dvdTextBox.Visible = true;
                dvdTextBox.Text = "$10";
                subtotalTextBox.Text = (Program.selectedMovie.Cost + Convert.ToDouble(dvdTextBox.Text.Substring(1))).ToString("C2");
                salesTaxTextBox.Text = ((Program.selectedMovie.Cost + Convert.ToDouble(dvdTextBox.Text.Substring(1))) * 0.13).ToString("C2");
                grandTotalTextBox.Text = (Program.selectedMovie.Cost + Convert.ToDouble(dvdTextBox.Text.Substring(1)) + Convert.ToDouble(salesTaxTextBox.Text.Substring(1))).ToString("C2");
            }
            else if(addDVDCheckBox.Checked == false)
            {
                dvdLabel.Visible = false;
                dvdTextBox.Visible = false;
                dvdTextBox.Text = "$0";
                subtotalTextBox.Text = (Program.selectedMovie.Cost + Convert.ToDouble(dvdTextBox.Text.Substring(1))).ToString("C2");
                salesTaxTextBox.Text = ((Program.selectedMovie.Cost + Convert.ToDouble(dvdTextBox.Text.Substring(1))) * 0.13).ToString("C2");
                grandTotalTextBox.Text = (Program.selectedMovie.Cost + Convert.ToDouble(dvdTextBox.Text.Substring(1)) + Convert.ToDouble(salesTaxTextBox.Text.Substring(1))).ToString("C2");
            }
        }
    }
}
