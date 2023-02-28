# DuettChallenge

Esse projeto foi desenvolvido conforme solicitado previamente, de forma que seja possível somar ou multiplicar os valores A e B de determinado item.

## Começando

<h3>1. Inicializando os projetos:</h3>

1.1 Primeiro iniciamos a API, utilizando o seguinte comando *no diretório da API*(DuettChallenge.Application/Api), no projeto backend:
```
dotnet run
```
1.2 Em seguida, iniciamos o nosso frontend, e podemos fazer isso no *diretório app*, executando o seguinte comando:
```
yarn start
```

## Executando os testes

<h3>2. (OPCIONAL)Criando registros:</h3>

*IMPORTANTE*: Vale ressaltar que, no projeto backend, já deixei um banco de dados populado com alguns dados, assim sendo, essa sessão(2) não se torna obrigatória.

2.1 Esse é o modelo do Json de entrada:
```
{
  "description": "string",
  "valueA": 0,
  "valueB": 0
}
```
- Podemos alterá-lo:
```
{
  "description": "Maçã",
  "valueA": 10,
  "valueB": 5
}
```
- Ao fazer o envio da requisição, via Swagger, Postman, Insomnia ou outro, receberemos como resposta os itens inseridos, o status de 200, e uma mensagem confirmando a inserção:
```
{
	"fruit": {
		"description": "Maçã",
		"valueA": 10,
		"valueB": 5
	},
	"message": "Item criado com sucesso."
}
```
No entanto, se tentarmos adicionar um item sem Description:
```
{
  "description": "",
  "valueA": 10,
  "valueB": 5
}
```
Obteremos o seguinte retorno:

```
{
	"errorsList": [
		{
			"propertyName": "Description",
			"errorMessage": "Description is required.",
			"attemptedValue": "",
			"customState": null,
			"severity": 0,
			"errorCode": "NotEmptyValidator",
			"formattedMessagePlaceholderValues": {
				"PropertyName": "Description",
				"PropertyValue": ""
			}
		}
	],
	"message": "Erro ao tentar criar um novo item:"
}
```

<h3>3. Executando as operações:</h3>

3.1 Seguindo com nosso passo a passo, a próxima etapa é verificar se nossos resultados de soma e multiplicação correm como esperado.

3.2 Na tela inicial do projeto(e única), clique no botão "selecionar" ao lado de cada item. Feito isso, você terá acesso as informações daquele item, como descrição, valor A e valor B.

3. Para finalizar, basta executar como quiser cada operação, e o resultado poderá ser visualizado no campo "Resultado".

<h3>4. Considerações finais:</h3>

- Durante o desenvolvimento do projeto, pensei em diversas maneiras de desenvolver a solução solicitada, me atentando sempre as necessidades do projeto. Com isso em mente, imaginei várias maneiras de desenvolver a arquitetura do projeto, onde inicialmente pensei usar uma arquitetura de camada simples, com todas as camadas dentro do projeto da API: além dos controllers, claro, Services e Data. No entanto, imaginei que usar uma arquitetura um pouco mais robusta, poderia ser bom.

- Também pensei em desenvolver a camada de testes unitários, e inicialmente a criei, mas depois, pela quantidade de funcionalidades na API, optei por não manter.

