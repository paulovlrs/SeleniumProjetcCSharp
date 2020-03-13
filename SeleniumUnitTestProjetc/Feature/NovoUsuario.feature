Feature: NovoUsuario
	Verificar se o cadastro de usuário está sendo inserido com sucesso.
	Verficar se as mensagens de alerta estão sendo exibidas para o usuário.
	Verificar campos obrigatórios.

# Para extrair aa feature com o Pickle, use o comando:
# Pickle-Features -FeatureDirectory .\SeleniumUnitTestProjetc\Feature -OutputDirectory C:\PickleOP -SystemUnderTestName "SeleniumUnitTestProject" -SystemUnderTestVersion "1.0"  -DocumentationFormat html
# Pickle-Features -FeatureDirectory .\SeleniumUnitTestProjetc\Feature -OutputDirectory C:\PickleOP -SystemUnderTestName "SeleniumUnitTestProject" -SystemUnderTestVersion "1.0"  -DocumentationFormat dhtml
Background:
	Given Que eu esteja na tela principal
	And Acesso o cadastro de usuario

@cadastro
Scenario: Adicionar Usuário	
	When * Prencher os dados de entrada
	| Nome  | UltimoNome | Email           | Endereco | Universidade | Profissao   | Genero    | Idade |
	| Paulo | Silva      | teste@teste.com | Rua 1    | PUC          | QA Engineer | Masculino | 29    |
	And Salvar
	Then O Sistema retorna mensagem
	| Mensagem                   |
	| Usuário Criado com sucesso |

@ValidarRegra
Scenario: Validar Campos obrigatórios
	When Nao Prencher os dados de entrada
	| Endereco | Universidade | Profissao   | Genero    | Idade |
	| Rua 1    | PUC          | QA Engineer | Masculino | 29    |
	And Salvar
	Then O Sistema retorna mensagem
	| Mensagem                                      |
	| 3 errors proibiu que este usuário fosse salvo | 