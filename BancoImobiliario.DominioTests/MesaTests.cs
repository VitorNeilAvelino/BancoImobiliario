using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BancoImobiliario.Dominio.Tests
{
    [TestClass()]
    public class MesaTests
    {
        [TestMethod()]
        public void MesaTest()
        {
            //Arranje / Act
            var mesa = new Mesa(4);

            //Assert
            Assert.AreEqual(mesa.Jogadores.Count, 4);
            Assert.IsTrue(mesa.Jogadores[0].Cor == Cor.Preto);
            Assert.IsTrue(mesa.Jogadores[0].Saldo == Jogador.SaldoInicial);
            Assert.IsTrue(mesa.Banco.Saldo == Banco.SaldoInicial - (Jogador.SaldoInicial * 4));
        }
    }
}