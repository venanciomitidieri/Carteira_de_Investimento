using System;


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
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Insira apenas números inteiros");
                Console.Write("Quantidade de ativo: ");                
            }
            int quantidade = a;

            Console.Write("Valor pago por cada unidade do ativo: ");
            double b;
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Insira apenas números inteiros ou decimais !!!");
                Console.Write("Valor pago por cada unidade do ativo: ");
            }
            double preco = b;

            Console.Write("Titular: ");
            double c;
            while (double.TryParse(Console.ReadLine(), out c))
            {                    
                Console.WriteLine("Insira apenas LETRAS");
                Console.Write("Titular: ");
            }
            string titular = c.ToString().ToUpper();

            Console.Write("Tipo do Ativo: ");
            double d;
            while (double.TryParse(Console.ReadLine(), out d))
            {
                Console.WriteLine("Insira apenas LETRAS");
                Console.Write("Tipo do Ativo: ");
            }
            string tipo = d.ToString().ToUpper();

            Ativo ativo = new Ativo(codigo, quantidade, preco, titular, tipo, DateTime.Now);
            carteiraDeInvestimento.adicionaNovoAtivo(ativo);
        }

        public void telaVisualizaListaAtivosInvestido()
        {

            int cont = 0;
            foreach (var ativo in carteiraDeInvestimento.listaDeAtivos)
            {
                cont++;
                Console.WriteLine($"Código Ativo: {ativo.codigo}, Preço: {ativo.preco}, Quantidade: {ativo.quantidade}," +
                $" Valor total alocado: {ativo.quantidade * ativo.preco}, Data Compra: {ativo.data}");
            }
            Console.WriteLine("\nQuantidade de Ativos comprados: " + cont);
        }

        public void telaInformaVendaAtivo()
        {
            Console.Write("Insira código do Ativo: ");
            string codigo = Console.ReadLine().ToUpper();
            Console.Write("Unidades Vendidas: ");
            string quantidadeString = Console.ReadLine();
            int quantidade = Int32.Parse(quantidadeString);

            if (carteiraDeInvestimento.verificaQuantidadeDeAtivosParaVenda(codigo, quantidade))
            {
                carteiraDeInvestimento.informaVendaAtivo(codigo, quantidade);
            }
            else
            {
                Console.WriteLine("\nNão é possivel realizar a venda! Número insuficiente de Ativos");
            }
            
        }

        public void telaVisualizaResumoValorInvestido()
        {
            var (lista, total) = carteiraDeInvestimento.visualizaResumoValorInvestido();
            
            foreach(var mensagem in lista)
            {
                Console.WriteLine(mensagem);
            }

            Console.WriteLine($"Valor total carteira: {total}");
        }
    }
}
