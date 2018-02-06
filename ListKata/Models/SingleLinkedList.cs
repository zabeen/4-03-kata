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
                Head = Head.Next;
            else
            {
                var lastNode = new ListNode(null, Head);
                var currentNode = Head;
                while (currentNode != null)
                {
                    if (currentNode.Equals(node))
                    {
                        lastNode.Next = currentNode.Next;
                        break;
                    }

                    lastNode = currentNode;
                    currentNode = currentNode.Next;
                }
            }

            Count--;
        }
    }
}
