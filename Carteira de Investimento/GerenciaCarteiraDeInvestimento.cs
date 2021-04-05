using System;
using System.Collections.Generic;

namespace CarteiradeInvestimentos
{
    class CarteiraDeInvestimento
    {
        private List<Ativo> listaDeAtivos = new List<Ativo>();

        public void adicionaNovoAtivo()
        {
            //Console.WriteLine("Adicionando novo ativo na carteira");

            Console.Write("Código do ativo: ");
            string codigo = Console.ReadLine();

            Console.Write("quantidade de ativo: ");
            string quantidade = Console.ReadLine();

            Console.Write("Valor pago por cada unidade do ativo: ");
            string preco = Console.ReadLine();                        

            Console.Write("Titular: ");
            string titular = Console.ReadLine();            

            Console.Write("Tipo do Ativo: ");
            string tipo = Console.ReadLine();            

            Ativo ativo = new Ativo(codigo, Int32.Parse(quantidade), Double.Parse(preco), titular, tipo, DateTime.Now);
            listaDeAtivos.Add(ativo);
        }

        public void visualizarListaAtivosInvestido()
        {
            //Console.WriteLine("Visualizando lista de ativos investidos"

            int cont = 0;
            foreach (var ativo in listaDeAtivos)
            {
                cont ++; 
                Console.WriteLine("Preço: " + ativo.preco +  
                    ", Titular: " + ativo.titular + 
                    ", Tipo: " + ativo.tipo + 
                    ", Data Compra: " + ativo.data.ToString());
            }
            Console.WriteLine("\nQuantidade de Ativos comprados: " + cont);
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