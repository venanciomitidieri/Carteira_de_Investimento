using System;
using System.Collections.Generic;


namespace CarteiraDeInvestimentos
{
    public class TelaAtivo
    {
        CarteiraDeInvestimento carteiraDeInvestimento;

        public TelaAtivo(CarteiraDeInvestimento carteiraDeInvestimento)
        {
            this.carteiraDeInvestimento = carteiraDeInvestimento;
        }
        
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
            carteiraDeInvestimento.adicionaNovoAtivo(ativo);
        }

        public void telaVisualizarListaAtivosInvestido()
        {

            int cont = 0;
            foreach (var ativo in carteiraDeInvestimento.listaDeAtivos)
            {
                cont++;
                Console.WriteLine($"Código Ativo: {ativo.codigo}, Preço: {ativo.preco}, Quantidade: {ativo.quantidade}," +
                $" Valor total alocado: {ativo.quantidade * ativo.preco}, Data Compra: {ativo.data}");
                // Titular:  {ativo.titular}, Tipo: {ativo.tipo}")
            }
            Console.WriteLine("\nQuantidade de Ativos comprados: " + cont);
        }

        public void telaInformarVendaAtivo()
        {
            Console.WriteLine("Estamos dentro de tela informar venda de um Ativo");
        }

        public void telaVisualizarResumoValorInvestido()
        {
            Console.WriteLine("Estamos dentro de tela visualizar resumo");
        }
    }
}
