using System;

namespace CarteiradeInvestimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            CarteiraDeInvestimento carteiraDeInvestimento = new CarteiraDeInvestimento();

            bool sairDoLoop = false;

            while(!sairDoLoop)
            {
                Console.Write("\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.Write("\nMenu de Aplicação:\n\n1 - Adiconar um novo ativo na Carteira \n" +
                      "2 - Visualizar a lista de ativos investidos \n" +
                      "3 - Informar a venda de um ativo \n" +
                      "4 - Visualizar um resumo do valor total investido\n" +
                      "5 - Sair do menu \n\n" +
                      "Selecione uma opção: ");

                string opcao = Console.ReadLine();
                Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                int n = Int32.Parse(opcao);

                switch (n)
                {
                    case 1:
                        Console.WriteLine("\nEntrando... Adicionar um novo ativo na Carteira");
                        carteiraDeInvestimento.adicionaNovoAtivo();

                        Console.Write("Deseja voltar ao menu? S[1] N[2]: ");
                        string voltarMenu = Console.ReadLine();

                        if (voltarMenu == "1")
                            continue;
                        else
                            sairDoLoop = true;
                        break;

                    case 2:
                        Console.WriteLine("\nLista de Ativos Investidos: ");
                        carteiraDeInvestimento.visualizarListaAtivosInvestido();

                        Console.Write("\nDeseja voltar ao menu? S[1] N[2]: ");
                        voltarMenu = Console.ReadLine();

                        if (voltarMenu == "1")
                            continue;
                        else
                            sairDoLoop = true;
                        break;

                    case 3:
                        Console.WriteLine("\nEntrando... Informar a venda de um ativo");
                        carteiraDeInvestimento.informarVendaAtivo();

                        Console.Write("\nDeseja voltar ao menu? S[1] N[2]: ");
                        voltarMenu = Console.ReadLine();

                        if (voltarMenu == "1")
                            continue;
                        else
                            sairDoLoop = true;
                        break;

                    case 4:
                        Console.WriteLine("\nEntrando... Visualizar um resumo do valor total investido");
                        carteiraDeInvestimento.visualizarResumoValorInvestido();

                        Console.Write("\nDeseja voltar ao menu? S[1] N[2]: ");
                        voltarMenu = Console.ReadLine();

                        if (voltarMenu == "1")
                            continue;
                        else
                            sairDoLoop = true;
                        break;

                    case 5:
                        sairDoLoop = true;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }
        }
    }
}
