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
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Insira apenas números inteiros");
                Console.Write("Quantidade de ativo: ");                
            }
            int quantidade = x;

            Console.Write("Valor pago por cada unidade do ativo: ");
            double z;
            while (!double.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine("Insira apenas números inteiros ou decimais !!!");
                Console.Write("Valor pago por cada unidade do ativo: ");
            }
            double preco = z;

            Console.Write("Titular: ");
            string titular = Console.ReadLine().ToUpper();

            Console.Write("Tipo do Ativo: ");
            string tipo = Console.ReadLine();

            Ativo ativo = new Ativo(codigo, quantidade, preco, titular, tipo, DateTime.Now);
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
            Console.Write("Insira código do Ativo: ");
            string codigo = Console.ReadLine().ToUpper();
            Console.Write("Unidades Vendidas: ");
            string quantidadeString = Console.ReadLine();
            int quantidade = Int32.Parse(quantidadeString);

            if (carteiraDeInvestimento.verificaQuantidade(codigo, quantidade))
            {
                carteiraDeInvestimento.informarVendaAtivo(codigo, quantidade);
            }
            else
            {
                Console.WriteLine("\nNão é possivel realizar a venda!");
            }
            
        }

        public void telaVisualizarResumoValorInvestido()
        {
            var (lista, total) = carteiraDeInvestimento.visualizarResumoValorInvestido();
            
            foreach(var mensagem in lista)
            {
                Console.WriteLine(mensagem);
            }

            Console.WriteLine($"Valor total carteira: {total}");
        }
    }
}
