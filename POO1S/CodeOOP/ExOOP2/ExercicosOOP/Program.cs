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
            string nomeUser = "";
            char sexoUser = ' ';
            
            Console.WriteLine("Insira o nome do usuário:");
            nomeUser = Console.ReadLine();

            Console.WriteLine("Defina seu sexo, digitando 'F' para feminino ou 'M' para masculino:");
            sexoUser = Convert.ToChar(Console.ReadLine());
            if (sexoUser == 'M' || sexoUser == 'm')
            {
                Console.WriteLine($"Nome do usuário é {nomeUser}, e seu sexo é masculino");

            }
            else
            {
                Console.WriteLine($"Nome do usuário é {nomeUser}, e seu sexo é feminino");
            }

            


        }
    }
}
