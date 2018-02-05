namespace ListKata.Models
{
    public class ListNode
    {
        public string Value { get; set; }
        public ListNode Next { get; set; }
        public ListNode Previous { get; set; }

        public ListNode(string value, ListNode next)
        {
            Value = value;
            Next = next;
        }

        public ListNode(string value, ListNode next, ListNode previous)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
    }
}
