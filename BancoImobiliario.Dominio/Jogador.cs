namespace BancoImobiliario.Dominio
{
    public class Jogador
    {
        public Jogador(int numeroCor)
        {
            Cor = (Cor)numeroCor;
        }

        public Cor Cor { get; set; }
        public int Saldo { get; set; } = 1500;
    }
}