using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_Project_3
{

	public class Movie : Media, IEditMedia
	{
		private string _company;
		private int _minutes;
		private static int _instances = 0;
		new private string _type = "Movie";

		public string Company { get { return _company; } set { _company = value; } }

		public int Minutes { get { return _minutes; } set { _minutes = value; } }

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
		public override string Type { get { return _type; } set { } }
		//public override string Title { get; set; }
		public Movie(string title)
		{
			_id = _generatedID;
			_title = title;
			_instances++;
		}

		public Movie(string title, List<string> directors, string company, string releaseYear, string genre)
		{
			_id = _generatedID;
			_title = title;
			_creators = directors;
			_company = company;
			_datePublished = releaseYear;
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
					Console.WriteLine("-Director(s): " + c);
				}
				Console.WriteLine("-Company: " + Company);
				Console.WriteLine("-Release year: " + DatePublished);
				Console.WriteLine("-Length in minutes: " + Minutes);
				Console.WriteLine("-Genre: " + Genre);
			}
		}

		public void EditItem()
		{
			Console.WriteLine("Enter aspect to edit (options: Title, Directors, Genre, DatePublished, Company, Minutes, Exit)");
			string i1 = Console.ReadLine();

			while (i1 != "Exit") 
			{ 
			if (i1 == "Title")
			{
				this.EditTitle();
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
			else if (i1 == "Company")
			{
				this.EditCompany();
			}
			else if (i1 == "Minutes")
			{
				this.EditMinutes();
			}
			else
			{
				Console.WriteLine("Invalid input");
			}
			}
		}
		public void EditTitle()
		{
			Console.WriteLine("Enter new title: ");
			string i1 = Console.ReadLine();
			this.Title = i1;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Title of Item" + this.ID + "edited\n";
		}
		public void EditCreators()
		{
			Console.WriteLine("Enter new list of directors (enter x to finish): ");
			var newlist = new List<string> { };
			this.Creators = newlist;
			string i1 = "";
			while (i1 != "x")
			{
				i1 = Console.ReadLine();
				this.Creators.Add(i1);
			}
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Directors of Item" + this.ID + "edited\n";
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

		public void EditCompany()
        {
			Console.WriteLine("Enter new company: ");
            string i1 = Console.ReadLine();
            this.Company = i1;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Company of Item" + this.ID + "edited\n";
		}

		public void EditMinutes()
        {
			Console.WriteLine("Enter new length in minutes: ");
			string i1 = Console.ReadLine();
			int iparsed = Int32.Parse(i1);
			this.Minutes = iparsed;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Minutes of Item" + this.ID + "edited\n";
		}
	}
}
