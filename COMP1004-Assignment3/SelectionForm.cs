﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COMP1004_Assignment3
{
    public partial class SelectionForm : Form
    {
        private List<SelectedMovie> _selectedMovie = new List<SelectedMovie>();

        public SelectionForm()
        {
            InitializeComponent();

            //list items with preset data
            _selectedMovie.Add(new SelectedMovie("Cedar Rapids", "Comedy", 1.99, Properties.Resources.CedarRapids));
            _selectedMovie.Add(new SelectedMovie("Season of the Witch", "Sci-Fi", 2.99, Properties.Resources.SeasonOfTheWitch));
            _selectedMovie.Add(new SelectedMovie("The Green Hornet", "Action", 2.99, Properties.Resources.TheGreenHornetPoster));
            _selectedMovie.Add(new SelectedMovie("The Dilemma", "Comedy", 1.99, Properties.Resources.TheDilemma));
            _selectedMovie.Add(new SelectedMovie("Death Race 2", "Action", 2.99, Properties.Resources.DeathRace2));
            _selectedMovie.Add(new SelectedMovie("Company Men", "Drama", 1.99, Properties.Resources.CompanyMen));
            _selectedMovie.Add(new SelectedMovie("No Strings Attached", "Comedy", 1.99, Properties.Resources.NoStringsAttached));
            _selectedMovie.Add(new SelectedMovie("The Way Back", "Drama", 1.99, Properties.Resources.TheWayBack));
            _selectedMovie.Add(new SelectedMovie("The Mechanic", "Action", 2.99, Properties.Resources.TheMechanic));
            _selectedMovie.Add(new SelectedMovie("The Rite", "Horror", 2.99, Properties.Resources.TheRite));
            _selectedMovie.Add(new SelectedMovie("Sanctum", "Action", 2.99, Properties.Resources.Sanctum));
            _selectedMovie.Add(new SelectedMovie("The Other Woman", "Action", 2.99, Properties.Resources.TheOtherWoman));
            _selectedMovie.Add(new SelectedMovie("The Roommate", "Thriller", 1.99, Properties.Resources.Roommate));
            _selectedMovie.Add(new SelectedMovie("Waiting for Forever", "Drama", 1.99, Properties.Resources.WaitingForForever));
            _selectedMovie.Add(new SelectedMovie("Gnomeo and Juliet", "Family", 0.99, Properties.Resources.GnomeoJuliet));
            _selectedMovie.Add(new SelectedMovie("Just Go With It", "Comedy", 1.99, Properties.Resources.JustGoWithIt));
            _selectedMovie.Add(new SelectedMovie("The Eagle", "Action", 2.99, Properties.Resources.TheEagle));
            _selectedMovie.Add(new SelectedMovie("I am Number Four", "Sci-Fi", 2.99, Properties.Resources.IAmNumberFour));
            _selectedMovie.Add(new SelectedMovie("Footloose", "New Release", 4.99, Properties.Resources.Footloose));
            _selectedMovie.Add(new SelectedMovie("Real Steel", "New Release", 4.99, Properties.Resources.RealSteel));

            //disable the Next button
            nextButton.Enabled = false;
        }

        /// <summary>
        /// Update the form to show the user's selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void currentMoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if no selection has been made yet, do not enable the Next button
            if (currentMoviesListBox.Text == "")
            {
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
            }

            //add the user's selection to the title textbox
            titleTextBox.Text = currentMoviesListBox.Text;

            //search the list for a movie with the user's selected title and populate the category, cost, and poster fields
            foreach (SelectedMovie selectedMovie in _selectedMovie)
            {
                if (selectedMovie.Title == titleTextBox.Text)
                {
                    categoryTextBox.Text = selectedMovie.Category;
                    costTextBox.Text = (selectedMovie.Cost).ToString("C2");
                    posterPictureBox.Image = selectedMovie.Poster;
                }
            }
        }

        /// <summary>
        /// Proceed to next next form, hiding the current one
        /// Save the user's choice into the SelectedMovie class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            Program.selectedMovie.Title = titleTextBox.Text;
            Program.selectedMovie.Category = categoryTextBox.Text;
            Program.selectedMovie.Cost = Convert.ToDouble(costTextBox.Text.Substring(1));
            Program.selectedMovie.Poster = posterPictureBox.Image;

            Hide();

            OrderForm orderForm = new OrderForm();
            
            orderForm.Show();
        }
    }
}
