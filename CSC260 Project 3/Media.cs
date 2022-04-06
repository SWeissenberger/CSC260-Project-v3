using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC260_Project_3
{
	public abstract class Media
	{
		// FORGOT: write a method to let user edit items--or should that be incorporated into main?
		//formerly all private
		public bool _checkedOut = false;
		//private string[] _creators;
		public List<string> _creators = new List<string> { };
		public string _datePublished;
		public static int _generatedID = 0;
		public string _genre;
		public int _id;
		public string _log = "";
		public string _title;
		//private string _type; // just noticed I didn't make a property for this--should prolly reconcile the subclasses' _type first
		public string _type = "media";

		public virtual bool CheckedOut { get { return _checkedOut; } set { _checkedOut = value; } }
		//public virtual string[] Creators { get; private set; }
		public virtual List<string> Creators { get { return _creators; } set { _creators = value; } }
		//should I use lists for fields and properties instead of arrays?
		public virtual string DatePublished { get { return _datePublished; } set { _datePublished = value; } }
		public virtual string Genre { get { return _genre; } set { _genre = value; } }
		public virtual int ID { get { return _id; } private set { } }
		public virtual int Instances
		{
			get
			{
				return _generatedID;
			}
			set
			{
				return;
			}
		}
		//type should prolly be private set, but doesn't seem to work
		public virtual string Type { get { return _type; } set { } } // don't forget to change nclass to model this & subclasses

		public virtual string Log { get { return _log; } set { _log = value; } }
		public virtual string Title { get { return _title; } set { _title = value; } }
		//public abstract string Title { get; set; }

		public Media()
		{
			// what should this do? --it should inc _generatedID, but not let someone make an instance of Media
			//throw new NotImplementedException();
			// the incrementing id process doesn't seem to work
			_generatedID++;

		}
		// think all this parameters are wrong--think I can (should?) just pass the instance itself 
		// if i change parameters, don't forget to 
		//public void DeleteItem(List<Media> list, int id)
		public void DeleteItem(List<Media> list, Media item)
		{
			//throw new NotImplementedException();
			// using id (which should be passed as Media.ID), find the item in the list and delete it
			if (list.Remove(item) == true)
			{
				Console.WriteLine("Item deleted");
				Log = Log + item.Title + "deleted\n";
				return;
			}
			Console.WriteLine("Error");

		}

		public void DisplayLog()
		{
			//throw new NotImplementedException();
			Console.WriteLine(Log);
		}

		//BIG question--will a list of type Media be able to hold instances of subclasses of Media?

		//forgot this in NClass: search by title
		public static void SearchByTitle(List<Media> list, string title)
		{
			var found = list.Find(x => x.Title == title);
			found.ShowFound(true);
		}
		public static void SearchByID(List<Media> list, int id)
		{
			// take the id, look at each item in the list to see if it has that ID, use ShowFound on the found item
			// throw new NotImplementedException();
			/*example of using List.Exist:       
			 * // Check if an item with Id 1444 exists.
        Console.WriteLine("\nExists: Part with Id=1444: {0}",
            parts.Exists(x => x.PartId == 1444));*/
			/*if (list.Exists(x => x.ID == id))
			{
				x.ShowFound();
			}*/
			var found = list.Find(x => x.ID == id);
			found.ShowFound(true);
		}

		public static void ShowAll(List<Media> list)
		{
			//throw new NotImplementedException();
			foreach (Media m in list)
            {
				m.ShowFound(false);
            }
		}

		public static void ShowAllBy(List<Media> list, string author)
		{
			//throw new NotImplementedException();
			var newlist = list.FindAll(x => x.Creators.Contains(author));
			foreach (Media m in newlist)
            {
				m.ShowFound(false);
            }
		}

		public static void ShowAllOfType(List<Media> list, string type)
		{
			var newlist = list.FindAll(x => x.Type == type);
			foreach (Media m in newlist)
			{
				m.ShowFound(false);
			}
		}

		public virtual void ShowFound(bool showAll)
		{
			//throw new NotImplementedException();
			//show item id

			Console.WriteLine("ID: " + ID);
			//show item title
			Console.WriteLine("-Title: " + Title);
			if (showAll == true)
            {
				//show more--in the media class, there's no more to show
            }
		}
	}
	}
