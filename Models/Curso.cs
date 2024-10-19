using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Fundamentos2.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno (Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos ()
        {
            Console.WriteLine($"Alunos do curso de {Nome}:");

            for (int count = 0; count < Alunos.Count; count++)
            {
                // string texto = "N° " + count+ " - " + Alunos[count].NomeCompleto;
                string texto = $"N° {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto); //Aqui o count = 0 vai fazer com que comece a numeração em 0 e o count + 1 faz com que a numeração comece em 1.
                // O sinal de INTERPOLAÇÃO: "$". A CONCATENAÇÃO vai possuir vários sinais de + ao longo da string.
            }
        }
    }
}