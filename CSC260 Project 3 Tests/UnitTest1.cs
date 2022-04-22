using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC260_Project_3;

namespace CSC260_Project_3_Tests
{
    [TestClass]
    public class MediaTests
    {
        /*
// things I can probably unit test: ShowFound, DeleteItem, the "submethods" of EditItem, possibly adding items to list
// ShowFound: purpose is to display the aspects of an item--
things I could test: what if item doesn't exist/is null, what if certain aspects aren't filled out 
(is that possible),
DeleteItem: purpose is to remove item from library--
test: if item doesn't exist/is null/uninitialized, when list doesn't exist/is null/uninitialized,
EditItem: purpose is to let item be edited--
test: if item doesn't exist/is null/uninitialized, if user enters wrong type of input 
(that possible? all input automatically seems to be a string)
Adding items: what if list is too large
 */
        [TestMethod]
        
        public void TestDeleteNormal()
        {
            //fill a list with four items
            //using (List<Media> lib = new List<Media> { })
           // using (MyList = List<Media>;)
            //{ }
            // after its full, display each item
            // after deleting each item, display what's left in the list

        }
    }
}
