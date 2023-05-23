using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    public class Pad
    {
        // Construtores
        public Pad()
        {
            this.Nome = " ";
            this.Idade = 0;
            this.Cpf = " ";
            this.Sexo = " ";
            this.Telefone = 0;
        }

        public Pad(String nome, int idade, String cpf)
        {
            this.Nome = "nome";
            this.Idade = idade;
            this.Cpf = cpf;
            this.Telefone = telefone;

        }

        // Propriedades

        private String nome;
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int idade;
        public int Idade
        {
            get { return idade; }
            set
            {
                if (value >= 0)
                {
                    idade = value;
                }
                else
                {
                    this.idade = 0;
                }

            }

        }

        private String cpf; 
        public String Cpf 

        {
            get { return cpf; }


            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    // Remove formatação do CPF 
                    value  = value.Replace(".", "").Replace("-", "");

                    if (value.Length == 11)
                    {
                        cpf = value.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                    }
                    else
                    {
                        cpf = "CPF inválido";
                    }
                }
                
            }
        }

        private string sexo;
        public string Sexo
        {
            get { return sexo; }
            set => sexo = value;
        }

        private int telefone;
        public int Telefone

        {
            get { return telefone; }

            set
            {
                if (value >= 9)
                {
                    telefone = value;
                }
                else
                {
                    telefone = 0;
                }
            }
       
                
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
            Console.WriteLine("CPF: " + this.Cpf);
            Console.WriteLine("Idade: " + this.Telefone);
            Console.WriteLine("Sexo: " + Sexo);
        }
    }
}
