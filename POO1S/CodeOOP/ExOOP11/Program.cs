using System;

namespace ExOOP11
{
    class Program
    {
        static void Main(string[] args)
        {
            int CONT = 0;
            for (int VALOR1 = 1000, VALOR2 = 1999; VALOR1 <= VALOR2; VALOR1++)
            {
                //Console.WriteLine(VALOR1);
                if (VALOR1 % 11 == 5)
                {
                    CONT++;
                    //Console.WriteLine(VALOR1);
                }

            }
            //Console.WriteLine($"{CONT}");
            Console.WriteLine(CONT);




        }
    }
}
