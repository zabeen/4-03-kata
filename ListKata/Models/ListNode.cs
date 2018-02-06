using System;

namespace ListKata.Models
{
    public class ListNode : IEquatable<ListNode>
    {
        public string Value { get; }
        public ListNode Next { get; set; }
        public ListNode Previous { get; set; }

        public ListNode(string value, ListNode next)
        {
            Value = value;
            Next = next;
        }

        public bool Equals(ListNode other)
        {
            return other != null && Value.Equals(other.Value) && ReferenceEquals(Next, other.Next) && ReferenceEquals(Previous, other.Previous);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ListNode)obj);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
