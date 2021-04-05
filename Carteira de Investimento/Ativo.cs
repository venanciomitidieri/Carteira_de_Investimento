using System;

namespace CarteiradeInvestimentos
{
    class Ativo
    {
        public double preco;
        public string id;
        public string titular;
        public string tipo;
        public DateTime data;

        //Criando construtor
        public Ativo(double preco, string id, string titular, string tipo, DateTime data)
        {
            this.preco = preco;
            this.id = id;
            this.titular = titular;
            this.tipo = tipo;
            this.data = data;
        }
    }
}