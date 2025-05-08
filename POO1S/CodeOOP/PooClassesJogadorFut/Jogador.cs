using System;

namespace PooClassesJogadorFut
{
    internal class Jogador
    {
        const int ANO_ATUAL = 2025;
        enum NomePosicao
        {
            Defesa,
            MeioCampo,
            Atacante
        }

        string nome;
        string nacionalidade;
        float alutra;
        float peso;
        int diaNascimento;
        int mesNascimento;
        int anoNascimento;
        NomePosicao posicao;

        public string Nome { get => nome; set => nome = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
        public float Alutra { get => alutra; set => alutra = value; }
        public float Peso { get => peso; set => peso = value; }
        public int DiaNascimento { get => diaNascimento; set => diaNascimento = value; }
        public int MesNascimento { get => mesNascimento; set => mesNascimento = value; }
        public int AnoNascimento { get => anoNascimento; set => anoNascimento = value; }
        private NomePosicao Posicao { get => Posicao; set => Posicao = value; }

        public void ExibirDados()
        {
            Console.WriteLine("=======| FICHA DO JOGADOR |=======");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Data de nascimento: {DiaNascimento}/{MesNascimento}/{AnoNascimento}");
            Console.WriteLine($"Nascionalidade: {Nacionalidade}");
            Console.WriteLine($"Posição: {Posicao}");
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Altura: {Alutra}");
        }

        public int CalcIdadeJogador()
        {
            int idadeJogador = 0;
            idadeJogador = ANO_ATUAL - AnoNascimento;
            return idadeJogador;
        }
        public int AposentadoriaJogador()
        {
            int tempo = 0;
            if(Posicao == NomePosicao.Defesa)
            {
                tempo = (40 - CalcIdadeJogador());
            }
            else
            {
                if(Posicao == NomePosicao.MeioCampo)
                {
                    tempo = (38 - CalcIdadeJogador());
                }
                else
                {
                    tempo = (35 - CalcIdadeJogador());
                }
            }
            return tempo;
        }
    }
}