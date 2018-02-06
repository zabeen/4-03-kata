using System;

namespace ListKata.Models
{
    public interface ILinkedList
    {
        int Count { get; }

        string[] Values();
        void Add(string value);
        ListNode Find(string value);
        void Delete(ListNode node);
    }
}
