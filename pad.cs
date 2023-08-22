using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    public class Pad
    {

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
                    value = value.Replace(".", "").Replace("-", "");

                    if (value.Length == 11)
                    {
                        cpf = value.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                    }
                }
                else
                {
                    cpf = "CPF Inválido";
                }
            }
        }

        private string sexo;
        public string Sexo
        {
            get { return sexo; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    switch (value.ToUpper())
                    {
                        case "M":
                            sexo = "Masculino";
                            break;
                        
                        case "F":
                            sexo = "Feminino";
                            break;
                        
                        default:
                            sexo = "Formato inválido";
                            break;
                    }
                }
            }
        }

        private string data;
        public string Data
        {
            get { return data; } 

            set
            {
              if (!string.IsNullOrEmpty(value))
              {
                if (value.Length == 8)
                {
                    data = $"{value.Substring(0, 2)}/{value.Substring(2, 2)}/{value.Substring(4, 4)}";
                } 
                else 
                {
                    data = "Formato inválido";
                }
              }
              
            }
        }

        private string telefone;
        public string Telefone

        {
            get { return telefone; }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {

                    if (value.Length == 9)
                    {
                        if (int.TryParse(value, out int parsedTelefone))
                        {
                            telefone = parsedTelefone.ToString();
                        }
                    }
                    else
                    {
                        telefone = "Telefone não cadastrado";
                    }
                }
            }
        }

        private string email;
        public string Email 

        { 
            get { return email; }
            set { email = value; }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + this.Idade);
            Console.WriteLine("CPF: " + Cpf);
            Console.WriteLine("Telefone: " + this.Telefone);
            Console.WriteLine("Data de Nascimento: " + this.Data);
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("E-mail: " + Email);

        }
    }
}
