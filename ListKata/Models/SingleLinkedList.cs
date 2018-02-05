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

        public void Add(string value)
        {
            AddFirst(value);
            _count++;
        }

        public ListNode Find(string value)
        {
            return null;
        }

        public void Delete(ListNode node)
        {
            _count--;
        }

        /*
        public bool Equals(ListNode other)
        {
            string[] values = new string[_count];
            for (int i = 0; i < _count; i++)
            {
                
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }*/

        private void AddFirst(string value)
        {
            var newNode = new ListNode(value, _head);
            _head = newNode;
        }
    }
}
