using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListKata.Models
{
    public class DoubleLinkedList : LinkedListBase
    {
        protected override void ExtendListAtOneEnd(string value)
        {
            var newNode = new ListNode(value, Head);
            if (Head != null) Head.Previous = newNode;
            Head = newNode;
            Count++;
        }

        protected override void RemoveNodeFromList(ListNode node)
        {
            if (node == null)
                return;

            if (Head != null
                && Head.Value.Equals(node.Value)
                && Head.Next == node.Next
                && Head.Previous == node.Previous)
                Head = node.Next;

            if (node.Previous != null) node.Previous.Next = node.Next;
            if (node.Next != null) node.Next.Previous = node.Previous;
            Count--;
        }
    }
}
