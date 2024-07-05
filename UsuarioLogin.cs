using CadastroPessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class UsuarioLogin
    {
        public void TelaDeLogin()
        {
            Console.WriteLine("Bem vindo à Tela de Login\n");
            Console.WriteLine("\nDados Obrigátorios: Idade Ou Data de Nacismento/CPF\n\n");
        }

        public void CadastroLogin()
        {
            List<Users> listaCadastros = new List<Users>();

            string seguirCadastrosUsuarios = "S";
            while (!string.IsNullOrEmpty(seguirCadastrosUsuarios) && seguirCadastrosUsuarios.ToUpper() == "S") 
            {
                Users cadastros = new Users();

                Console.Write("\nNome do usuário: ");
                cadastros.Nome = Console.ReadLine();

                Console.Write("\nCPF do usuário: ");
                cadastros.Cpf = Console.ReadLine();

                Console.Write("\nData de nascimento do usuário: ");
                cadastros.DataDeNascimento = Console.ReadLine();

                cadastros.dataNascimentoCadastro();
                if (!string.IsNullOrEmpty(cadastros.DataDeNascimento))
                {
                    string[] separarAno = cadastros.DataDeNascimento.Split('/');
                    if (separarAno.Length >= 3 && int.TryParse(separarAno[2], out int anoNascimentoUsuario) && cadastros.Idade <= 0)
                    {
                        cadastros.Idade = DateTime.Now.Year - anoNascimentoUsuario;
                    }
                }
                else if (string.IsNullOrEmpty(cadastros.DataDeNascimento))
                {
                    Console.WriteLine($"Data de Nascimento não informada. Para prosseguir com o cadastro, informe a Idade do usuário.");
                    Console.Write("Informe a Idade do usuário: ");
                    cadastros.Idade = Convert.ToInt32(Console.ReadLine());
                }

                listaCadastros.Add(cadastros);

                Console.Write("\nDeseja cadastrar outros usuários? (S/N): ");
                seguirCadastrosUsuarios = Console.ReadLine();
            }

            ExibirDadosUsuariosCadastrados(listaCadastros);
        }

        public void ExibirDadosUsuariosCadastrados(List<Users> listaCadastros)
        {
            Console.WriteLine($"\nUsuários Cadastrados");

            foreach (var user in listaCadastros)
            {
                if (user.validacaoCpfUsuario() && user.validarIdadeUsuario())
                {
                    Console.WriteLine($"\nNome: {user.Nome}");
                    Console.WriteLine($"CPF: {user.Cpf}");
                    Console.WriteLine($"Data de Nascimento: {user.DataDeNascimento}");
                    Console.WriteLine($"Idade: {user.Idade}");
                }
                else
                {
                    if (user.Cpf.Length < 11 && user.Idade < 18)
                    {
                        ExibirErroCadastrarUsuario(mensagemErro: $"Usuário não cadastrado corretamente.");
                        Console.WriteLine($"\nNome: {user.Nome}");
                        Console.WriteLine($"CPF: Não informado");
                        Console.WriteLine($"Data de Nascimento: {user.DataDeNascimento}");
                        Console.WriteLine($"Idade: {user.Idade}");
                    }
                }
            }
        }

        void ExibirErroCadastrarUsuario(string mensagemErro)
        {
            Console.WriteLine($"\n{mensagemErro}");
        }
    }
}
