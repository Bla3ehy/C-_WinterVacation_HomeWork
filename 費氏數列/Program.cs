using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class fibonacci
    {
        static void Main(string[] args)
        {
            int num = 47;
            int[] fib = new int[num];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 0; i < num; i++)
            {
                if (i == 0 || i == 1)
                {
                    Console.WriteLine(fib[i]);
                }
                else
                {
                    Console.WriteLine(fib[i] = fib[i - 1] + fib[i - 2]);
                }
            }
            Console.ReadLine();
        }
    }
}
