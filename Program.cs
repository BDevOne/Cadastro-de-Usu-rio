namespace CadastroPessoa
{
    class Program
    {
        static void Main()
        {
            Users cadastro = new Users();

            Console.WriteLine("####Cadastro de usuário####\n");
            Console.WriteLine("\nDados Obrigátorios: Idade/CPF\n\n");

            Console.Write("Nome do usuário: ");
            cadastro.Nome = Console.ReadLine();

            Console.Write("\nCPF do usuário: ");
            cadastro.Cpf = Console.ReadLine();

            Console.Write("\nData de nascimento do usuário: ");
            cadastro.DataDeNascimento = Console.ReadLine();

            cadastro.dataNascimentoCadastro();
            if (!string.IsNullOrEmpty(cadastro.DataDeNascimento))
            {
                string[] separarAno = cadastro.DataDeNascimento.Split('/');
                if (separarAno.Length >= 3 && int.TryParse(separarAno[2], out int anoNascimentoUsuario) && cadastro.Idade <= 0)
                {
                    cadastro.Idade = DateTime.Now.Year - anoNascimentoUsuario;
                }    
            }
            else if (string.IsNullOrEmpty(cadastro.DataDeNascimento))
            {
                ExibirErroCadastrarUsuario(mensagemErro: $"Data de Nascimento não informada. Para prosseguir com o cadastro informe a Idade do usuário.");
                Console.Write("Informe a Idade do usuário: ");
                cadastro.Idade = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.Write("\nTelefone do usuário: ");
            cadastro.Telefone = Console.ReadLine();
            cadastro.telefoneCadastro();

            Console.Write("\nSelecione o sexo do usuário  (M / F): ");
            cadastro.Sexo = Console.ReadLine();  

            cadastro.RemoveEspecialCharactersCpf();

            var cpfVerificar = !string.IsNullOrEmpty(cadastro.Cpf) && cadastro.Cpf.Length == 11;
            var idadeVerificar = cadastro.Idade >= 18;

            Console.WriteLine("\n#Dados de Cadastro#\n");

            if (cpfVerificar == true)
            {
                cadastro.AddEspecialCharactersCpf();
                if (idadeVerificar)
                {
                    Console.WriteLine($"\nUsuário {cadastro.Nome} Cadastrado\n");
                    cadastro.ExibirDados();
                }
                else
                {
                    if (!idadeVerificar)
                    {
                        Console.WriteLine($"\nNão foi possível cadastrar usuário {cadastro.Nome}\n");
                        cadastro.ExibirDados();

                        ExibirErroCadastrarUsuario(mensagemErro: $"Idade informada não permitida {cadastro.Idade}");
                    }
                }
            }
            else if (cpfVerificar == false)
            {
                ExibirErroCadastrarUsuario(mensagemErro: $"Não foi possível cadastrar usuário {cadastro.Nome}\n");
                cadastro.ExibirDados();

                ExibirErroCadastrarUsuario(mensagemErro: $"CPF incorreto, por favor revalidar.");
                
                if (!idadeVerificar)
                {
                    ExibirErroCadastrarUsuario(mensagemErro: $"\nIdade informada não permitida {cadastro.Idade}");
                }
            }
            
            void ExibirErroCadastrarUsuario(string mensagemErro)
            {
                Console.WriteLine($"\n{mensagemErro}");
            }

            Console.ReadLine();
        }
    }
}
