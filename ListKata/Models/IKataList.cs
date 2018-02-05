using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListKata.Models
{
    public interface IKataList : IEquatable<string>
    {
        ListNode First { get; set; }
        void Add(string item);
        ListNode Find(string item);
        void Delete(ListNode item);
    }
}
