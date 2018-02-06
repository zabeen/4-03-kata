namespace ListKata.Models
{
    public class LinkedListBase : ILinkedList
    {
        protected ListNode Head;
        protected int Count;

        public string[] Values()
        {
            return GetValuesFirstInFirstOut();
        }

        public void Add(string value)
        {
            ExtendListAtOneEnd(value);
        }

        public ListNode Find(string value)
        {
            return FindFromHeadToNext(value);
        }

        public void Delete(ListNode node)
        {
            RemoveNodeFromList(node);
        }

        protected string[] GetValuesFirstInFirstOut()
        {
            string[] arr = new string[Count];
            var currentNode = Head;

            for (var i = Count - 1; i > -1; i--)
            {
                arr[i] = currentNode.Value;
                currentNode = currentNode.Next;
            }

            return arr;
        }

        protected ListNode FindFromHeadToNext(string value)
        {
            var currentNode = Head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(value))
                    return currentNode;

                currentNode = currentNode.Next;
            }

            return null;
        }

        protected virtual void ExtendListAtOneEnd(string value)
        {
            return;
        }

        protected virtual void RemoveNodeFromList(ListNode node)
        {
            return;
        }
    }
}
