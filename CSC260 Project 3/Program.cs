using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// possible aids 
/*https://en.pon-navi.net/nazuke/name/reading/a/keisuke
https://exceptionnotfound.net/const-vs-static-vs-readonly-in-c-sharp-applications/
https://www.c-sharpcorner.com/UploadFile/abhikumarvatsa/static-and-non-static-fields-in-C-Sharp/
*/
//links to related docs:
/*
 * notes: https://onedrive.live.com/edit.aspx?resid=A19DB1A21E96D0A1!738&ithint=file%2cdocx&wdOrigin=OFFICECOM-WEB.START.MRU
 * my rubric: https://docs.google.com/spreadsheets/d/14KyIsj6b_jhIfZX-hO6JyIxZWllbCLtTD7KqeCi3rKI/edit#gid=0
 */
/*
// things I can probably unit test: ShowFound, DeleteItem, the "submethods" of EditItem, possibly adding items to list
// ShowFound: purpose is to display the aspects of an item--
things I could test: what if item doesn't exist/is null, what if certain aspects aren't filled out 
(is that possible),
DeleteItem: purpose is to remove item from library--
test: if item doesn't exist/is null/uninitialized, when list doesn't exist/is null/uninitialized,
EditItem: purpose is to let item be edited--
test: if item doesn't exist/is null/uninitialized, if user enters wrong type of input 
(that possible? all input automatically seems to be a string)
Adding items: what if list is too large
 */


//undone: writing each method so it logs each action
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
            bool exit = false;
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
            Console.WriteLine("InventorySize"); // numberOfItems
            Console.WriteLine("AmountOfType");
            Console.WriteLine("CheckOut/Return");
            Console.WriteLine("Exit");

            

            // input-accepting loop
            while (exit != true)
            {
                Console.WriteLine(" \n Enter command: ");

                //get input
                string input = Console.ReadLine();

                // compare input to options
                //Console.WriteLine("SearchByTitle");
                if (input == "SearchByTitle")
                {
                    Console.WriteLine("Enter title: ");
                    //get input
                    string i1 = Console.ReadLine();
                    Media.SearchByTitle(library, i1);
                }
                //Console.WriteLine("CreateItem");

                // needs extra effort, since there's four items to account for
               if (input == "CreateItem")
               {
                    /*Console.WriteLine("Enter title: ");
                    //get input
                    string i1 = Console.ReadLine();
                    Media.SearchByTitle(library, i1);*/

                    Console.WriteLine("Enter media type (options: Book, Movie, Periodical, Album): ");
                    string i1 = Console.ReadLine();
                    if (i1 == "Book")
                    {
                        Console.WriteLine("Enter title: ");
                        i1 = Console.ReadLine();
                        var newitem = new Book(i1);
                        Console.WriteLine("Enter ISBN number: ");
                        i1 = Console.ReadLine();
                        newitem.ISBN = i1;
                        Console.WriteLine("Enter authors (enter x to finish): ");
                        while (i1 != "x")
                        {
                            i1 = Console.ReadLine();
                            newitem.Creators.Add(i1);
                        }
                        Console.WriteLine("Enter date (format: MM/DD/YYYY): ");
                        i1 = Console.ReadLine();
                        newitem.DatePublished = i1;
                        Console.WriteLine("Enter genre: ");
                        i1 = Console.ReadLine();
                        newitem.Genre = i1;
                        Console.WriteLine("Enter format (options: paperback, audiobook, ebook, hardback): ");
                        i1 = Console.ReadLine();
                        newitem.Format = i1;
                        Console.WriteLine("Enter number of pages: ");
                        i1 = Console.ReadLine();
                        int iparsed = Int32.Parse(i1);
                        newitem.Pages = iparsed;
                        Console.WriteLine("Enter publisher: ");
                        i1 = Console.ReadLine();
                        newitem.Publisher = i1;
                        library.Add(newitem);
                        Console.WriteLine("Item successfully created ");

                    }
                    else if (i1 == "Movie")
                    {
                        Console.WriteLine("Enter title: ");
                        i1 = Console.ReadLine();
                        var newitem = new Movie(i1);
                        Console.WriteLine("Enter directors (enter x to finish): ");
                        while (i1 != "x")
                        {
                            i1 = Console.ReadLine();
                            newitem.Creators.Add(i1);
                        }
                        Console.WriteLine("Enter date (format: MM/DD/YYYY): ");
                        i1 = Console.ReadLine();
                        newitem.DatePublished = i1;
                        Console.WriteLine("Enter genre: ");
                        i1 = Console.ReadLine();
                        newitem.Genre = i1;                        
                        Console.WriteLine("Enter company: ");
                        i1 = Console.ReadLine();
                        newitem.Company = i1;
                        Console.WriteLine("Enter length in minutes: ");
                        i1 = Console.ReadLine();
                        int iparsed = Int32.Parse(i1);
                        newitem.Minutes = iparsed;
                        Console.WriteLine("Item successfully created ");
                    }
                    else if (i1 == "Periodical")
                    {
                        Console.WriteLine("Enter magazine name: ");
                        i1 = Console.ReadLine();
                        Console.WriteLine("Enter volume number: ");
                        var vol = Console.ReadLine();
                        var vol2 = Int32.Parse(vol);
                        Console.WriteLine("Enter volume number: ");
                        var iss = Console.ReadLine();
                        var iss2 = Int32.Parse(iss);

                        var newitem = new Periodical(i1, vol2, iss2);
                        Console.WriteLine("Enter editors (enter x to finish): ");
                        while (i1 != "x")
                        {
                            i1 = Console.ReadLine();
                            newitem.Creators.Add(i1);
                        }
                        Console.WriteLine("Enter date (format: MM/DD/YYYY): ");
                        i1 = Console.ReadLine();
                        newitem.DatePublished = i1;
                        Console.WriteLine("Enter genre: ");
                        i1 = Console.ReadLine();
                        newitem.Genre = i1;
                        Console.WriteLine("Enter publisher: ");
                        i1 = Console.ReadLine();
                        newitem.Publisher = i1;
                        Console.WriteLine("Enter number of pages: ");
                        i1 = Console.ReadLine();
                        int iparsed = Int32.Parse(i1);
                        newitem.Pages = iparsed;
                        Console.WriteLine("Item successfully created ");
                    }
                    else if (i1 == "Album")
                    {
                        Console.WriteLine("Enter title: ");
                        i1 = Console.ReadLine();
                        var newitem = new Album(i1);
                        Console.WriteLine("Enter artists (enter x to finish): ");
                        while (i1 != "x")
                        {
                            i1 = Console.ReadLine();
                            newitem.Creators.Add(i1);
                        }
                        Console.WriteLine("Enter date (format: MM/DD/YYYY): ");
                        i1 = Console.ReadLine();
                        newitem.DatePublished = i1;
                        Console.WriteLine("Enter genre: ");
                        i1 = Console.ReadLine();
                        newitem.Genre = i1;
                        Console.WriteLine("Enter record label: ");
                        i1 = Console.ReadLine();
                        newitem.RecordLabel = i1;
                        Console.WriteLine("Enter total length in minutes: ");
                        i1 = Console.ReadLine();
                        int iparsed = Int32.Parse(i1);
                        newitem.TotalMinutes = iparsed;
                        Console.WriteLine("Enter songs: ");
                        while (i1 != "x")
                        {
                            i1 = Console.ReadLine();
                            newitem.Songs.Add(i1);
                        }
                        Console.WriteLine("Item successfully created ");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input ");
                    }
                }
                //Console.WriteLine("EditItem");
                //extra effort
                // when user comes to specific item, should there be a loop so the user can edit multiple aspect?
                if (input == "EditItem")
                {
                    Console.WriteLine("Enter media type (options: Book, Movie, Periodical, Album): ");
                    string i1 = Console.ReadLine();
                    Console.WriteLine("Enter item ID: ");
                    string i2 = Console.ReadLine();
                    var iparsed = Int32.Parse(i2);

                    if (i1 == "Book")
                    {
                        Book found = (Book)library.Find(x => x.ID == iparsed);
                        found.EditItem();
                    }
                    
                    else if (i1 == "Movie")
                    {
                        Movie found = (Movie)library.Find(x => x.ID == iparsed);
                        found.EditItem();
                    }
                   
                    else if (i1 == "Periodical")
                    {
                        Periodical found = (Periodical)library.Find(x => x.ID == iparsed);
                        found.EditItem();
                    }
                    
                    else if (i1 == "Album")
                    {
                        Album found = (Album)library.Find(x => x.ID == iparsed);
                        found.EditItem();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input ");
                    }
                    
                }

                //Console.WriteLine("ShowAll");
                if (input == "ShowAll")
                {
                    Console.WriteLine("Inventory items: ");
                    Media.ShowAll(library);
                }
                //Console.WriteLine("ShowAllOfType");
                if (input == "ShowAllOfType")
                {
                    Console.WriteLine("Enter media type (options: Book, Movie, Periodical, Album): ");
                    string i1 = Console.ReadLine();
                    if (i1 == "Book")
                    {
                        Console.WriteLine("All books: ");
                        Media.ShowAllOfType(library, "Book");
                    }
                    else if (i1 == "Movie")
                    {
                        Console.WriteLine("All movies: ");
                        Media.ShowAllOfType(library, "Movie");
                    }
                    else if (i1 == "Periodical")
                    {
                        Console.WriteLine("All periodicals: ");
                        Media.ShowAllOfType(library, "Periodical");
                    }
                    else if (i1 == "Album")
                    {
                        Console.WriteLine("All albums: ");
                        Media.ShowAllOfType(library, "Album");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input ");
                    }
                }

                // Console.WriteLine("ShowChanges"); // for log
                if (input == "ShowChanges")
                {
                    Console.WriteLine("Log: ");
                    Media.DisplayLog(); //how to fix?
                }
                // Console.WriteLine("ShowAllBy");
                if (input == "ShowAllBy")
                {
                    Console.WriteLine("Enter author name: ");
                    string i1 = Console.ReadLine();

                    Media.ShowAllBy(library, i1);
                }
                //Console.WriteLine("DeleteItem");
                if (input == "DeleteItem")
                {
                    Console.WriteLine("Enter item ID: ");
                    string i1 = Console.ReadLine();

                    //library.Remove(i1);
                    int iparsed = Int32.Parse(i1);
                    var found = library.Find(x => x.ID == iparsed);
                    Media.DeleteItem(library, found);
                }

                //Console.WriteLine("SearchByID");
                if (input == "SearchByID")
                {
                    Console.WriteLine("Enter ID: ");
                    //get input
                    string i1 = Console.ReadLine();
                    //convert string to int
                    int iparsed = Int32.Parse(i1);
                    Media.SearchByID(library, iparsed);
                }

                //Console.WriteLine("InventorySize");
                if (input == "InventorySize")
                {
                    Console.WriteLine("Total number of items: " + Media._generatedID);
                }

                //Console.WriteLine("AmountOfType");
                if (input == "AmountOfType")
                {
                    Console.WriteLine("Enter media type (options: Book, Movie, Periodical, Album): ");
                    string i1 = Console.ReadLine();
                    if (i1 == "Book")
                    {
                        Console.WriteLine("Number of books: " + Book.Instances);
                    }
                    else if (i1 == "Movie")
                    {
                        Console.WriteLine("Number of movies: " + Movie.Instances);
                    }
                    else if (i1 == "Periodical")
                    {
                        Console.WriteLine("Number of periodicals: " + Periodical.Instances);
                    }
                    else if (i1 == "Album")
                    {
                        Console.WriteLine("Number of albums: " + Album.Instances);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input ");
                    }
                }

                //Console.WriteLine("CheckOut/Return");
                if (input == "CheckOut/Return")
                {
                    Console.WriteLine("Enter item ID: ");
                    string i1 = Console.ReadLine();
                    int iparsed = Int32.Parse(i1);
                    var found = library.Find(x => x.ID == iparsed);

                    Console.WriteLine("Choose an action (options: Return or Checkout): ");
                    i1 = Console.ReadLine();
                    if (i1 == "Return")
                    {
                        if (found.CheckedOut == false)
                        {
                            Console.WriteLine("Book is not checked out--cannot return");
                        }
                        else
                        {
                            found.CheckedOut = false;
                            Console.WriteLine("Book returned");
                        }
                    }
                    else if (i1 == "Checkout")
                    {
                        if (found.CheckedOut == true)
                        {
                            Console.WriteLine("Book is already checked out");
                        }
                        else
                        {
                            found.CheckedOut = true;
                            Console.WriteLine("Book checked out");
                        }
                    }
                }


                if (input == "Exit")
                {
                    Console.WriteLine("Goodbye");
                    exit = true;
                }

                

                //if it matches none, print "invalid input"
                // seems to print this even when its inappropriate
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

        }
    }
}
