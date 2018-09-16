using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            string s = "";
            string t = "";
            Console.Write("Please input a number:");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            Console.Write("Please input a number:");
            t = Console.ReadLine();
            b = Int32.Parse(t);
            int c = a * b;
            Console.Write("The product is:"+c);
        }
    }
}
