using NUnit.Framework;
using System;


namespace CarteiraDeInvestimentos.tests
{
    [TestFixture]
    public class CarteiraDeInvestimentoTest
    {
        [Test]
        public void deveSerAdicionadoUmAtivo()
        {
            CarteiraDeInvestimento carteiradeInvestimentos = new CarteiraDeInvestimento();
            Ativo ativo_test = new Ativo("stone", 20, 10, "Venâncio", "CDB", DateTime.Now);

            carteiradeInvestimentos.adicionaNovoAtivo(ativo_test);
            var resultado = carteiradeInvestimentos.listaDeAtivos;
            Assert.AreEqual(1, resultado.Count);
        }

        [Test]
        public void deveVisualizarAtivo()
        {
            CarteiraDeInvestimento carteiradeInvestimentos = new CarteiraDeInvestimento();
            Ativo ativo_test = new Ativo("stone", 20, 10, "Venâncio", "CDB", DateTime.Now);

            carteiradeInvestimentos.adicionaNovoAtivo(ativo_test);
            var resultado = carteiradeInvestimentos.listaDeAtivos.Find(item => item.codigo.Equals("stone"));
            Assert.AreEqual("stone", resultado.codigo);
        }
    }
}