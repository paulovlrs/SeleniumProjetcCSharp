Feature: Textos
	Validar acesso a conteúdo e elementos da página

Background:
	Given Que eu esteja na tela principal
	And Acesso o Textos

@Acesso
Scenario: Validar acesso a página de noticias
	When clicar no link da reportagem
	Then Devo ser redicerionado para a pagina do medium