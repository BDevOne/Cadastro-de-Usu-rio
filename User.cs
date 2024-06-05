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

        public int Idade { get; set; }

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
            Idade = 0;
            Cpf = cpf;
            Sexo = "";
            Telefone = "";
            DataDeNascimento = "";
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Data de Nascimento: " + DataDeNascimento);
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("Telefone: " + Telefone);
        }

        public void RemoveEspecialCharactersCpf() 
        {
            if (!string.IsNullOrEmpty(Cpf))
            {
                cpf = Cpf.Replace(".", "").Replace("-", "");
            }
        }

        public void AddEspecialCharactersCpf() 
        {
            if (!string.IsNullOrEmpty(Cpf))
            {
                cpf = Cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
            }
        }

        public void dataNascimentoCadastro()
        {
            if (!string.IsNullOrEmpty(DataDeNascimento))
            {
                if (DataDeNascimento.Length == 8)
                {
                    dataDeNascimento = $"{DataDeNascimento.Substring(0, 2)}/{DataDeNascimento.Substring(2, 2)}/{DataDeNascimento.Substring(4, 4)}";
                }
            }
        }

        public void telefoneCadastro()
        {
            if (!string.IsNullOrEmpty(Telefone))
            {
                if (Telefone.Length == 9)
                {
                    if (int.TryParse(Telefone, out int parsedTelefone))
                    {
                        telefone = parsedTelefone.ToString();
                    }
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
