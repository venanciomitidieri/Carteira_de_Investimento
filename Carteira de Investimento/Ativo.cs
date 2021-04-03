using System;

namespace CarteiradeInvestimentos
{
    class Ativo
    {
        public double preco;
        public string id;
        public string titular;
        public string tipo;

        public Ativo(double preco, string id, string titular, string tipo)
        {
            this.preco = preco;
            this.id = id;
            this.titular = titular;
            this.tipo = tipo;
        }
    }
}