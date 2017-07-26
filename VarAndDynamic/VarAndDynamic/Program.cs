using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarAndDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var str1 = "Rajesh";
            int len = str1.Length; //Compiler will identify the 'Length' property at compile time

            dynamic str2 = "Rajesh";
            int len2 = str2.length; //though 'lenght' property is not available, error will be thrown at runtime only
            
        }
    }
}
