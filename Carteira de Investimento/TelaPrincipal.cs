using System;

namespace CarteiraDeInvestimentos
{
    class TelaPrincipal
    {
        static void Main(string[] args)
        {
            CarteiraDeInvestimento carteiraDeInvestimento = new CarteiraDeInvestimento();

            TelaAtivo telaAtivo = new TelaAtivo(carteiraDeInvestimento);

            bool Loop = false;

            void saiLoop()
            {
                Console.Write("\nDeseja voltar ao menu? S[1] N[2]: ");
                string voltarMenu = Console.ReadLine();

                if (voltarMenu == "1")
                    Loop = false;
                else
                    Loop = true;
            }

            while (!Loop)
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
                        Console.WriteLine("\nADICIONAR NOVO ATIVO NA CARTEIRA:\n");
                        telaAtivo.telaAdicionaNovoAtivo();
                        saiLoop();
                        break;

                    case 2:
                        Console.WriteLine("\nLISTA DE ATIVOS INVESTIDOS:\n");
                        carteiraDeInvestimento.visualizarListaAtivosInvestido();
                        saiLoop();
                        break;

                    case 3:
                        Console.WriteLine("\nINFORMAR VENDA DE UM ATIVO:\n");
                        carteiraDeInvestimento.informarVendaAtivo();
                        saiLoop();
                        break;

                    case 4:
                        Console.WriteLine("\nEntrando... Visualizar um resumo do valor total investido");
                        carteiraDeInvestimento.visualizarResumoValorInvestido();
                        saiLoop();
                        break;

                    case 5:
                        Loop = true;
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }
        }
    }
}
