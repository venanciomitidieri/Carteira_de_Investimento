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