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
		private List<string> _songs;
		private int _totalMinutes;

		public override int Instances
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public string RecordLabel
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public List<string> Songs
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int TotalMinutes
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}
		//public override string Title { get; set; }

		public Album(string title)
		{
			throw new NotImplementedException();
		}

		public Album(string title, int numArtists, string[] artists, int numSongs, string[] songs, string label, int numMins, string yearReleased, string genre)
		{
			throw new NotImplementedException();
		}

		public override void ShowFound(bool showAll)
		{
			throw new NotImplementedException();
		}
	}
}
