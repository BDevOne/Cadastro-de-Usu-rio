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
Após verificar se o CPF é válido, adicionam-se os caracteres do tipo '.' e '-', permitindo a formatação adequada do CPF para exibição. 
#


# Melhorias / Correções 05/06/2024

Identificamos algumas falhas no cadastro de usuários, onde os dados do usuário não estavam sendo exibidos quando as informações obrigatórias (CPF/IDADE) não eram fornecidas. Sendo assim, aplicamos algumas melhorias para garantir que, mesmo na ausência dessas informações obrigatórias, os dados do usuário ainda sejam exibidos na tela.

**Implementação - Idade preenchida a partir da Data de Nascimento**
Foi implementado o preenchimento automático da idade no cadastro com base na data de nascimento. Portanto, ao informar a data de nascimento, não será necessário fornecer a idade manualmente.

**OBS:** Será possível enviar apenas a idade caso a data de nascimento não seja informada.
 
**Mensagem exibida:** Data de Nascimento não informada. Para prosseguir com o cadastro informe a Idade do usuário.

# Correção 02/07/2024 - Campo cadastro.DataDeNascimento

Identificamos e corrigimos o erro que ocorria ao passar um valor nulo no campo cadastro.DataDeNascimento. Devido a isso, não estava sendo possível informar a idade do usuário, o que impedia a realização do cadastro.


# Correção 05/07/2024 - Refatoração - Melhoria Cadastro Mútiplos -

Foi adicionada nova classe responsável pelo cadastro do **'Usuário'**, UsuarioLogin.cs.

Foi corrigida algumas falhas no presente no cadastro do usuário. 

Criado método para validação da Idade do usuário, **validarIdadeUsuario**. 

Implementado cadastros múltiplos de **Usuário**. Agora será possível cadastrar mais de 1 usuário. 
Deve ser apresentada uma mensagem na tela ao final do cadastro, **"Deseja cadastrar outros usuários? (S/N):"** para seguir com os cadastros basta informa="S", caso contrário deverá apresentar na tela as informações dos usuários cadastrados e não cadastrados. 

