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
            float peso = 0;
            float altura = 0;
            float imc = 0;

            Console.WriteLine("Insira seu peso:");
            peso = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira sua altura:");
            altura = Convert.ToSingle(Console.ReadLine());

            imc = peso / (altura * 2);

            Console.WriteLine($"Seu indice de massa corporal é {imc}");


        }
    }
}
