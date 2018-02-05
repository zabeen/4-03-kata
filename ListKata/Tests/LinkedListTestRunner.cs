using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListKata.Models;
using NUnit.Framework;

namespace ListKata.Tests
{
    [TestFixture]
    public class LinkedListTestRunner
    {
        [Test]
        public void RunSingleLinkedListTests()
        {
            var test = new LinkedListTest<SingleLinkedList>();
            test.EmptyListReturnsNull();
        }
    }
}
