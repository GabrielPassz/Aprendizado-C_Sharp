using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooMensagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg1, msg2;
            msg1 = new Mensagem();
            msg1.TextoMensagem = "ola mundo";
            msg1.ExibirMensagem();

            //msg2 = new Mensagem();
            //msg2.TextoMensagem = "Você e Foda!";
            //msg2.ExibirMensagem();
            Console.ReadKey();
        }
    }
}
