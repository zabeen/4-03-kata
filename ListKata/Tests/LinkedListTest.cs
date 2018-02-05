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
        public void EmptyListReturnsNull()
        {
            var list = new TList();
            Assert.Null(list.Find("fred"));
        }
    }
}
