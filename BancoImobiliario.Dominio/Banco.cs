namespace BancoImobiliario.Dominio
{
    public class Banco
    {
        public int Saldo { get; set; } = SaldoInicial;
        public static int SaldoInicial { get; } = 20580;
    }
}