namespace PooCriandoClasses
{
    internal class TrocadorCalor
    {
        double areaSuperficie;
        float diamentroTubo;
        double comprimentoTubo;
        float pressaoTubo;
         float pressaoRevestimento;

        public double AreaSuperficie { get => areaSuperficie; set => areaSuperficie = value; }
        public float DiamentroTubo { get => diamentroTubo; set => diamentroTubo = value; }
        public double ComprimentoTubo { get => comprimentoTubo; set => comprimentoTubo = value; }
        public float PressaoTubo { get => pressaoTubo; set => pressaoTubo = value; }
        public float PressaoRevestimento { get => pressaoRevestimento; set => pressaoRevestimento = value; }
    }
}