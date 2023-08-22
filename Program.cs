using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {

            var cadastro = new Pad();

            Console.WriteLine("####Cadastro de usuário####\n");

            Console.WriteLine("\nDados Obrigátorios: Idade/CPF\n\n");

            // Leitura de dados usuário
            Console.Write("Nome do usuário: ");
            cadastro.Nome = Console.ReadLine();

            Console.Write("\nCPF do usuário: ");
            cadastro.Cpf = Console.ReadLine();

            Console.Write("\nData de nascimento do usuário: ");
            cadastro.Data = Console.ReadLine();

            Console.Write("\nIdade do usuário: ");
            cadastro.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nTelefone do usuário: ");
            cadastro.Telefone = Console.ReadLine();

            Console.Write("\nSelecione o sexo do usuário  (M / F): ");
            cadastro.Sexo = Console.ReadLine();

            Console.Write("\nDigite seu e-mail:");
            cadastro.Email = Console.ReadLine();
            

            Console.Clear();

            // Cadastro
            Console.WriteLine("\n#Dados Cadastro#\n");

            var pessoas = cadastro;

                bool idadeVerificar = pessoas.Idade >= 18;
                bool cpfVerificar = !string.IsNullOrEmpty(pessoas.Cpf);

                if (idadeVerificar && cpfVerificar)
                {
                    Console.WriteLine($"\nUsuário {cadastro.Nome} cadastrado\n");
                    pessoas.ExibirDados();
                }
                else // Melhoria --> add mensagem com erro de cadastro
                {
                    Console.WriteLine($"\nNão foi possível cadastrar usuário {cadastro.Nome}\n");
                    pessoas.ExibirDados();
                    if (!idadeVerificar)
                    {
                        Console.WriteLine($"\nIdade informada não Permitida: {cadastro.Idade}.");
                    }
                    if (!cpfVerificar)
                    {
                        Console.WriteLine($"\nCPF Inválido\n");
                    }
                }

            Console.ReadLine();
        }
    }
}
