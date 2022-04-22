using System;
using System.Collections.Generic;
using System.Text;

namespace CSC260_Project_3
{
    interface IEditMedia
    {
		// should edit all parts of a Media instance
		void EditItem();
		void EditCreators();
		void EditDate();
		void EditGenre();
		void EditTitle();
	}
}
