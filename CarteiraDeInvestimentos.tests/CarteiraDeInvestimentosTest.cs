using NUnit.Framework;
using CarteiradeInvestimentos;

namespace CarteiraDeInvestimentos.tests
{
    [TestFixture]
    public class CarteiraDeInvestimentoTest
    {
        [Test]
        public void deveSerAdicionadoUmAtivo()
        {
            CarteiraDeInvestimento carteiradeInvestimentos = new CarteiraDeInvestimento();
            carteiradeInvestimentos.adicionaNovoAtivo();
            var resultado = carteiradeInvestimentos.listaDeAtivos;
            Assert.AreEqual(1, resultado.Count);
        }
    }
}