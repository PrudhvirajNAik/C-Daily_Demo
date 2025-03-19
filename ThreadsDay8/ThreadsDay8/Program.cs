using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsDay8
{
    internal class Program
    {
        static void Fun1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Func1() writes {0}", i);
            }

        }

        public static void Fun2()
        {
            for (int j = 10; j > 0; j--)
            {
                Console.WriteLine("Func2() writes {0}", j);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("start of main()");
            Fun1();
            Fun2();
            Console.WriteLine("End of main()");
            Console.ReadLine();
        }
    }
    
}
