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
            float META_VEND = 1500F;
            float montVend = 0;
            string nomeVend = "";

            Console.WriteLine("Insira o nome do vendedor:");
            nomeVend = Console.ReadLine();

            Console.WriteLine("Digite o montante de vendas da semana realizado:");
            montVend = Convert.ToSingle(Console.ReadLine());

            if (montVend >= META_VEND)
            {
                Console.WriteLine($"O vendedor, {nomeVend}, atingiu a meta! Sua montante da semana foi de {montVend} reais");
            }
            else
            {
                Console.WriteLine($"O vendedor, {nomeVend}, nãp atingiu a meta! Sua montante da semana foi de {montVend} reais");
            }
             
                       
                   
                
            


        }
    }
}
