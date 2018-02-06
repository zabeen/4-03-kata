namespace ListKata.Models
{
    public class ListNode
    {
        public string Value { get; set; }
        public ListNode Next { get; set; }
        public ListNode Previous { get; set; }

        public ListNode()
        {
        }

        public ListNode(string value, ListNode next)
        {
            Value = value;
            Next = next;
        }
    }
}
