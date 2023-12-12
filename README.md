# Cadastro de usuario

Melhoria implementada na Lógica do cadastro

            var idadeVerificar = cadUser.Idade >= 18; 
            var cpfVerificar = cadUser.Cpf != cadastro.Cpf;

            if (idadeVerificar && cpfVerificar)
            {
                Console.WriteLine($"\nUsuário {cadastro.Nome} Cadas trado\n");
                cadUser.ExibirDados();
            }
            else 
            {
                Console.WriteLine($"\nNão foi possível cadastrar usuário {cadastro.Nome}\n");
                cadUser.exibirDados();

                if (!idadeVerificar)
                {
                    Console.WriteLine($"\nIdade não permitida: {cadastro.Idade}");
                }
                if (!cpfVerificar)
                {
                    Console.WriteLine($"\nCPF Inválido: {cadastro.Cpf}");
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
                    if (value.Length == 8)
                    {
                        data = $"{value.Substring(0, 2)}/{value.Substring(2, 2)}/{value.Substring(4, 4)}";
                    }
                    else
                    {
                        data = "Formato Inválido";
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

# Update 22/08/2023

Melhoria no cadastro do usuário.

Em andamento cadastro de E-mail. 

# Correção 12/09/2023

Foi corrigido a validação do CPF que estava estava passando um valor nulo mesmo sendo preenchido.

# Correção 12/12/2023

Efetuada correção na validação do CPF, que anteriormente estava verificando sempre um valor, mesmo que não fosse correto, e realizando o cadastro.

var cpfVerificar = cadUser.Cpf != cadastro.Cpf;

# Itens a implementar 

1. Idade - Pegando a partir data de nascimento informada -- Em Andamento...
