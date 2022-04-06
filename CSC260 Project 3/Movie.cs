using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_Project_3
{

	public class Movie : Media
	{
		private string _company;
		private int _minutes;
		private static int _instances = 0;
		new private string _type = "Movie";

		public string Company { get { return _company; } set { _company = value; } }

		public int Minutes { get { return _minutes; } set { _minutes = value; } }

		public override int Instances 
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

		public override void ShowFound(bool showAll)
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
	}
}
