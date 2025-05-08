using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP12
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1, a = 1, b = 0; i <= 1000; i+=b)
            {
                a = i + b;
                Console.WriteLine(i);
                Console.WriteLine(a);
                b = a + i;
                Console.WriteLine(b);
                i = a;
            }

        }
    }
}
