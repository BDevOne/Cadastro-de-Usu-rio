using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.Encodings;

namespace CadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {

           var cadastro = new Users();
           var cadUser = cadastro;

           // bool seguirCad = true; -- Implemantar cadastros multiplos

            Console.WriteLine("####Cadastro de usuário####\n");

            Console.WriteLine("\nDados Obrigátorios: Idade/CPF\n\n");

            Console.Write("Nome do usuário: ");
            cadastro.Nome = Console.ReadLine();

            Console.Write("\nCPF do usuário: ");
            cadastro.Cpf = Console.ReadLine();

            // Console.Write("\nData de nascimento do usuário: ");
            // cadastro.Data = Console.ReadLine();

            Console.Write("\nIdade do usuário: ");
            cadastro.Idade = Convert.ToInt32(Console.ReadLine());

            // Console.Write("\nTelefone do usuário: ");
            // cadastro.Telefone = Console.ReadLine();

            // Console.Write("\nSelecione o sexo do usuário  (M / F): ");
            // cadastro.Sexo = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("\n#Dados de Cadastro\n");

            var idadeVerificar = cadUser.Idade >= 18; 
            var cpfVerificar = cadUser.Cpf != cadastro.Cpf;

            if (idadeVerificar && cpfVerificar)
            {
                Console.WriteLine($"\nUsuário {cadastro.Nome} Cadastrado\n");
                cadUser.ExibirDados();
            }
            else 
            {
                Console.WriteLine($"\nNão foi possível cadastrar usuário {cadastro.Nome}\n");
                cadUser.ExibirDados();

                if (!idadeVerificar)
                {
                    Console.WriteLine($"\nIdade não permitida: {cadastro.Idade}");
                }
                if (!cpfVerificar)
                {
                    Console.WriteLine($"\nCPF Inválido");
                }
            }
            
            Console.ReadLine();
        }
    }
}
