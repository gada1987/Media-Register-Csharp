namespace Mediaregister
{
    class Book : Media
    {
        private string author;
        private int nrOfPages;

        public Book(string title, string author, int nrOfPages)
        {
            this.Title = title;
            this.author = author;
            this.nrOfPages = nrOfPages;
        }

        public override string ToString()
        {
            return $"{Title} ({author}, {nrOfPages} pages)";
        }
    }
}
