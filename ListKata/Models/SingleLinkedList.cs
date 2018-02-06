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
            var nodeCounter = _count - 1;
            var currentNode = _head;

            while(nodeCounter > -1)
            {
                arr[nodeCounter] = currentNode.Value;
                nodeCounter--;
                currentNode = currentNode.Next;
            }

            return arr;
        }

        private ListNode FindFromHeadToNext(string value)
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

        private void ExtendListByReplacingHead(string value)
        {
            var newNode = new ListNode(value, _head);
            _head = newNode;
            _count++;
        }

        private void RemoveNodeFromList(ListNode node)
        {
            if (_count == 0)
                return;

            var lastNode = new ListNode();
            var currentNode = _head;
            var isCurrentNodeTheHead = true;
            while (true)
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

                var nextNode = currentNode.Next;
                if (nextNode == null)
                    return;
                lastNode = currentNode;
                currentNode = nextNode;
                isCurrentNodeTheHead = false;
            }        
        }
    }
}
