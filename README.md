# 📝 Gerenciador de Tarefas - API de Agendamento
# DIO - Trilha .NET - API e Entity Framework
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de API e Entity Framework, da trilha .NET da DIO.

## Contexto
Você precisa construir um sistema gerenciador de tarefas, onde você poderá cadastrar uma lista de tarefas que permitirá organizar melhor a sua rotina.

Essa lista de tarefas precisa ter um CRUD, ou seja, deverá permitir a você obter os registros, criar, salvar e deletar esses registros.

A sua aplicação deverá ser do tipo Web API ou MVC, fique a vontade para implementar a solução que achar mais adequado.

A sua classe principal, a classe de tarefa, deve ser a seguinte:

![Diagrama da classe Tarefa](diagrama.png)

Não se esqueça de gerar a sua migration para atualização no banco de dados.

## Métodos esperados
É esperado que você crie o seus métodos conforme a seguir:


**Swagger**


![Métodos Swagger](swagger.png)


**Endpoints**


| Verbo  | Endpoint                | Parâmetro | Body          |
|--------|-------------------------|-----------|---------------|
| GET    | /Tarefa/{id}            | id        | N/A           |
| PUT    | /Tarefa/{id}            | id        | Schema Tarefa |
| DELETE | /Tarefa/{id}            | id        | N/A           |
| GET    | /Tarefa/ObterTodos      | N/A       | N/A           |
| GET    | /Tarefa/ObterPorTitulo  | titulo    | N/A           |
| GET    | /Tarefa/ObterPorData    | data      | N/A           |
| GET    | /Tarefa/ObterPorStatus  | status    | N/A           |
| POST   | /Tarefa                 | N/A       | Schema Tarefa |

Esse é o schema (model) de Tarefa, utilizado para passar para os métodos que exigirem

```json
{
  "id": 0,
  "titulo": "string",
  "descricao": "string",
  "data": "2022-06-08T01:31:07.056Z",
  "status": "Pendente"
}
```

## Solução

O desafio consistia em completar um sistema de agendamento de tarefas. A base do projeto já continha as classes de modelo e contexto, e a missão era implementar a lógica nos métodos do Controller para garantir que todas as operações do CRUD estivessem funcionais, obedecendo às seguintes regras:

1.  **GET /Tarefa/{id}:** Buscar tarefa por ID.
2.  **POST /Tarefa:** Adicionar nova tarefa com validação de data.
3.  **PUT /Tarefa/{id}:** Atualizar tarefa existente.
4.  **DELETE /Tarefa/{id}:** Remover tarefa do banco.
5.  **GET /Tarefa/ObterPorTitulo:** Filtro de busca por título.
6.  **GET /Tarefa/ObterPorStatus:** Filtro de busca por status (Pendente/Finalizado).
## 🚀 Tecnologias Utilizadas

* **C# / .NET 6** (Framework principal)
* **ASP.NET Core Web API** (Construção dos Endpoints)
* **Entity Framework Core** (ORM para persistência de dados)
* **SQL Server (LocalDB)** (Banco de dados relacional)
* **Swagger / OpenAPI** (Documentação e testes da API)
* **GitHub Copilot** (Auxílio na escrita de código e lógica)

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
