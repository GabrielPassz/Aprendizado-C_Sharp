using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            float notaA = 0;
            float notaB = 0;
            float notaC = 0;
            float notaD = 0;
            int PESO_1 = 2;
            int PESO_2 = 3;
            float media = 0;

            Console.WriteLine("Insira a nota da primeira prova:");
            notaA = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira a nota da segunda prova:");
            notaB = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira a nota da terceira prova:");
            notaC = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira a nota da quarta prova:");
            notaD = Convert.ToSingle(Console.ReadLine());

            media = (((notaA * PESO_1) + (notaB * PESO_1) + (notaC * PESO_2) + (notaD * PESO_2)) / ((PESO_1 * 2) + (PESO_2 * 2)));

            Console.WriteLine($"A medeia é {media}");


        }
    }
}
