﻿using System;
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
                    {/*
                        Console.WriteLine("Enter magazine name: ");
                        i1 += Console.ReadLine();
                        Console.WriteLine("Enter volume number: ");
                        i1 += Console.ReadLine();
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
                        newitem.Minutes = iparsed;*/
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

                /**/
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
                    /*if (found.CheckedOut == false)
                    { 
                        Console.WriteLine("Item is not checked out ");
                    }
                    else
                    {
                        Console.WriteLine("Item is checked out ");
                    }*/
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
