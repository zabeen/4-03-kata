using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListKata.Models
{
    public class SingleLinkedList : LinkedListBase
    {
        protected override void ExtendListAtOneEnd(string value)
        {
            var newNode = new ListNode(value, Head);
            Head = newNode;
            Count++;
        }

        protected override void RemoveNodeFromList(ListNode node)
        {
            if (node == null)
                return;

            if (node.Equals(Head))
            {
                Head = Head.Next;
                Count--;
                return;
            }

            var lastNode = new ListNode(null, Head);
            var currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.Equals(node))
                {
                    lastNode.Next = currentNode.Next;
                    Count--;
                    return;
                }

                lastNode = currentNode;
                currentNode = currentNode.Next;
            }
        }
    }
}
