﻿using System;
using System.Collections.Generic;

namespace CarteiradeInvestimentos
{
    public class TelaAtivo
    {
        public void telaAdicionaNovoAtivo()
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
        }

        public void telaVisualizarListaAtivosInvestido()
        {
            Console.WriteLine("Estamos dentro de tela visualizar lista de ativo investido");
        }

        public void telaInformarVendaAtivo()
        {
            Console.WriteLine("Estamos dentro de tela informar venda de um Ativo");
        }

        public void telaVisualizarResumoValorInvestido()
        {
            Console.WriteLine("Estamos dentro de tela visualizar resumo valor investido");
        }
    }
}
