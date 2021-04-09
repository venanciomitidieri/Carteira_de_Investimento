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
            var resultado = carteiradeInvestimentos.visualizarListaAtivosInvestido();
            Assert.AreEqual(1, resultado.Count);
        }

        [Test]
        public void deveVisualizarAtivo()
        {
            CarteiraDeInvestimento carteiradeInvestimentos = new CarteiraDeInvestimento();
            Ativo ativo_test = new Ativo("stone", 20, 10, "Venâncio", "CDB", DateTime.Now);

            carteiradeInvestimentos.adicionaNovoAtivo(ativo_test);
            var resultado = carteiradeInvestimentos.visualizarListaAtivosInvestido().Find(item => item.codigo.Equals("stone"));
            Assert.AreEqual("stone", resultado.codigo);
        }

        [Test]
        public void deveVenderAtivo()
        {
            CarteiraDeInvestimento carteiradeInvestimentos = new CarteiraDeInvestimento();
            Ativo ativo_test = new Ativo("stone", 20, 10, "Venâncio", "CDB", DateTime.Now);

            carteiradeInvestimentos.adicionaNovoAtivo(ativo_test);
            carteiradeInvestimentos.informarVendaAtivo("stone", 10);
            var ativos = carteiradeInvestimentos.visualizarListaAtivosInvestido();
            var resultado = ativos.Find(item => item.codigo.Equals("stone"));
            Assert.AreEqual(10, resultado.quantidade);
        }

        [Test]
        public void deveVisualizarResumoAtivo()
        {
            CarteiraDeInvestimento carteiradeInvestimentos = new CarteiraDeInvestimento();
            Ativo ativo_test_1 = new Ativo("stone", 20, 10, "Venâncio", "CDB", DateTime.Now);
            Ativo ativo_test_2 = new Ativo("hp", 20, 10, "Venâncio", "CDB", DateTime.Now);
            Ativo ativo_test_3 = new Ativo("google", 20, 10, "Venâncio", "CDB", DateTime.Now);

            carteiradeInvestimentos.adicionaNovoAtivo(ativo_test_1);
            carteiradeInvestimentos.adicionaNovoAtivo(ativo_test_2);
            carteiradeInvestimentos.adicionaNovoAtivo(ativo_test_3);

            var (lista, total) = carteiradeInvestimentos.visualizarResumoValorInvestido();

            Assert.AreEqual(600, total);
            Assert.AreEqual("Valor alocado em stone: 200", lista[0]);
        }
    }
}