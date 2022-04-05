using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var hobbit = new List<string> { " Tolkien "};
            var book = new Book("The Help");
            var book2 = new Book("The Hobbit", hobbit, "Houghton Mifflin Harcourt", 300, "paperback", "09/18/2012", "fantasy");

            var movie = new Movie("The Help", hobbit, "Company", "year", "unknown");
            var library = new List<Media> { book, book2, movie }; // seems to work
            Media.ShowAll(library);
            Media.SearchByID(library, 1);
            Media.SearchByTitle(library, "The Hobbit");
            Media.SearchByID(library, 3);
        }
    }
}
