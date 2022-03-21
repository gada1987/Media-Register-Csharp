using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mediaregister
{
    static class MediaHandler
    {
        static public Filter filter;

        public enum Filter
        {
            all,
            books,
            films
        }

        static public void AddBook(Profile profile, string title, string author, decimal nrOfPages)
        {
            if (!ValidateMedia(profile, (int)nrOfPages, title, author)) return; // Control name
            profile.mediaList.Add(new Book(title, author, (int)nrOfPages)); // Add new book

        }

        static public void AddFilm(Profile profile, string title, string director, decimal watchTime)
        {
            if (!ValidateMedia(profile, (int)watchTime, title, director)) return; // Control name
            profile.mediaList.Add(new Film(title, director, (int)watchTime)); // Add new film
        }

        static public bool ValidateMedia(Profile profile, int legnth, string title, string creator)
        {
            // Validate inputs, throw error otherwise
            string errorMessage = "All fields need to be filled.";
            if (legnth <= 0) { Form1.ThrowError(errorMessage); return false; } // If legnth = 0
            if (title.Length == 0) { Form1.ThrowError(errorMessage); return false; } // If title = 0
            if (creator.Length == 0) { Form1.ThrowError(errorMessage); return false; } // If creator = 0
            if (profile == null) { Form1.ThrowError("No profile selected"); return false; } // If no profile selected
            return true;
        }

        static public void Display(Profile profile, RichTextBox rtf)
        {
            List<Book> bookList = new List<Book>();
            List<Film> filmList = new List<Film>();

            // Sort books and films
            if (profile != null)
            {
                foreach (var item in profile.mediaList)
                {
                    if (item is Book) bookList.Add((Book)item);
                    else if (item is Film) filmList.Add((Film)item);
                }

                // Filter
                switch (filter)
                {
                    case Filter.all:
                        rtf.Text = ToString(profile.mediaList.ToArray());
                        break;
                    case Filter.books:
                        rtf.Text = ToString(bookList.ToArray());
                        break;
                    case Filter.films
    :
                        rtf.Text = ToString(filmList.ToArray());
                        break;
                    default:
                        break;
                }
            }
        }

        static private string ToString(Array array)
        {
            // Return array as string
            string ret = "";
            foreach (var item in array) ret += item.ToString() + "\n";
            return ret;
        }
    }
}
