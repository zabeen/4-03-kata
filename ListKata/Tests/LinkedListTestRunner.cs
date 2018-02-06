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
            test.FindOnEmptyListReturnsNull();
            test.FindOnlyReturnsNewlyAddedItems();
            test.OnlyItemsInListAreRemoved();
            test.NoExceptionRaisedWhenDeletingFromEmptyList();
        }

        [Test]
        public void RunDoubleLinkedListTests()
        {
            var test = new LinkedListTest<DoubleLinkedList>();
            test.FindOnEmptyListReturnsNull();
            test.FindOnlyReturnsNewlyAddedItems();
            test.OnlyItemsInListAreRemoved();
            test.NoExceptionRaisedWhenDeletingFromEmptyList();
        }
    }
}
