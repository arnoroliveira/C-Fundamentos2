using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Fundamentos2.Models
{

    public class Produtos
    {
        public Produtos(int id, string nomeProdutos, decimal valor, DateTime dataVenda)
        {
            Id = id;
            NomeProdutos = nomeProdutos;
            Valor = valor;
            DataVenda = dataVenda;
        }
        public int Id { get; set; }
        public string NomeProdutos { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVenda { get; set; }


        public override string ToString()
        {
            return $" ID: {Id}, Nome: {NomeProdutos}, Preço: {Valor.ToString("C")}, Data de Venda: {DataVenda}";
        }
    }
}