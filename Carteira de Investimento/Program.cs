using System;
//using GerenciaCarteiraDeInvestimento;

namespace CarteiradeInvestimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu de Aplicação:\n\n1 - Adiconar um novo ativo na Carteira \n" +
                "2 - Visualizar a lista de ativos investidos \n" +
                "3 - Informar a venda de um ativo \n" +
                "4 - Visualizar um resumo do valor total investido\n" +
                "5 - Sair do menu \n\n" +
                "Selecione uma opção: ");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                Console.WriteLine("Entrando... Adicionar um novo ativo na Carteira");
                CarteiraDeInvestimento opcao_1 = new CarteiraDeInvestimento();
                opcao_1.adicionaNovoAtivo();
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Entrando...Visualizar lista de ativos investido");
                CarteiraDeInvestimento opcao_2 = new CarteiraDeInvestimento();
                opcao_2.visualizarListaAtivosInvestido();
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Entrando... Informar a venda de um ativo");
                CarteiraDeInvestimento opcao_3 = new CarteiraDeInvestimento();
                opcao_3.informarVendaAtivo();
            }
            else if (opcao == "4")
            {
                Console.WriteLine("Entrando... Visualizar um resumo do valor total investido");
                CarteiraDeInvestimento opcao_4 = new CarteiraDeInvestimento();
                opcao_4.visualizarResumoValorInvestido();
            }
            else if (opcao == "5")
            {
                Console.WriteLine("Saindo da aplicação");
                CarteiraDeInvestimento opcao_5 = new CarteiraDeInvestimento();
                opcao_5.saindoDaAplicacao();
            }
            else
            {
                Console.WriteLine("Opção invalida");
            }
        }
    }
}
