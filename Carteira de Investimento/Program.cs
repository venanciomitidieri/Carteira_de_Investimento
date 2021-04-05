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
                Console.Write("\nMenu de Aplicação:\n\n1 - Adiconar um novo ativo na Carteira \n" +
                      "2 - Visualizar a lista de ativos investidos \n" +
                      "3 - Informar a venda de um ativo \n" +
                      "4 - Visualizar um resumo do valor total investido\n" +
                      "5 - Sair do menu \n\n" +
                      "Selecione uma opção: ");

                string opcao = Console.ReadLine();
                int n = Int32.Parse(opcao);

                switch (n)
                {
                    case 1:
                        Console.WriteLine("\nEntrando... Adicionar um novo ativo na Carteira");
                        carteiraDeInvestimento.adicionaNovoAtivo();
                        break;

                    case 2:
                        Console.WriteLine("Entrando...Visualizar lista de ativos investido");
                        carteiraDeInvestimento.visualizarListaAtivosInvestido();
                        break;

                    case 3:
                        Console.WriteLine("Entrando... Informar a venda de um ativo");
                        carteiraDeInvestimento.informarVendaAtivo();
                        break;

                    case 4:
                        Console.WriteLine("Entrando... Visualizar um resumo do valor total investido");
                        carteiraDeInvestimento.visualizarResumoValorInvestido();
                        break;

                    case 5:
                        sairDoLoop = true;
                        //Console.WriteLine("Saindo da aplicação");
                        //carteiraDeInvestimento.saindoDaAplicacao();
                        break;

                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }
        }
    }
}
