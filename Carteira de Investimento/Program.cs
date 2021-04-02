using System;

namespace CarteiradeInvestimentos
{
    class CarteiraDeInvestimento
    {
        public void adicionaNovoAtivo()
        {
            Console.WriteLine("Adicionando novo ativo na carteira");
        }
    }
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
                //Console.WriteLine("Entrando... Adicionar um novo ativo na Carteira");
                CarteiraDeInvestimento opcao_1 = new CarteiraDeInvestimento();
                opcao_1.adicionaNovoAtivo();
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Entrando...Informar a venda de um ativo");
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Entrando... Informar a venda de um ativo");
            }
            else if (opcao == "4")
            {
                Console.WriteLine("Entrando... Visualizar um resumo do valor total investido");
            }
            else if (opcao == "5")
            {
                Console.WriteLine("Saindo da aplicação");
            }
            else
            {
                Console.WriteLine("Opção invalida");
            }
        }
    }
}
