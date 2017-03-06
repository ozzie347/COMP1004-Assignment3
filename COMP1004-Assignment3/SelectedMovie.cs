namespace COMP1004_Assignment3
{
    public class SelectedMovie
    {
        //Variables
        public string Title { get; set; }
        public string Category { get; set; }
        public double Cost { get; set; }
        public System.Drawing.Image Poster { get; set; }

        //Default Constructor
        public SelectedMovie()
        {

        }

        //Constructor
        public SelectedMovie(string title, string category, double cost, System.Drawing.Image poster)
        {
            Title = title;
            Category = category;
            Cost = cost;
            Poster = poster;
        }
    }
}