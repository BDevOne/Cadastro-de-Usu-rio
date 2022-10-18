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
            this.Cpf = 0;
            this.Sexo = " ";
        }

        public Pad(String nome, int idade, int cpf) // Adicionar telefone do usuário
        {
            this.Nome = "nome";
            this.Idade = idade;
            this.Cpf = cpf;
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

        private Int64 cpf;
        public Int64 Cpf

        {
            get { return cpf; }


            set
            {
                if (value > 0)
                {
                    cpf = value;
                }
                else this.cpf = 0;
            }
        }

        private string sexo;

        public string Sexo
        {
            get { return sexo; }
            set => sexo = value;
        }


        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Idade: " + this.Idade);
            Console.WriteLine("CPF: " + this.Cpf);
            Console.WriteLine("Sexo: " + Sexo);
        }
    }
}

