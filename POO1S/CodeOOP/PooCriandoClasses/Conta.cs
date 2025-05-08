namespace PooCriandoClasses
{
    internal class Conta
    {
        string numero;
        string cliente;
        double saldo;

        public string Numero { get => numero; set => numero = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public void Depositar(double valor) { }
        public void Sacar(double valor) { }
        public void FazerPix(double valor) { }
    }
}