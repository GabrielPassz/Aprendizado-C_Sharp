using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXOOP10
{
    class Program
    {
        static void Main(string[] args)
        {
            for(double VALORCIMA = 1, VALORBAIXO = 2; VALORCIMA <= 100; VALORCIMA += 3)
            {
                Console.WriteLine(VALORCIMA + "\n----------\n" + VALORBAIXO + "\n==========\n" + VALORCIMA/VALORBAIXO + "\n");
                
                VALORBAIXO *= 2;
            }




        }
    }
}
