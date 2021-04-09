﻿using System;
using System.Collections.Generic;

namespace CarteiraDeInvestimentos
{
    public class CarteiraDeInvestimento
    {
        public List<Ativo> listaDeAtivos = new List<Ativo>();   
        
        public bool verificaQuantidade(string codigo, int quantidade)
        {
            Ativo ativo = listaDeAtivos.Find(item => item.codigo.Equals(codigo));
            if (ativo == null)
            {
                return false;
            }
            else
            {
                return ativo.quantidade >= quantidade;
            }
        }

        public void adicionaNovoAtivo(Ativo ativo)
        {
            listaDeAtivos.Add(ativo);
        }

        public List<Ativo> visualizarListaAtivosInvestido()
        {
            return listaDeAtivos;
        }

        public void informarVendaAtivo(string codigo, int quantidade)
        {
            Ativo ativo = listaDeAtivos.Find(item => item.codigo.Equals(codigo));
            ativo.quantidade -= quantidade;

            if (ativo.quantidade == 0)
            {
                listaDeAtivos.Remove(ativo);
            }
        }        

        public (List<string>, double) visualizarResumoValorInvestido()
        {
            List<String> lista = new List<String>();
            double total = 0;

            foreach (var ativo in listaDeAtivos)
            {
                double totalPreco = (ativo.quantidade * ativo.preco);               
                lista.Add($"Valor alocado em {ativo.codigo}: {totalPreco}");
                total += totalPreco;
            }
            return (lista, total);
        }
    }
}