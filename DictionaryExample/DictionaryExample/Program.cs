using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Shiv");//While 'ADD'ing an item to Dictionary perform an operation - 'checkIfKeydtreadyExist'
            dt.Add(29, "Rajesh");
            dt.Add(30, "Ramesh");
            dt.Add(20, "Sandeep");
            dt.Add(31, "Rajesh");
            //dt.Add(2, "USA"); //This item can't be added to Dictionary because of the 'key' repetition
            Console.WriteLine("Items of the Dictionary after adding few items to it");
            PrintDictionary(dt);

            //Remove an item from Dictionary
            //Remove by object
            dt.Remove(3);
            Console.WriteLine("Items of the Dictionary after removing the item with key as '3(which wasn't really exist in the dt)'");
            PrintDictionary(dt);

            Dictionary<string, int> dt2 = new Dictionary<string, int>();
            dt2.Add("Shiv",1);//While 'ADD'ing an item to Dictionary perform an operation - 'checkIfKeydtreadyExist'
            dt2.Add("Rajesh",29);
            dt2.Add("Ramesh",30);
            dt2.Add("Sandeep",20);
            //dt2.Add("Rajesh",31);//The key "Rajesh" already present in the dictionary, so it wont allow us to add it again
            Console.WriteLine("Items of the Dictionary 'dt2'");
            PrintDictionary2(dt2);

            dt2.Remove("Rajesh");
            Console.WriteLine("Items of the Dictionary after removing the item with key as 'Rajesh'");
            PrintDictionary2(dt2);

            Console.WriteLine("When called GetType()");
            Console.WriteLine(dt.GetType());

            //Remove dtl the items in a single attempt
            dt.Clear();
            Console.WriteLine("After Clearing all the items of the Dictionary");
            PrintDictionary(dt);
            Console.Read();
        }

        private static void PrintDictionary(Dictionary<int,string> dt)
        {
            Console.WriteLine("Size of the Dictionary: " + dt.Count);
            if (dt.Count > 0)
            {
                //foreach (int key in dt.Keys)
                //{
                //    Console.WriteLine(key);
                //}

                //foreach (object value in dt.Values)
                //{
                //    Console.WriteLine(value);
                //}

                foreach (KeyValuePair<int, string> pair in dt)
                {
                    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                }
            }
            else
            {
                Console.WriteLine("***No Items available in the Dictionary***");
            }
            Console.WriteLine("");
        }

        private static void PrintDictionary2(Dictionary<string, int> dt)
        {
            Console.WriteLine("Size of the Dictionary: " + dt.Count);
            if (dt.Count > 0)
            {
                foreach (KeyValuePair<string, int> pair in dt)
                {
                    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                }
            }
            else
            {
                Console.WriteLine("***No Items available in the Dictionary***");
            }
            Console.WriteLine("");
        }
    }
}
