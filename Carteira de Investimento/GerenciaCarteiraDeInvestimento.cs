using System;
using System.Collections.Generic;

namespace CarteiraDeInvestimentos
{
    public class carteiraDeInvestimentos
    {
        public List<Ativo> listaDeAtivos = new List<Ativo>();        

        public void adicionaNovoAtivo()
        {
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
            int cont = 0;
            foreach (var ativo in listaDeAtivos)
            {
                cont ++;
                Console.WriteLine($"Código Ativo: {ativo.codigo}, Preço: {ativo.preco}, Quantidade: {ativo.quantidade}," +
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

            Ativo ativoRemover = null;

            foreach (var ativo in listaDeAtivos)
            {
                if (vendaAtivo.ToUpper() == ativo.codigo.ToUpper())
                {
                    Console.Write("Unidades Vendidas: ");
                    string quantidadeVendido = Console.ReadLine();

                    if (Int32.Parse(quantidadeVendido) == ativo.quantidade)
                    {
                        ativoRemover = ativo;
                    }
                    else if (Int32.Parse(quantidadeVendido) < ativo.quantidade)
                    {
                        ativo.quantidade -= Int32.Parse(quantidadeVendido);
                        return;
                    }
                    else if (Int32.Parse(quantidadeVendido) > ativo.quantidade)
                    {
                        Console.WriteLine("\nQuantidade superior ao que você tem na carteira.");
                        return;
                    }
                }
            }

            if (ativoRemover != null)
            {
                listaDeAtivos.Remove(ativoRemover);
            }
            else 
            {
            Console.Write("ATENÇÃO, Você não pode vender um ativo que não tenha em sua carteira!!!\n");
            }
        }

        public void visualizarResumoValorInvestido()
        {
            double acumulador = 0;
            foreach (var ativo in listaDeAtivos)
            {
                double total = (ativo.quantidade * ativo.preco);
                Console.WriteLine($"Valor alocado em {ativo.codigo}: {total}");
            }

            foreach (var ativo in listaDeAtivos)
            {
                acumulador += (ativo.quantidade * ativo.preco); 
            }
            Console.WriteLine($"Valor total carteira: {acumulador}");
        }
    }
}