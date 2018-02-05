using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListKata.Models;

namespace ListKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SingleLinkedList();
            list.Add("bob");
            list.Add("kate");
            list.Find("foo");
            list.Find("bob");
        }
    }
}
