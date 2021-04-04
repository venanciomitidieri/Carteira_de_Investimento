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

            Console.Write("Preço do ativo: ");
            string preco = Console.ReadLine();            

            Console.Write("Identificação do ativo: ");
            string id = Console.ReadLine();            

            Console.Write("Titular: ");
            string titular = Console.ReadLine();            

            Console.Write("Tipo do Ativo: ");
            string tipo = Console.ReadLine();

            Ativo ativo = new Ativo(Double.Parse(preco), id, titular, tipo);
            listaDeAtivos.Add(ativo);

            //Console.WriteLine("\nMonstrando novo Ativo adicionado:");
            //Console.WriteLine("Preço do Ativo: " + preco);
            //Console.WriteLine("Identificação do ativo: " + id);
            //Console.WriteLine("Titular do ativo: " + titular);
            //Console.WriteLine("Identificação do ativo: " + tipo);
        }

        public void visualizarListaAtivosInvestido()
        {
            //Console.WriteLine("Visualizando lista de ativos investidos");
            foreach (var ativo in listaDeAtivos)
            {
                Console.WriteLine(ativo);
            }
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