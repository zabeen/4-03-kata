using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListKata.Models
{
    public class SingleLinkedList : ILinkedList
    {
        public ListNode Head => _head;
        public int Count => _count;

        private ListNode _head = null;
        private int _count = 0;

        public string[] Values()
        {
            return GetValuesFromHeadToNext();
        }

        public void Add(string value)
        {
            AddFirst(value);
            _count++;
        }

        public ListNode Find(string value)
        {
            return FindByValueFromHeadToNext(value);
        }

        public void Delete(ListNode node)
        {
            _count--;
        }

        private string[] GetValuesFromHeadToNext()
        {
            if (_count == 0)
                return null;

            string[] arr = new string[Count];
            var nodeCounter = 0;
            var currentNode = _head;
            do
            {
                arr[nodeCounter] = currentNode.Value;
                nodeCounter++;
                currentNode = currentNode.Next;
            } while (nodeCounter < _count);

            return arr;
        }

        private ListNode FindByValueFromHeadToNext(string value)
        {
            if (_count == 0)
                return null;

            var currentNode = _head;
            while (true)
            {
                if (currentNode.Value.Equals(value))
                    return currentNode;

                var next = currentNode.Next;
                if (next == null)
                    return null;

                currentNode = next;
            }
        }

        private void AddFirst(string value)
        {
            var newNode = new ListNode(value, _head);
            _head = newNode;
        }
    }
}
