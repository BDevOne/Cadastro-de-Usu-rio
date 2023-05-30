# Cadastro de usuario

Implementados - Nome - CPF - Telefone - Data de Nascimento - Idade - Sexo
 

Melhoria realizada no cadastro do usuário

           var cadastro = new Pad();
           

Lógica do cadastro

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

            if (!string.IsNullOrEmpty(value))
                {
                    switch (value.ToUpper())
                    {
                        case "M":
                            sexo = "Masculino";
                            break;
                        case "m":
                            sexo = "Masculino";
                            break;
                        case "F":
                            sexo = "Feminino";
                            break;
                        case "f":
                            sexo = "Feminino";
                            break;
                        default:
                            sexo = "Inválido";
                            break;
                    }
                }

A atualização contempla a seleção do sexo do usuário, agora sendo realizada uma validação para verificar o sexo a partir da letra inicial.

# Itens a implementar 

1. Data de nascimento - Pegando o cálculo pela Idade informada Andamento... 
