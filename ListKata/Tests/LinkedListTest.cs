using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using ListKata.Models;

namespace ListKata.Tests
{
    public class LinkedListTest<TList> where TList : ILinkedList, new()
    {
        public void FindOnEmptyListReturnsNull()
        {
            var list = new TList();
            Assert.Null(list.Find("fred"));
        }

        public void FindOnlyReturnsNewlyAddedItems()
        {
            const string firstVal = "fred";
            const string secondVal = "wilma";

            var list = new TList();
            list.Add(firstVal);
            Assert.AreEqual(firstVal, list.Find(firstVal).Value);
            Assert.Null(list.Find(secondVal));

            list.Add(secondVal);
            Assert.AreEqual(secondVal, list.Find(secondVal).Value);

            Assert.AreEqual(new[]{firstVal,secondVal}, list.Values());
        }

        public void ListCanLinkMultipleItems()
        {
            /*
            const string firstVal = "fred";
            const string secondVal = "wilma";

            var list = new TList();
            list.Add(firstVal);
            Assert.AreEqual(firstVal, list.Find(firstVal).Value);
            */
        }
    }
}
