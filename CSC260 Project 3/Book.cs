using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_Project_3
{
	
	public class Book : Media
	{
		//const string _type = "Book"; // how to reconcile this w/ Media's _type? make it readonly?
		private string _format;
		private static int _instances = 0;
		private int _pages;
		private string _publisher;
		new private string _type = "Book";
		public string Format { get { return _format;  } set { _format = value; } }

		public override int Instances 
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

		public Book(string title, List<string> authors, string publisher, int pages, string format, string datepublished, string genre)
		{
			_id = _generatedID;
			_title = title;
			foreach (string auth in authors)
            {
				_creators.Add(auth);
            }
			// _creators = authors;
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
		}

		public override void ShowFound(bool showAll)
		{
			//show item id
			Console.WriteLine("ID: " + ID);
			//show item title
			Console.WriteLine("-Title: " + Title);
			if (showAll == true)
			{
				Console.WriteLine("-Medium: " + Type);
				Console.WriteLine("-Checked out: " + CheckedOut);

				foreach (string c in _creators)
				{ 
				 Console.WriteLine("-Author(s): " + c); 
				}
				
				// does this actually print all the creators?
				Console.WriteLine("-Year published: " + DatePublished);
				Console.WriteLine("-Genre: " + Genre);
				Console.WriteLine("-Publisher: " + Publisher);
				Console.WriteLine("-Pages: " + Pages);
				Console.WriteLine("-Format: " + Format);
			}

		}
	}
}
