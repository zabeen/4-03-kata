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

            if (node.Equals(Head)) Head = node.Next;
            if (node.Previous != null) node.Previous.Next = node.Next;
            if (node.Next != null) node.Next.Previous = node.Previous;
            Count--;
        }
    }
}
