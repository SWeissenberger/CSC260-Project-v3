using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_Project_3
{
	
	public class Book : Media, IEditMedia
	{
		//const string _type = "Book"; // how to reconcile this w/ Media's _type? make it readonly?
		private string _isbn;
		private string _format;
		private static int _instances = 0;
		private int _pages;
		private string _publisher;
		new private string _type = "Book";

		public string ISBN { get { return _isbn; } set { _isbn = value; } }
		public string Format { get { return _format;  } set { _format = value; } }

		public static int Instances 
		{
			get
			{
				return _instances;//throw new NotImplementedException();
			}
			// it doesn't work if I set this and media's set to private, or this to private and not media's, but it prolly shouldn't let users change it
			set
			{
				return;//throw new NotImplementedException();
			}
		}

		public int Pages { get { return _pages; } set { _pages = value; } }
		public string Publisher { get { return _publisher; } set { _publisher = value; } }

		public override string Type { get { return _type; } set { } }

		//public override string Title { get { return _title; } set { value = _title; } }// was not implemented in NClass

		public Book(string title, string isbn, List<string> authors, string publisher, int pages, string format, string datepublished, string genre)
		{
			_id = _generatedID;
			_title = title;
			_isbn = isbn;
			foreach (string auth in authors)
            {
				_creators.Add(auth);
            }
			_publisher = publisher;
			_pages = pages;
			_format = format;
			_datePublished = datepublished;
			_genre = genre;
			_instances++;
		}

		public Book(string title)
		{
			_id = _generatedID;
			_title = title;
			_instances++;
		}

		protected override void ShowFound(bool showAll)
		{
			Console.WriteLine("ID: " + ID);
			Console.WriteLine("-Title: " + Title);
			if (showAll == true)
			{
				Console.WriteLine("-Medium: " + Type);
				Console.WriteLine("-Checked out: " + CheckedOut);

				foreach (string c in _creators)
				{ 
				 Console.WriteLine("-Author(s): " + c); 
				}
				Console.WriteLine("-Year published: " + DatePublished);
				Console.WriteLine("-Genre: " + Genre);
				Console.WriteLine("-Publisher: " + Publisher);
				Console.WriteLine("-Pages: " + Pages);
				Console.WriteLine("-Format: " + Format);
			}

		}

		public void EditItem()
        {
			Console.WriteLine("Enter aspect to edit (options: Title, ISBN, Authors, DatePublished, Genre, Format, Pages, Publisher, Exit)");
			string i1 = Console.ReadLine();

			while (i1 != "Exit") 
			{
			if (i1 == "Title")
			{
				this.EditTitle();
			}
			else if (i1 == "ISBN")
			{
				this.EditISBN();
			}
			else if (i1 == "Authors")
			{
				this.EditCreators();
			}
			else if (i1 == "DatePublished")
			{
				this.EditDate();
			}
			else if (i1 == "Genre")
			{
				this.EditGenre();
			}
			else if (i1 == "Format")
			{
				this.EditFormat();
			}
			else if (i1 == "Pages")
			{
				this.EditPages();
			}
			else if (i1 == "Publisher")
			{
				this.EditPublisher();
			}
			else
			{
				Console.WriteLine("Invalid input");
			}
			}
		}
		public void EditCreators()
		{
			Console.WriteLine("Enter new list of authors (enter x to finish): ");
			var newlist = new List<string> { };
			this.Creators = newlist;
			string i1 = "";
			while (i1 != "x")
			{
				i1 = Console.ReadLine();
				this.Creators.Add(i1);
			}
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Authors of Item" + this.ID + "edited\n";
		}
		public void EditDate()
		{
			Console.WriteLine("Enter new date (format: MM/DD/YYYY): ");
			string i1 = Console.ReadLine();
			this.DatePublished = i1;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Date of Item" + this.ID + "edited\n";
		}
		public void EditGenre()
		{
			Console.WriteLine("Enter new genre: ");
			string i1 = Console.ReadLine();
			this.Genre = i1;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Genre of Item" + this.ID + "edited\n";
		}
		public void EditTitle()
		{ 
			Console.WriteLine("Enter new title: ");
			string i1 = Console.ReadLine();
			this.Title = i1; 
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Title of Item" + this.ID + "edited\n";
		}
		public void EditISBN()
		{
			Console.WriteLine("Enter new ISBN: ");
			string i1 = Console.ReadLine();
			this.ISBN = i1;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "ISBN of Item" + this.ID + "edited\n";
		}
		public void EditFormat()
        {
			Console.WriteLine("Enter new format (options: paperback, audiobook, ebook, hardback): ");
            string i1 = Console.ReadLine();
            this.Format = i1;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Format of Item" + this.ID + "edited\n";
		}
		public void EditPages()
        {
			Console.WriteLine("Enter new number of pages: ");
            string i1 = Console.ReadLine();
            int iparsed = Int32.Parse(i1);
            this.Pages = iparsed;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Number of pages of Item" + this.ID + "edited\n";
		}
		public void EditPublisher()
        {
			Console.WriteLine("Enter new publisher: ");
			string i1 = Console.ReadLine();
			this.Publisher = i1;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Publisher of Item" + this.ID + "edited\n";
		}

	}
}
