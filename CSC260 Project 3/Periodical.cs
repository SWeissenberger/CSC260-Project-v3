using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_Project_3
{

	public class Periodical : Media
	{
		new private string _type = "Periodical";
		private static int _instances;
		private int _issue;
		private int _pages;
		private string _publisher;
		private int _volume;

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

		public int Issue { get { return _issue; } set { _issue = value; } }

		public int Pages { get { return _pages; } set { _pages = value; } }

		public string Publisher { get { return _publisher; } set { _publisher = value; } }

		public int Volume { get { return _volume; } set { _volume = value; } }
		//public override string Title { get; set; }
		public override string Type { get { return _type; } set {/*throw an exception saying it's read only?*/ } }

		public Periodical(string title, int volume, int issue, int pages, string publisher, List<string> editors, string genre, string datepublished) // add genre and datepublished para. to NClass
		{
			_id = _generatedID;
			_title = title + "Vol" + volume + "Issue" + issue;
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
					Console.WriteLine("-Editor(s): " + c);
				}
				Console.WriteLine("-Pages: " + Pages);
				Console.WriteLine("-Date published: " + DatePublished);
				Console.WriteLine("-Publisher: " + Publisher);
			}
		}
	}
}
