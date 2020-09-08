Feature: UploadDeArquivo
	Validar envio de arquivo e visualizar arquivo enviado

Background:
	Given Que eu esteja na tela principal
	And Acesso o Upload de Arquivo

@AdicionarArquivo
Scenario: Adicionar Arquivo
	When Adicionar um arquivo
	| Arquivo     |
	| cthulhu.jpg |
	Then O arquivo deve ser exibido