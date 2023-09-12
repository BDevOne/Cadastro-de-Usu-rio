using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.Encodings;

namespace CadastroPessoa
{
    public class Users
    {
        #region Constructors
        public Users()
        {
            Nome = " ";
            Idade = 0;
            Cpf = " ";
            Sexo = " ";
            Telefone = " ";
            Data = " ";
        }
        
        #endregion
         
        public string? Nome { get; set; }
        public int Idade { get; set; }

        private string? cpf;
        public string? Cpf
        {
            get { return cpf; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.Replace(".", "").Replace("-", "");
                    
                    while (value.Length == 11)
                    {
                       cpf = value.Insert(3, ".").Insert(7, ".").Insert(11, "-"); 
                       break;
                    }
                }
                else 
                {
                    cpf = null;
                }   
            }
        }

        private string? sexo;
        public string? Sexo
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
                            sexo = "Formato Inválido";
                            break;    
                    }
                }
            }
        }

        private string? data;
        public string? Data
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
                        data = "Formato Inválido";
                    }
                }
            }
        }

        private string? telefone;
        public string? Telefone
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
                        telefone = $"Telefone não cadastrado.";
                    }
                }
            }
        }
        
        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine("Data de Nascimento: " + Data);
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("Telefone: " + Telefone);
        }
    }
}
