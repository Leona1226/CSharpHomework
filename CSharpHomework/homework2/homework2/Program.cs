﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入整数：");
            string s = Console.ReadLine();
            int n = Int32.Parse(s);
            for(int i = 2;i<=n;i++)
            {
                if (n % i == 0)
                {
                    n = n / i;
                    Console.Write(i.ToString());
                    Console.Write(" ");
                }
            }
        }
    }
}