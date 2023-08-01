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

            Console.WriteLine("\nInformações do usuário\n");

            // Leitura de dados usuário 1
            Console.Write("Nome do usuário: ");
            cadastro.Nome = Console.ReadLine();

            Console.Write("\nCPF do usuário: ");
            cadastro.Cpf = Console.ReadLine();

            Console.Write("\nData de nascimento do usuário: ");
            cadastro.Data = (Console.ReadLine());

            Console.Write("\nIdade do usuário: ");
            cadastro.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nTelefone do usuário: ");
            cadastro.Telefone = (Console.ReadLine());

            Console.Write("\nSelecione o sexo do usuário  (M / F): ");
            cadastro.Sexo = Console.ReadLine();


            Console.Clear(); // Limpa as informações do prompt 

            // Lógica do Cadastro - Idade

            Console.WriteLine("\n#Dados do usuário cadastrado#\n");

            Pad[] pessoas = { cadastro };

            for (int i = 0; i < pessoas.Length; i++)
            {
                if (pessoas[i].Idade >= 18)
                {
                    Console.WriteLine($"\nUsuário {i + 1} cadastrado \n");
                    pessoas[i].ExibirDados();
                }
                else // Melhoria --> add mensagem do por que não foi cadastrado 
                {
                    Console.WriteLine($"\nNão foi possível cadastrar usuário  {i + 1} \n");
                    pessoas[i].ExibirDados();
                }
                
            }

            Console.ReadLine();
        }
    }
}
