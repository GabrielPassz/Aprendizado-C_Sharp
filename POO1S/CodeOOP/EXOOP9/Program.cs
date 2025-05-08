using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXOOP9
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0, menor = 0, maior = 0;

            for(int i = 1; i <= 5; i++) 
            {
                Console.WriteLine("Insira os Valores: ");
                valor = Convert.ToInt16(Console.ReadLine());
                if(i == 1)
                {
                    menor = maior = valor;
                }
                if(valor > maior)
                {
                    maior = valor;
                }
                if (valor < menor)
                {
                    menor = valor;
                }
                //Console.WriteLine($"{menor}, {maior}");
            
            }

            Console.WriteLine($"{menor}, {maior}");
        }
    }
}
