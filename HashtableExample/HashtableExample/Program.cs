using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, 1000);//While 'ADD'ing an item to Hashtable perform an operation - 'checkIfKeyalreadyExist'
            ht.Add(29, "Rajesh");//This indicates that we can add an item anywhere in the Hashtable
            ht.Add(30, "Ramesh");
            ht.Add(20,"Sandeep");
            ht.Add(2, "NJ");
            ht.Add(31, "Rajesh");
            //ht.Add(2, "USA"); //This item can't be added to Hashtable because of the 'key' repetition
            Console.WriteLine("Items of the Hashtable after adding few items to it");
            PrintHashtable(ht);
            //Remove an item from Hashtable
            //Remove by object
            ht.Remove(3);
            Console.WriteLine("Items of the Hashtable after removing the item with key as '3(which wasn't really exist in the ht)'");
            PrintHashtable(ht);
            //Insert an ArrayList to the Hashtable
            ArrayList al = new ArrayList();
            al.Add(111);
            al.Add(222);
            ht.Add(0, al);
            Console.WriteLine("Items of the Hashtable(111,222) after inserting an ArrayList with key 0");
            PrintHashtable(ht);

            Console.WriteLine("When called GetType()");
            Console.WriteLine(ht.GetType());

            //Remove htl the items in a single attempt
            ht.Clear();
            Console.WriteLine("After Clearing all the items of the Hashtable");
            PrintHashtable(ht);
            Console.Read();
        }

        private static void PrintHashtable(Hashtable ht)
        {
            Console.WriteLine("Size of the Hashtable: " + ht.Count);
            if (ht.Count > 0)
            {
                //foreach (int key in ht.Keys)
                //{
                //    Console.WriteLine(key);
                //}

                //foreach (object value in ht.Values)
                //{
                //    Console.WriteLine(value);
                //}

                foreach (DictionaryEntry entry in ht)
                {
                    Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
                }
            }
            else
            {
                Console.WriteLine("***No Items available in the Hashtable***");
            }
            Console.WriteLine("");
        }
    }
}
