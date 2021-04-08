using NUnit.Framework;


namespace CarteiraDeInvestimentos.test
{
    [TestFixture]
    public class CarteiraDeInvestimentoTest
    {
        [Test]
        public void deveSerAdicionadoUmAtivo()
        {
            carteiraDeInvestimentos carteiradeInvestimentos = new carteiraDeInvestimentos();
            carteiradeInvestimentos.adicionaNovoAtivo();
            var resultado = carteiradeInvestimentos.listaDeAtivos;
            Assert.AreEqual(1, resultado.Count);
        }
    }
}