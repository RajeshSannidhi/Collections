using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("Rajesh");
            al.Add("NJ");
            al.Add(10000.0);

            al.Add(2);
            al.Add("Sandeep");
            al.Add("MO");
            al.Add(100000.0);

            al.Add(1);
            al.Add("Rajesh");
            al.Add("NJ");
            al.Add(10000.0);
            Console.WriteLine("Items of the ArrayList after adding few items to it");
            PrintArrayList(al);

            //Remove an item from ArrayList
            //Remove by object
            al.Remove("Rajesh");
            Console.WriteLine("Items of the ArrayList after remoing the item Rajesh");
            PrintArrayList(al);
            
            //Remove by index
            al.RemoveAt(0);
            Console.WriteLine("Items of the ArrayList after remoing the item at index 0");
            PrintArrayList(al);

            //Insert an item in the ArrayList
            al.Insert(0, 1);
            Console.WriteLine("Items of the ArrayList after inserting an item(1) at index 0");
            PrintArrayList(al);

            //Insert an ArrayList to the other ArrayList
            ArrayList al2=new ArrayList();
            al2.Add(111);
            al2.Add(222);
            al.InsertRange(0, al2);
            Console.WriteLine("Items of the ArrayList(111,222) after inserting a arraylist at index 0");
            PrintArrayList(al);

            Console.WriteLine("When called GetType()");
            Console.WriteLine(al.GetType());

            //Remove all the items in a single attempt
            al.Clear();
            Console.WriteLine("After Clearing all the Items of the ArrayList");
            PrintArrayList(al);
            Console.Read();
        }

        private static void PrintArrayList(ArrayList al)
        {
            Console.WriteLine("Size of the ArrayList: " + al.Count);

            if (al.Count > 0)
            {
                for (int i = 0; i < al.Count; i++)
                {
                    Console.WriteLine(al[i]);
                }
            }
            else
            {
                Console.WriteLine("***No Items available in the ArrayList***");
            }
            Console.WriteLine("");
        }
    }
}
