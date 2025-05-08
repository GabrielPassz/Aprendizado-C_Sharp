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
            float lado1 = 0;
            float lado2 = 0;
            float lado3 = 0;

            Console.WriteLine("Insira o tamanho do primeira lado do triangulo:");
            lado1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o tamanho do segundo lado do triangulo:");
            lado2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o tamanho do terceiro lado do triangulo:");
            lado3 = Convert.ToSingle(Console.ReadLine());

            if(lado1 < (lado2 + lado3) && lado2 < (lado1 + lado3) && lado3 < (lado1 + lado2))
            {
                if(lado1 == lado2 && lado2 == lado3 &&  lado3 == lado1)
                {
                    Console.WriteLine("Pode-se um triângulo e ele é equilátero");
                }
                else
                {
                    if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1)
                    {
                        Console.WriteLine("Pode-se um triângulo e ele é isósceles");
                    }
                    else
                    {
                        Console.WriteLine("Pode-se um triângulo, e ele é escaleno");
                    }
                }
            }
            else
            {
                Console.WriteLine("Não é um triângulo");
            }

        }
    }
}
