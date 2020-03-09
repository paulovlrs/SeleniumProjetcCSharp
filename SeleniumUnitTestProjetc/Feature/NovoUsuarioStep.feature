Feature: NovoUsuarioStep
	Verificar se o cadastro de usuário está sendo inserido com sucesso

@cadastro
Scenario: Adicionar Usuario
	Given Que eu esteja na tela principal
	And Acesso o cadastro de usuario
	When Prencher os dados de entrada
	| Nome  | Ultimo Nome | Email           | Endereco | Universidade | Profissao   | Genero    | Idade |
	| Paulo | Silva       | teste@teste.com | Rua 1    | PUC          | QA Engineer | Masculino | 29    |
	And Salvar
	Then O Sistema retorna mensagem
	| Mensagem                   |
	| Usuário Criado com sucesso |