using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int max = array[0];
            int min = array[0];
            int sum = 0;
            int n = 0;
            foreach (int i in array)
            {
                if (max < i) max = i;
                if (min > i) min = i;
                sum += i;
                n++;
            }
            double average = (double)sum / n;
            Console.WriteLine("最大值：" + max.ToString());
            Console.WriteLine("最小值：" + min.ToString());
            Console.WriteLine("平均值：" + average.ToString());
            Console.WriteLine("和：" + sum.ToString());
        }
                
    }
}
