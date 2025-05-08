namespace PooClassMediaAluno
{
    internal class Aluno
    {
        string matricula;
        string nome;
        double n1;
        double n2;
        double t1;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public double N1 { get => n1; set => n1 = value; }
        public double N2 { get => n2; set => n2 = value; }
        public double T1 { get => T1; set => T1 = value; }

        public double CalcularMedia()
        {
            const double PESO_PROVA = 2.5;
            const double PESO_TRABALHO = 2;
            double media;
            media = ((N1 * PESO_PROVA) + (N2 * PESO_PROVA) + (T1  *PESO_TRABALHO)) / ((2 * PESO_PROVA) + PESO_TRABALHO);
            return media;
        }
        public double MediaFinal()
        {
            double mediaFinal = 0;
            if (CalcularMedia() < 7)
            {
                mediaFinal = (10 - CalcularMedia());
            }
            return mediaFinal;
        }
    }
}