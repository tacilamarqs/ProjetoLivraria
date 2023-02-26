<h1 align="center">Projeto Livraria API - Desafio Minsait</h1>

![LogoLivraria](https://user-images.githubusercontent.com/92822016/221395453-d2c0f3aa-de7c-46a7-9994-80f996880195.png)

# Sobre o projeto

O projeto foi proposto como um desafio que consiste em desenvolver um sistema de cadastro de livros para uma pequena livraria utilizando .NET e Angular.

O sistema de cadastro de livros conta com funcionalidades como:
- `Criar`: Possibilita o registro de livros no sistema.
- `Ler`: Possibilita a busca de livros no sistema.
- `Editar`: Possibilita a edição e atualização de livros no sistema.
- `Apagar`: Possibilita a exclusão de livros no sistema.

## Tecnologias utilizadas:

`.NET 6` 
`Angular 15.1.6`
`SQL Server`
`EntityFramework`
`Swagger`
`AutoMapper`
`Swagger`
`Git`

## É necessário ter na máquina local:

`.NET 6` 
`Angular 15.1.6`
`SQL Server`
`Visual Studio` 

## Para executar

1. Clone o repositório
   ```sh
   git clone https://github.com/tacilamarqs/ProjetoLivrariaAPI.git
   ```
2. Em appsettings.json realize alterações na ConnectionStrings para obter a conexão com o banco de dados
   ```sh
   "ConnectionStrings": {
    "DefaultConnection": "server=localhost\\sqlexpress;database=livrariaDb; password=root; Trusted_Connection=true; TrustServerCertificate=True"}
   ```
## Demonstração da aplicação

Utilizando Swagger para realizar os testes necessários no back-end:
![image](https://user-images.githubusercontent.com/92822016/221396048-f9a16a61-c5a8-4cdf-af15-1a364daf3d71.png)

GET:
![image](https://user-images.githubusercontent.com/92822016/221395982-41765689-0390-48c5-acbe-871fdc5ad2fe.png)

GET POR ID:
![image](https://user-images.githubusercontent.com/92822016/221396014-f726b468-3e1d-4bb2-8b10-7d573595b19c.png)

PUT:
![image](https://user-images.githubusercontent.com/92822016/221396092-49a27130-e296-4200-ac83-5d14f7446c07.png)
![image](https://user-images.githubusercontent.com/92822016/221396099-ef7cbcc2-962f-46e5-956a-e76a268ad4d6.png)

DELETE:
![image](https://user-images.githubusercontent.com/92822016/221396125-b5cf33ae-71b3-4213-b674-00f0e7995fe5.png)

POST:
![image](https://user-images.githubusercontent.com/92822016/221396151-7aa8dc07-4604-4a48-8bdb-8c5be87901d8.png)
![image](https://user-images.githubusercontent.com/92822016/221396161-113aa3c5-f177-4497-ba1c-501046a95469.png)


