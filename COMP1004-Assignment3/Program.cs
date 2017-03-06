using System;
using System.Windows.Forms;

namespace COMP1004_Assignment3
{
    static class Program
    {
        public static SelectedMovie selectedMovie = new SelectedMovie();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectionForm());
        }
    }
}
