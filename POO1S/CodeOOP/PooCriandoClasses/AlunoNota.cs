using System;

namespace PooCriandoClasses
{
    internal class AlunoNota
    {
        private string nome;
        private int idade;
        private TipoNota notaAluno;
        public enum TipoNota
        {
            MB,
            B,
            R,
            I
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        internal TipoNota NotaAluno { get => notaAluno; set => notaAluno = value; }
        public AlunoNota()
        {
            Nome = "Desconhecido";
            Idade = 0;
            NotaAluno = TipoNota.MB;
        }

        public AlunoNota(string nome)
        {
            Nome = nome;
            Idade = 0;
            NotaAluno = TipoNota.MB;
        }

        public AlunoNota(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            NotaAluno = TipoNota.MB;
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Nota: {NotaAluno}");
        }
    }
}