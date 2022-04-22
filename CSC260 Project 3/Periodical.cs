using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_Project_3
{

	public class Periodical : Media, IEditMedia
	{
		new private string _type = "Periodical";
		private static int _instances;
		private int _issue;
		private int _pages;
		private string _publisher;
		private int _volume;

		public static int Instances 
		{ 
			get
			{
				return _instances;
			}
			set
			{
				
			}
		}

		public int Issue { get { return _issue; } set { _issue = value; } }

		public int Pages { get { return _pages; } set { _pages = value; } }

		public string Publisher { get { return _publisher; } set { _publisher = value; } }

		public int Volume { get { return _volume; } set { _volume = value; } }
		//public override string Title { get; set; }
		public override string Type { get { return _type; } set {/*throw an exception saying it's read only?*/ } }

		public Periodical(string title, int volume, int issue) // add genre and datepublished para. to NClass
		{
			_id = _generatedID;
			_title = title + "Vol" + volume + "Issue" + issue;
			_volume = volume;
			_issue = issue;
			_instances++;
		}/**/
		public Periodical(string title, int volume, int issue, int pages, string publisher, List<string> editors, string genre, string datepublished) // add genre and datepublished para. to NClass
		{
			_id = _generatedID;
			_title = title + " Vol " + volume + " Issue " + issue;
			_volume = volume; 
			_issue = issue;
			foreach (string ed in editors)
			{
				_creators.Add(ed);
			}
			_publisher = publisher;
			_pages = pages;
			_datePublished = datepublished;
			_genre = genre;
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
				//show item title
				foreach (string c in _creators)
				{
					Console.WriteLine("-Editor(s): " + c);
				}
				Console.WriteLine("-Pages: " + Pages);
				Console.WriteLine("-Date published: " + DatePublished);
				Console.WriteLine("-Publisher: " + Publisher);
				Console.WriteLine("-Genre: " + Genre);
			}
		}


		public void EditItem()
		{
			//title needs special handling--need to change it if magazine name, issue, and volume are changed
			Console.WriteLine("Enter aspect to edit (options: Title, Editors, Genre, DatePublished, Publisher, Pages, Volume, Issue)");
			string i1 = Console.ReadLine();

			while (i1 != "Exit")
			{ 
			if (i1 == "Magazine")
			{
				this.EditTitle();
			}
			else if (i1 == "Editors")
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
			else if (i1 == "Publisher")
			{
				this.EditPublisher();
			}
			else if (i1 == "Pages")
			{
				this.EditPages();
			}
			else if (i1 == "Volume")
            {
				this.EditVolume();
            }
			else if (i1 == "Issue")
            {
				this.EditIssue();
            }
			else
			{
				Console.WriteLine("Invalid input");
			}
			}
		}
		public void EditTitle()
		{
			Console.WriteLine("Enter new magazine name: "); 
			string i1 = Console.ReadLine();
			this.Title = i1 + " Vol " + Volume + " Issue " + Issue; 
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Title of Item" + this.ID + "edited\n";
		}
		public void EditCreators()
		{
			Console.WriteLine("Enter new list of editors (enter x to finish): ");
			var newlist = new List<string> { };
			this.Creators = newlist;
			string i1 = "";
			while (i1 != "x")
			{
				i1 = Console.ReadLine();
				this.Creators.Add(i1);
			}
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Editors of Item" + this.ID + "edited\n";
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
		public void EditPublisher()
        {
			Console.WriteLine("Enter new publisher: ");
            string i1 = Console.ReadLine();
            this.Publisher = i1;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Publisher of Item" + this.ID + "edited\n";
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
		public void EditVolume()
        {
			Console.WriteLine("Enter new volume number: ");
			string i1 = Console.ReadLine();
			this.Title = Title + " Vol " + i1 + " Issue " + Issue;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Volume of Item" + this.ID + "edited\n";
		}
		public void EditIssue()
		{
			Console.WriteLine("Enter new issue number: ");
			string i1 = Console.ReadLine();
			this.Title = Title + " Vol " + Volume + " Issue " + i1;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Issue of Item" + this.ID + "edited\n";
		}
	}
}
