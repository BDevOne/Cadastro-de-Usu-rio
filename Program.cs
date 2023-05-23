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
            // Usuário Pad p2 , Pad p3
            Pad p1;

            // Implentar API de busca por usuário
            // Adicionar telefone do usuário -- Criar método de solicitação de telefone 
            // Implementar Data de nascimento <- (Em andamento...) -- observações do usuário

            Console.WriteLine("####Cadastro de usuário####\n");

            Console.WriteLine("\nInformações do usuário 1\n");

            // Leitura de dados usuário 1
            Console.Write("Nome do 1 usuário: \n");
            p1 = new Pad();
            p1.Nome = Console.ReadLine();
            Console.Write("\nCPF do usuário: \n");
            p1.Cpf = Console.ReadLine();
            Console.Write("\nIdade do usuário: \n");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nTelefone do usuário: \n");
            p1.Telefone = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nSexo do usuário: \n");
            p1.Sexo = Console.ReadLine();

            // Lógica do Cadastro 

            Console.WriteLine("\n#Dados do usuário cadastrado#\n");

            Pad[] pessoas = { p1 };

            for (int i = 0; i < pessoas.Length; i++)
            {
                if (pessoas[i].Idade >= 18)
                {
                    Console.WriteLine($"\nUsuário {i + 1} cadastrado \n");
                    pessoas[i].ExibirDados();
                }
                else // add mensagem do por que não foi cadastrado
                {
                    Console.WriteLine($"\nNão foi possível cadastrar usuário  {i + 1} \n");
                    pessoas[i].ExibirDados();
                }
            }

            Console.ReadLine();
        }
    }
}
