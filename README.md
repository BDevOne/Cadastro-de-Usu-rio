# Cadastro de usuario

Implementados - Nome - CPF - Telefone - Data de Nascimento - Idade - Sexo
 

Melhoria realizada no cadastro do usuário

           var cadastro = new Pad();
    

Lógica do cadastro

            Pad[] pessoas = { cadastro };

            for (int i = 0; i < pessoas.Length; i++)
            {
                bool idadeVerificar = pessoas[i].Idade >= 18;
                bool cpfVerificar = !string.IsNullOrEmpty(pessoas[i].Cpf);

                if (idadeVerificar && cpfVerificar)
                {
                    Console.WriteLine($"\nUsuário {i + 1} cadastrado \n");
                    pessoas[i].ExibirDados();
                }
                else // Melhoria --> add mensagem do por que não foi cadastrado 
                {
                    Console.WriteLine($"\nNão foi possível cadastrar usuário  {i + 1} \n");
                    pessoas[i].ExibirDados();
                    if (!idadeVerificar)
                    {
                        Console.WriteLine("\nIdade não permitida");
                    }
                    if (!cpfVerificar)
                    {
                        Console.WriteLine("\nCPF Inválido\n");
                    }
                }
           
            
Melhoria aplicada no tratamento das informações do telefone

           if (!string.IsNullOrEmpty(value))
                {
                    if (value.Length == 9)
                    {
                        if (int.TryParse(value, out int parsedTelefone))
                        {
                            telefone = parsedTelefone.ToString();
                        }
                    }
                    else
                    {
                        telefone = "Telefone não cadastrado";
                    }
                }
                              

Melhoria aplicada no tratamento de data de nascimento 

            if (!string.IsNullOrEmpty(value))
                {
                    value = value.Replace("/", "");

                    if (value.Length == 8)
                    {
                        date = value.Insert(2, "/").Insert(5, "/");
                    }
                    else
                    {
                        date = "Formato inválido";
                    }
                }
                

Melhoria aplicada no tratamento da seleção do Sexo do usuário

            switch (value.ToUpper())
            {
                        case "M":
                            sexo = "Masculino";
                            break;
                        
                        case "F":
                            sexo = "Feminino";
                            break;
                        
                        default:
                            sexo = "Formato inválido";
                            break;
            }  
            
                        
Melhoria CPF

            if (!string.IsNullOrEmpty(value))
                {
                    value  = value.Replace(".", "").Replace("-", "");

                    if (value.Length == 11)
                    {
                        cpf = value.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                    }
                    else
                    {
                        cpf = "CPF inválido";
                    }
                }
                  
# Updates 17/08/2023 

Melhoria realizada na lógica do cadastro de usuário, podendo agora validar cadastro apartir do CPF informado. 

Melhoria realizada na validação de cadastro do CPF.

Melhoria realizada na seleção de gênero: 

![image](https://github.com/BDevOne/Cadastro-de-Usuario/assets/115705346/5579b1ea-f1de-45fb-b3a1-ec858b98f841)


# Correções 19/08/2023 

Correção aplicada seção de cadastro de CPF, que abordava duas validações. A primeira validava a presença dos 11 dígitos, aplicando a máscara adequada. A segunda, por sua vez, conferia se havia exatamente 11 dígitos, desconsiderando qualquer máscara.

# Itens a implementar 

1. Idade - Pegando a partir data de nascimento informada -- Em Andamento...
