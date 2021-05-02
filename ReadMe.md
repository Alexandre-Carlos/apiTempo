# Projeto WebService de Api do Tempo

## Visão geral do projeto
	Ao inserir a cidade é feita uma busca no banco de dados local verificando se a cidade já foi consultada nos ultimos 20 minutos, caso positivo será retornado os dados que estão no banco. Caso a consulta tenha sido feita a mais de 20 mins será feita uma nova requisição para a api openweather, para obter novos dados atualizados.
	Após está nova consulta os novos dados serão atualizados no banco de dados sobre a cidade já cadastrada anteriormente.


## Tecnologia utilizada 

- DotNet Core 3.1
- Projeto WebApi

## Escopo
	Projeto WebService para busca de Dados metereológicos na api https://openweathermap.org/

## Persistencia

- SqlServer 
	-  Banco de dados - Cidade


## Utilização do Projeto
	1. Após fazer o clone do projeto, utilizar o comando no pompt de comando na pasta do projeto 
		- dotnet restore
	2. Para criação do banco de dados 
		- dotnet ef database update

	
## Lista dos EndPoints
	1. Web Api com endpoints utilizando https://localhost:44336
	2. Documentação da api para listar os EndPoints - https://localhost:44336/swagger

### Lista geral de EndPoints
	1. /api/cidade - Consulta Cidade - utilizando requisição Get
		ex: "https://localhost:44336/api/Cidade?cidade=Sao Paulo"











