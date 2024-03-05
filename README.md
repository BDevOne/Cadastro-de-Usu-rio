# **Cadastro de usuario**
                  
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

# Melhoria 05/03/2024 

Foram realizadas melhorias no cadastro do CPF, incluindo uma alteração na lógica de validação. Anteriormente o sistema não estava capturando o valor corretamente, resultando em um valor '**nulo**' ou '**vazio**', mesmo quando o campo estava preenchido.

Foram desenvolvidos dois métodos para a validação do CPF. 

Método **RemoveEspecialCharacters** 
Remove caracteres do tipo '.' e '-', caso o CPF seja inserido com máscara.

Método **AddEspecialCharacters**
Após validar se o CPF é válido, adicionam-se os caracteres do tipo '.' e '-', permitindo a formatação adequada do CPF para exibição. 

# Itens a implementar 

1. Idade - Pegando a partir data de nascimento informada -- Em Andamento...
