using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListKata.Models
{
    public class SingleLinkedList : ILinkedList
    {
        private ListNode _head;
        private int _count = 0;

        public string[] Values()
        {
            return GetValuesFirstInFirstOut();
        }

        public void Add(string value)
        {
            ExtendListByReplacingHead(value);
        }

        public ListNode Find(string value)
        {
            return FindFromHeadToNext(value);
        }

        public void Delete(ListNode node)
        {
            RemoveNodeFromList(node);
        }

        private string[] GetValuesFirstInFirstOut()
        {
            string[] arr = new string[_count];
            var currentNode = _head;

            for (var i = _count - 1; i > -1; i--)
            {
                arr[i] = currentNode.Value;
                currentNode = currentNode.Next;
            }

            return arr;
        }

        private ListNode FindFromHeadToNext(string value)
        {
            var currentNode = _head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                    return currentNode;

                currentNode = currentNode.Next;
            }

            return null;
        }

        private void ExtendListByReplacingHead(string value)
        {
            var newNode = new ListNode(value, _head);
            _head = newNode;
            _count++;
        }

        private void RemoveNodeFromList(ListNode node)
        {
            var lastNode = new ListNode(null, _head);
            var currentNode = _head;
            var isCurrentNodeTheHead = true;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(node.Value) && currentNode.Next == node.Next)
                {
                    if (isCurrentNodeTheHead)
                        _head = _head.Next;
                    else
                        lastNode.Next = currentNode.Next;

                    _count--;
                    return;
                }

                lastNode = currentNode;
                currentNode = currentNode.Next;
                isCurrentNodeTheHead = false;
            }
        }
    }
}
