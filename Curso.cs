using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos
{
    public class Curso
    {
        public String Nome { get; set; }
        public String Professor { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public Curso(String nome, String professor)
        {
            Nome = nome;
            Professor = professor;
            Alunos = new List<Pessoa>(); // Inicializa a lista de alunos
        }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
            Console.WriteLine($"Aluno {aluno.NomeCompleto} adicionado ao curso {Nome}"); //Interpolação de string
        }

        public int QuantidadeAlunos()
        {
            Console.WriteLine($"Quantidade de alunos no curso {Nome}: {Alunos.Count}");
            return Alunos.Count;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            Console.WriteLine($"Removendo aluno {aluno.NomeCompleto}");
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {        
            for(int contador = 0; contador < Alunos.Count; contador++)//Deve-se manter o contador em 0 como valor inicial, por causa dos índices
            
            {                
                Console.WriteLine($"Aluno {contador + 1} : {Alunos[contador].NomeCompleto}"); //+1 para não começar do 0 quando for exibir
            }
    }
}
}