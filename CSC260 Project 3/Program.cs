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
            //test code
            // still have to do "formal" tests
            /*
            var hobbit = new List<string> { " Tolkien "};
            var book = new Book("The Help");
            var book2 = new Book("The Hobbit", hobbit, "Houghton Mifflin Harcourt", 300, "paperback", "09/18/2012", "fantasy");

            var movie = new Movie("The Help", hobbit, "Company", "year", "unknown");
            var library = new List<Media> { book, book2, movie }; // seems to work
            Media.ShowAll(library);
            Media.SearchByID(library, 1);
            Media.SearchByTitle(library, "The Hobbit");
            Media.SearchByID(library, 3);*/

            /* what do I have to do?--make a menu, make it take user input, 
             * reject "bad" input (that can happen automatically, in a final else statement),
             * have a section of code for handling each valid type of user input,
             * many sections need to accept extra user input (like a title for a new item, 
             * or for an item they want to delete), an exit option (can make that a valid-input-
             * handling code section), a loop to wrap the sections in
             * 
             */
            //set up library list
            var library = new List<Media> {};

            //start menu
            Console.WriteLine("Welcome to library inventory\n");
            Console.WriteLine("Possible commands: ");
            // may have forgotten commands 
            Console.WriteLine("SearchByTitle");
            Console.WriteLine("CreateItem");
            Console.WriteLine("EditItem");
            Console.WriteLine("ShowAll");
            Console.WriteLine("ShowAllOfType");
            Console.WriteLine("ShowChanges"); // for log
            Console.WriteLine("ShowAllBy");
            Console.WriteLine("DeleteItem");
            Console.WriteLine("SearchByID");
            Console.WriteLine("SearchByTitle");
        }
    }
}
