using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CadastroPessoa
{
    public class Pad
    {
        public Pad()
        {
            this.Nome = " ";
            this.Idade = 0;
            this.Cpf = " ";
            this.Sexo = " ";
            this.Telefone = " ";
            this.Data = " ";
        }

        public string Nome { get; set; }
        
        public int Idade { get; set; }

        private string cpf;
        public string Cpf
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
                    cpf = "Error";
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

        // private static int NumberId = 1;
        // public int Id { get; }
        
        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + this.Idade);
            Console.WriteLine("CPF: " + this.Cpf);
            Console.WriteLine("Data de Nascimento: " + this.Data);
            Console.WriteLine("Telefone: " + this.Telefone);
            Console.WriteLine("Sexo: " + Sexo);
            // Console.WriteLine("E-mail: " + Email);

        }
    }
}
