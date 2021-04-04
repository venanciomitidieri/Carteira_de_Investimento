using System;

namespace CarteiradeInvestimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Menu de Aplicação:\n\n1 - Adiconar um novo ativo na Carteira \n" +
                "2 - Visualizar a lista de ativos investidos \n" +
                "3 - Informar a venda de um ativo \n" +
                "4 - Visualizar um resumo do valor total investido\n" +
                "5 - Sair do menu \n\n" +
                "Selecione uma opção: ");

            string opcao = Console.ReadLine();

            while (Int32.Parse(opcao) <= 5)
            {
                switch(Int32.Parse(opcao))
                { 
                    case 1:
                        Console.WriteLine("\nEntrando... Adicionar um novo ativo na Carteira");
                        CarteiraDeInvestimento opcao_1 = new CarteiraDeInvestimento();
                        opcao_1.adicionaNovoAtivo();
                        continue;

                    case 2:
                        Console.WriteLine("Entrando...Visualizar lista de ativos investido");
                        CarteiraDeInvestimento opcao_2 = new CarteiraDeInvestimento();
                        opcao_2.visualizarListaAtivosInvestido();
                        break;

                    case 3:
                        Console.WriteLine("Entrando... Informar a venda de um ativo");
                        CarteiraDeInvestimento opcao_3 = new CarteiraDeInvestimento();
                        opcao_3.informarVendaAtivo();
                        break;

                    case 4:
                        Console.WriteLine("Entrando... Visualizar um resumo do valor total investido");
                        CarteiraDeInvestimento opcao_4 = new CarteiraDeInvestimento();
                        opcao_4.visualizarResumoValorInvestido();
                        break;

                    case 5:
                        Console.WriteLine("Saindo da aplicação");
                        CarteiraDeInvestimento opcao_5 = new CarteiraDeInvestimento();
                        opcao_5.saindoDaAplicacao();
                        break;

                    case 6:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }
        }
    }
}
