using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos
{
    public class Pessoa
    {
        private String _nome;
        public String Sobrenome { get; set; }
        public String NomeCompleto => $"{Nome} {Sobrenome}";
        private int _idade;
        public String Nome 
        { 
            get => _nome;

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }
               
                _nome = value;
            }
        }
        public int Idade 
        { 
            get => _idade; 
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idade não pode ser menor que zero");
                }

            }
            
        }

        public Pessoa (String nome, String sobrenome, int idade) //Construtor
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        public Pessoa (){} //Construtor vazio

    }
 
}