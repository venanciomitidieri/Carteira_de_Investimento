using System;


namespace CarteiraDeInvestimentos
{
    public class Ativo
    {
        public string codigo;
        public int quantidade;
        public double preco;
        public string titular;
        public string tipo;
        public DateTime data;

        public Ativo(string codigo, int quantidade, double preco, string titular, string tipo, DateTime data)
        {
            this.codigo = codigo;
            this.quantidade = quantidade;
            this.preco = preco;
            this.titular = titular;
            this.tipo = tipo;
            this.data = data;
        }
    }
}