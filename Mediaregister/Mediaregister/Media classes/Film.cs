namespace Mediaregister
{
    class Film : Media
    {
        private string director;
        private int watchTime;

        public Film(string title, string director, int legnth)
        {
            this.Title = title;
            this.director = director;
            this.watchTime = legnth;
        }


        public override string ToString()
        {
            return $"{Title} ({director}, {watchTime} minutes)";
        }
    }
}
