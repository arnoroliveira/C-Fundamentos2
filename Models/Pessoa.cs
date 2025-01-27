using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Fundamentos2.Models
{
    public class Pessoa
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere adicionar o modificador "obrigatório" ou declarar como anulável.
        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        private string _nome;
        private int _idade;
        public string Nome 
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); 
        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que 0 anos");
                }

                _idade = value;
            }  
        }
        

        public string Estado { get; set; }

        public string estadoCivil { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos. Sou natural do {Estado} e sou {estadoCivil}");
        }
    }
}