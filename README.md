# 📝 Gerenciador de Tarefas - API de Agendamento

Este projeto foi desenvolvido como parte do desafio técnico do **Bootcamp TIVIT - .NET com GitHub Copilot**, oferecido pela [DIO (Digital Innovation One)](https://www.dio.me/). O objetivo é criar uma API robusta para gerenciamento de tarefas (CRUD), utilizando boas práticas de desenvolvimento com C# e Entity Framework.

## 🚀 Tecnologias Utilizadas

* **C# / .NET 6** (Framework principal)
* **ASP.NET Core Web API** (Construção dos Endpoints)
* **Entity Framework Core** (ORM para persistência de dados)
* **SQL Server (LocalDB)** (Banco de dados relacional)
* **Swagger / OpenAPI** (Documentação e testes da API)
* **GitHub Copilot** (Auxílio na escrita de código e lógica)

## 🎯 O Desafio

O desafio consistia em completar um sistema de agendamento de tarefas. A base do projeto já continha as classes de modelo e contexto, e a missão era implementar a lógica nos métodos do Controller para garantir que todas as operações do CRUD estivessem funcionais, obedecendo às seguintes regras:

1.  **GET /Tarefa/{id}:** Buscar tarefa por ID.
2.  **POST /Tarefa:** Adicionar nova tarefa com validação de data.
3.  **PUT /Tarefa/{id}:** Atualizar tarefa existente.
4.  **DELETE /Tarefa/{id}:** Remover tarefa do banco.
5.  **GET /Tarefa/ObterPorTitulo:** Filtro de busca por título.
6.  **GET /Tarefa/ObterPorStatus:** Filtro de busca por status (Pendente/Finalizado).

## 🛠️ Como Executar o Projeto

1. **Clonar o repositório: (bash)**
   ```bash
   git clone https://github.com/SEU_USUARIO/trilha-net-api-desafio.git
   ```
   ```bash
   cd trilha-net-api-desafio/
   ```
2. **Restaurar dependências:  (bash)**
    ```bash 
    dotnet restore TrilhaApiDesafio.csproj
    ```
3. **Atualizar o Banco de Dados: (bash)**
* Certifique-se de que a Connection String no appsettings.Development.json está correta e execute:
    ```Bash
    dotnet ef database update --project TrilhaApiDesafio.csproj
    ```
4. **Executar a API: (bash)**
    ```Bash
    dotnet run --project TrilhaApiDesafio.csproj
    ```
5. **Acessar a documentação:**  
* Com a API rodando, acesse: `https://localhost:7295/swagger`  
 

---
Desenvolvido por **[Larissa Ribeiro](https://github.com/larissaribeiro-dev)** 