using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExOOP_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double ALUNO_VALOR1 = 0.30D, ÑALUNO_VALOR2 = 0.50D;

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("|-QTD-|  " + "|-ALUNO-|  " + "|-ÑALUNO-|"  );
            Console.WriteLine("----------------------------------------");

            for (int i = 1; i <= 100; i++) 
            {
                //Console.WriteLine("|" + i + " | " + "|" + ALUNO_VALOR1 * i + "  |  " + "|  " + ÑALUNO_VALOR2 * i + "  |");
                Console.WriteLine($"|  {i}  |   |  {ALUNO_VALOR1 * i}  |   |  {ÑALUNO_VALOR2 * i}  |");

            }













        }
    }
}
