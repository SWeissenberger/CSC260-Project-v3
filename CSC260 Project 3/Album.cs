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
	}
}
