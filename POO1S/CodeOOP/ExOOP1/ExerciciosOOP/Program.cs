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
            int ANO_ATUAL = 2025;
            int anoAluno = 0;
            int idadeAluno = 0;
            string nomeAluno = "";

            Console.WriteLine("Insira o nome do aluno:");
            nomeAluno = Console.ReadLine();

            Console.WriteLine("Insira o ano de nascimento do aluno");
            anoAluno = Convert.ToInt32(Console.ReadLine());

            idadeAluno = ANO_ATUAL - anoAluno;

            if (idadeAluno >= 18)
            {
                Console.WriteLine($"O aluno, {nomeAluno}, é maior de idade, ele tem {idadeAluno} anos.");

            }
            else
            {
                Console.WriteLine($"O aluno, {nomeAluno}, é menor de idade, ele tem {idadeAluno} anos");
            }


        }
    }
}
