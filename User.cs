#region Library
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Text.Encodings;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
#endregion

namespace CadastroPessoa
{
    public class Users
    {
        private string nome = string.Empty;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int idade;
        public int Idade 
        {
            get { return idade; }
            set { idade = value; }   
        }

        private string cpf = string.Empty;
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        private string sexo = string.Empty;
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
                        sexo = "Formato Inválido";
                        break;
                    }
                }
            }
        }

        private string dataDeNascimento = string.Empty;
        public string DataDeNascimento
        {
            get { return dataDeNascimento; }
            set { dataDeNascimento = value; }
        }

        private string telefone = string.Empty;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Users()
        {
            Nome = nome;
            Idade = idade;
            Cpf = cpf;
            Sexo = "";
            Telefone = "";
            DataDeNascimento = "";
        }
         
        public void RemoverMascaraCpf()
        {
            if (!string.IsNullOrEmpty(Cpf))
            {
                cpf = Cpf.Replace(".", "").Replace("-", "");
            }
        }

        public bool validacaoCpfUsuario()
        {
            RemoverMascaraCpf();
            if (!string.IsNullOrEmpty(Cpf) && Cpf.Length == 11)
            {
                cpf = Cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                return true;
            }
            return false;
        }

        public bool validarIdadeUsuario()
        {
            if (Idade >= 18)
            {
                idade = Idade;
                return true;
            }
            return false;
        }

        public void dataNascimentoCadastro()
        {
            if (!string.IsNullOrEmpty(DataDeNascimento) && DataDeNascimento.Length == 8)
            {
                dataDeNascimento = DataDeNascimento.Insert(2, "/").Insert(5, "/");
            }
            else
            {
                dataDeNascimento = null;
            }
        }

        public void telefoneCadastro()
        {
            if (!string.IsNullOrEmpty(Telefone))
            {
                if (Telefone.Length == 9 && int.TryParse(Telefone, out int parsedTelefone))
                {
                    telefone = parsedTelefone.ToString();
                }
                else
                {
                    telefone = $"Telefone Inválido. Revalidar telefone '{Telefone}' informado.";
                }
            }
            else if (Telefone == string.Empty)
            {
                telefone = $"Usuário optou por não cadastrar Telefone";
            }
        }
        
    }
}
