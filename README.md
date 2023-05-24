# Cadastro de usuario

Implementados - (Nome, idade, CPF e telefone)
 


Leitura de dados dos usuários

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
            
Lógica do cadastro

            Console.WriteLine("\n#Dados dos usuários#\n");

            Pad[] pessoas = { p1, p2, p3 };

            for (int i = 0; i < pessoas.Length; i++)
            {
                if (pessoas[i].Idade >= 18)
                {
                    Console.WriteLine($"\nUsuário {i + 1} cadastrado \n");
                    pessoas[i].ExibirDados();
                }
                else
                {
                    Console.WriteLine($"\nNão foi possível cadastrar usuário {i + 1} \n");
                    pessoas[i].ExibirDados();
                }
            }

# Itens a implementar 

1. Data de nascimento - Pegando o cálculo pela Idade informada 
2. Limpar tela ao terminar cadastro de cada Usuário
