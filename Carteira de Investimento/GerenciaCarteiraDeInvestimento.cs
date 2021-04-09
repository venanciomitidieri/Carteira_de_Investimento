using System;
using System.Collections.Generic;

namespace CarteiraDeInvestimentos
{
    public class CarteiraDeInvestimento
    {
        public List<Ativo> listaDeAtivos = new List<Ativo>();        

        public void adicionaNovoAtivo(Ativo ativo)
        {
            listaDeAtivos.Add(ativo);
        }

        public List<Ativo> visualizarListaAtivosInvestido()
        {
            return listaDeAtivos;
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