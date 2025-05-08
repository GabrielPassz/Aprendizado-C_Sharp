namespace PooCriandoClasses
{
    internal class Caneta
    {
        private string cor;
        private TipoCaneta EstiloCaneta;
        private enum TipoCaneta
        {
            esferografica,
            rollerball,
            gel,
            tinteiro,
            ponta_feltro
        }
        public Caneta() { }

        public Caneta(string cor)
        {
            this.cor = cor;
        }
        public string Cor { get => cor; set => cor = value; }
    
    }
}