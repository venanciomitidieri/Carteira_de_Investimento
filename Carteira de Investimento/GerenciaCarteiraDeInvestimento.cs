using System;

namespace CarteiradeInvestimentos
{
    class CarteiraDeInvestimento
    {
        public void adicionaNovoAtivo()
        {
            Console.WriteLine("Adicionando novo ativo na carteira");
        }

        public void visualizarListaAtivosInvestido()
        {
            Console.WriteLine("Visualizando lista de ativos investidos");
        }

        public void informarVendaAtivo()
        {
            Console.WriteLine("Informando venda de um ativo");
        }

        public void visualizarResumoValorInvestido()
        {
            Console.WriteLine("Visualizando resumo do valor total investido em ativos");
        }

        public void saindoDaAplicacao()
        {
            Console.WriteLine("Você esta saindo da aplicação");
        }
    }
}