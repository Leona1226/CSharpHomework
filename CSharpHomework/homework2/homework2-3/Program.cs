using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[99];
            int[] array2 = new int[50];
            for(int i = 0;i<99;i++)
            {
                array[i] = i + 2;
            }
            int j = 0;
            foreach (int i in array)
            {
                if ((i%2!=0) && (i%3!=0) && (i%5!=0) && (i%7!=0))
                {
                    array2[j] = i;
                    j++;
                }
            }
            Console.WriteLine("2~100以内的素数：");
            Console.WriteLine("2\n3\n5\n7");
            foreach(int i in array2)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
