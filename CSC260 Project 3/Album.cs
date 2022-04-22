using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_Project_3
{
	public class Album : Media
	{
		new private string _type = "Album";
		private static int _instances;
		private string _recordLabel;
		private List<string> _songs = new List<string> { };
		private int _totalMinutes;

		//all subclass Instances formerly "override"
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

		public string RecordLabel {	get { return _recordLabel; } set { _recordLabel = value; } }

		public List<string> Songs { get { return _songs; } set { _songs = value; } }

		public int TotalMinutes { get { return _totalMinutes; } set { _totalMinutes = value; } }
		//public override string Title { get; set; }

		public Album(string title)
		{
			_id = _generatedID;
			_title = title;
			_instances++;
		}

		public Album(string title, List<string> artists, List<string> songs, string label, int numMins, string yearReleased, string genre) //change paras in NClass to match these
		{
			_id = _generatedID;
			_title = title;
			foreach (string artist in artists)
			{
				_creators.Add(artist);
			}
			foreach (string song in songs)
			{
				_creators.Add(song);
			}
			_recordLabel = label;
			_totalMinutes = numMins;
			_datePublished = yearReleased;
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
					Console.WriteLine("-Artist(s): " + c);
				}
				foreach (string s in _songs)
				{
					Console.WriteLine("-Songs: " + s);
				}
				Console.WriteLine("-Release Year: " + DatePublished);
				Console.WriteLine("-Record label: " + RecordLabel);
				Console.WriteLine("-Genre: " + Genre);
				Console.WriteLine("-Total length: " + TotalMinutes);
			}
		}

		public void EditItem()
		{
			Console.WriteLine("Enter aspect to edit (options: Title, Artists, Genre, DatePublished, RecordLabel, TotalMinutes, Songs)");
			string i1 = Console.ReadLine();

			while (i1 != "Exit") { 
			if (i1 == "Title")
			{
				this.EditTitle();
			}
			else if (i1 == "Artists")
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
			else if (i1 == "RecordLabel")
			{
				this.EditRecordLabel();
			}
			else if (i1 == "TotalMinutes")
			{
				this.EditTotalMinutes();
			}
			else if (i1 == "Songs")
			{
				this.EditSongs();
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
			Console.WriteLine("Enter new list of artists (enter x to finish): ");
			var newlist = new List<string> { };
			this.Creators = newlist;
			string i1 = "";
			while (i1 != "x")
			{
				i1 = Console.ReadLine();
				this.Creators.Add(i1);
			}
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Artists of Item" + this.ID + "edited\n";
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

		public void EditRecordLabel()
        {
			Console.WriteLine("Enter new record label: ");
            string i1 = Console.ReadLine();
            this.RecordLabel = i1;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Record label of Item" + this.ID + "edited\n";
		}
		public void EditTotalMinutes()
        {
			Console.WriteLine("Enter new total length in minutes: ");
            string i1 = Console.ReadLine();
            int iparsed = Int32.Parse(i1);
			this.TotalMinutes = iparsed;
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Total minutes of Item" + this.ID + "edited\n";
		}
		public void EditSongs()
        {
			Console.WriteLine("Enter new list of songs: ");
			var newlist = new List<string> { };
			this.Creators = newlist;
			string i1 = "";
			while (i1 != "x")
			{
				i1 = Console.ReadLine();
				this.Songs.Add(i1);
			}
			Console.WriteLine("Item successfully altered ");
			Log = Log + "Songs of Item" + this.ID + "edited\n";
		}
	}
}
