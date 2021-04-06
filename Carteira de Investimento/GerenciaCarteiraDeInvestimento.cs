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
            string codigo = Console.ReadLine().ToUpper();

            Console.Write("Quantidade de ativo: ");
            string quantidade = Console.ReadLine();

            Console.Write("Valor pago por cada unidade do ativo: ");
            string preco = Console.ReadLine();                        

            Console.Write("Titular: ");
            string titular = Console.ReadLine().ToUpper();            

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
                Console.WriteLine($"Código Ativo: {ativo.codigo}, Preço: {ativo.preco}," +
                $" Valor total alocado: {ativo.quantidade * ativo.preco}, Data Compra: {ativo.data}");
                //", Titular: " + ativo.titular + 
                //", Tipo: " + ativo.tipo + 
                //", Data Compra: " + ativo.data.ToString()");
            }
            Console.WriteLine("\nQuantidade de Ativos comprados: " + cont);
        }

        public void informarVendaAtivo()
        {
            Console.Write("Insira código do Ativo: ");
            string vendaAtivo = Console.ReadLine().ToUpper();
            //Console.Write("Unidades Vendidas: ");
            //Console.ReadLine();

            Ativo ativoRemover = new Ativo();

            foreach (var ativo in listaDeAtivos)
            {
                if (vendaAtivo.ToUpper() == ativo.codigo.ToUpper())
                {
                    ativoRemover = ativo;
                    //listaDeAtivos.Remove(ativoRemover);
                }
                else
                {
                Console.Write("ATENÇÃO, Você não pode vender um ativo que não tenha em sua carteira!!!");
                }
            }
            //Console.Write("ATENÇÃO, Você não pode vender um ativo que não tenha em sua carteira!!!");
            listaDeAtivos.Remove(ativoRemover);
        }

        public void visualizarResumoValorInvestido()
        {
            Console.WriteLine("Visualizando resumo do valor total investido em ativos");
        }
    }
}