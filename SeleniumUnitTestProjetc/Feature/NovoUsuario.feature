Feature: NovoUsuario
	Verificar se o cadastro de usuário está sendo inserido com sucesso. 
	Verficar se as mensagens de alerta estão sendo exibidas para o usuário. 
	Verificar campos obrigatórios.

Background:
	Given Que eu esteja na tela principal
	And Acesso o menu "Formulário"
	And seleciono a opção "Criar Usuários"

@cadastroDeUsuario
Scenario: Adicionar Usuário
	When Prencher os dados de entrada
		| Nome  | UltimoNome | Email           | Endereco | Universidade | Profissao   | Genero    | Idade |
		| Paulo | Silva      | teste@teste.com | Rua 1    | PUC          | QA Engineer | Masculino | 29    |
	And Clicar no botão Criar
	Then O Sistema retorna a mensagem
		| Mensagem                   |
		| Usuário Criado com sucesso |

@ValidarRegra
Scenario: Validar Campos obrigatórios
	When Prencher os dados de entrada
		| Nome | UltimoNome | Email | Endereco | Universidade | Profissao   | Genero    | Idade |
		|      |            |       | Rua 1    | PUC          | QA Engineer | Masculino | 29    |
	And Clicar no botão Criar
	Then O Sistema retorna a mensagem
		| Mensagem                                      |
		| 3 errors proibiu que este usuário fosse salvo |