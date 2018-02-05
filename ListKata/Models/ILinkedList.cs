using System;

namespace ListKata.Models
{
    public interface ILinkedList //: IEquatable<string>
    {
        ListNode Head { get; }
        int Count { get; }

        void Add(string value);
        ListNode Find(string value);
        void Delete(ListNode node);
    }
}
