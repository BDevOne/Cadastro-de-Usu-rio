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
        static void Main()
        {
            Users cadastro = new Users();

            // bool seguirCad = true; -- Implemantar cadastros multiplos

            Console.WriteLine("####Cadastro de usuário####\n");

            Console.WriteLine("\nDados Obrigátorios: Idade/CPF\n\n");

            Console.Write("Nome do usuário: ");
            cadastro.Nome = Console.ReadLine();

            Console.Write("\nCPF do usuário: ");
            cadastro.Cpf = Console.ReadLine();

            #region notUsed
            Console.Write("\nData de nascimento do usuário: ");
            cadastro.Data = Console.ReadLine();

            Console.Write("\nIdade do usuário: ");
            cadastro.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nTelefone do usuário: ");
            cadastro.Telefone = Console.ReadLine();

            Console.Write("\nSelecione o sexo do usuário  (M / F): ");
            cadastro.Sexo = Console.ReadLine();


            Console.Clear();
            #endregion

            Console.WriteLine("\n#Dados de Cadastro#\n");

            cadastro.RemoveEspecialCharacters();

            var cpfVerificar = !string.IsNullOrEmpty(cadastro.Cpf) && cadastro.Cpf.Length == 11; // Correção necessária - Alterar lógica de validação da idade e CPF.
            var idadeVerificar = cadastro.Idade >= 18;

            if (cpfVerificar == true)
            {
                cadastro.AddEspecialCharacters();
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

                        Console.WriteLine($"\nIdade não permitida: {cadastro.Idade}");
                    }
                }
            }
            else if (cpfVerificar == false)
            {
                Console.WriteLine($"\nNão foi possível cadastrar usuário {cadastro.Nome}\n");
                if (idadeVerificar == false)
                {
                    cadastro.ExibirDados();

                    Console.WriteLine($"\nIdade não permitida: {cadastro.Idade}");
                }
                Console.WriteLine($"\nCPF Inválido: {cadastro.Cpf}");
            }
            Console.ReadLine();

        }
    }
}
