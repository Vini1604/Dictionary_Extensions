# Dictionary e Extensions Methods

## Enunciado

1 - Criar a classe funcionário:

	Estrutura da classe: 
		Id = inteiro, 
		nome completo = literal, 
		data nascimento = tipo DATA,
		salario = decimal

2 - Solicitar o arquivo para o usuárioo e ler o arquivo texto (.txt) com o seguinte layout e importar dentro de uma list:

	id;nome;data nascimento;salario
	1;jefte goes;10/01/1991;10000.00
	2;bruna;10/02/1991;20000.00
	3;enzo;10/03/1991;10000.00

3 - Criar um objeto dictionary<int, string> e inserir o Id e o Nome da lista no dictionary, lembrando que o Id é a Key e Nome é o value:
	
	Resultado interno da aplicação
	1;jefte goes
	2;bruna
	3;enzo

	3.1 - Criar um objeto dictionary<int, string> e inserir o Id e o Mês (por extenso) da lista no dictionary, para achar o mês com base no que foi lido do arquivo, criar uma extension (.this) do datetime para buscar o mes por extenso e armazenar no Value:
		
		Resultado interno da aplicação:
		1;janeiro
		2;fevereiro
		3;marco

4 - Imprimir o resultado dos 2 dictionary, de forma dinamica:

	Ex: Resultado
	Id        Nome         Data de Nascimento por Extenso
	1         Jefte        Nasceu em janeiro
	2         Bruna        Nasceu em fevereiro
	3         Enzo         Nasceu em março

5 - Criar os métodos dentro de uma interface:

6 - Fazer o tratamento de erro: