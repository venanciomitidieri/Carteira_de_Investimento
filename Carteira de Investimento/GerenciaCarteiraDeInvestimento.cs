using System;
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