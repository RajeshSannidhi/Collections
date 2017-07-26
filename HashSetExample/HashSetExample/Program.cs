using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> hs = new HashSet<int>();
            hs.Add(10);
            hs.Add(20);
            hs.Add(40);
            hs.Add(25);
            hs.Add(20);
            hs.Add(25);
            foreach (var item in hs)
                Console.WriteLine("    "+item);
            Console.ReadLine();
        }
    }
}
