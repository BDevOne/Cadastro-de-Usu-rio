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

            Pad p1;
            Pad p3;
            Pad p2;
         // Pad p4; <- Usuário para teste do telefone

            // Cadastrar usuário
            // Solicitar informações do usuário (Documentos)
            // Adicionar telefone do usuário -- Criar método de solicitação de telefone

            Console.WriteLine("####Cadastro de usuário####\n");


            // Leitura de dados usuário 1
            Console.Write("Nome do 1 usuário: \n");
            p1 = new Pad();
            p1.Nome = Console.ReadLine();
            Console.Write("\nCPF do usuário: \n");
            p1.Cpf = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIdade do 1 usuário: \n");
            p1.Idade = Convert.ToInt32(Console.ReadLine());

            // Leitura de dados usuário 2
            Console.Write("\nNome do 2 usuário: \n");
            p2 = new Pad();
            p2.Nome = Console.ReadLine();
            Console.Write("\nCPF do usuário: \n");
            p2.Cpf = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIdade do 2 usuário: \n");
            p2.Idade = Convert.ToInt32(Console.ReadLine());

            // Leitura de dados usuário 3
            Console.Write("\nNome do 3 usuário: \n");
            p3 = new Pad();
            p3.Nome = Console.ReadLine();
            Console.Write("\nCPF do 3 usuário: \n");
            p3.Cpf = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIdade do 3 usuário: \n");
            p3.Idade = Convert.ToInt32(Console.ReadLine());

            // Usuário 4 - Usuário de teste  
            //Console.Write("\nNome do 4 usuário: \n");
            //p4 = new Pad();
            //p4.Nome = Console.ReadLine();
            //Console.Write("\nCPF do 4 usuário: \n");
            //p4.Cpf = Convert.ToInt32(Console.ReadLine());
            //Console.Write("\nIdade do 4 usuário: \n");
            //p4.Idade = Convert.ToInt32(Console.ReadLine());
            // int PhoneNumber = Convert.ToInt32(Console.ReadLine()); 

            // Usuário cadastrado - Não foi possível cadastrar

            if ((p1.Idade >= 18)) 
            {
                Console.WriteLine("Usuário 1 cadastrado. \n"); // Se for maior ou igual a 18 cadastrar usuário
                p1.ExibirDados(); 
            }
            else 
            {
                Console.WriteLine("Não foi possível cadastrar usuário 1 \n"); // Se o valor for menor que 18 exiber mensagem
            }

            {
                if ((p2.Idade >= 18))
                {
                    Console.WriteLine("Usuário 2 cadastrado. \n"); // Se for maior ou igual a 18 cadastrar usuário
                    p2.ExibirDados(); 
                }
                else
                {
                    Console.WriteLine("Não foi possível cadastrar usuário 2 \n"); // Se o valor for menor que 18 exiber mensagem
                }

                if ((p3.Idade >= 18))
                {
                    Console.WriteLine("Usuário 3 cadastrado. \n"); // Se for maior ou igual a 18 cadastrar usuário
                    p3.ExibirDados(); 
                }
                else
                {
                    {
                        Console.WriteLine("Não foi possível cadastrar usuário 3 \n"); // Se o valor for menor que 18 exiber mensagem
                    }
                    
                    // Criando solicitação de telefone

                    //if ((p4.Idade >= 18))
                    //{
                    //    Console.WriteLine("Usuário 4 cadastrado. \n"); // Se for maior ou igual a 18 cadastrar usuário
                    //    p4.ExibirDados();
                    //}
                    //else
                    //{
                    //    {
                    //        Console.WriteLine("Não foi possível cadastrar usuário 4 \n"); // Se o valor for menor que 18 exiber mensagem
                    //    }

                    }
            }
            Console.ReadLine();
            }
        }
    }


