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

A API foi estruturada para atender aos requisitos de negócio, garantindo que todas as operações essenciais estejam funcionais e validadas.

### Endpoints de Consulta (GET)

1.  **```GET /Tarefa/{id}```:** Busca uma tarefa específica pelo seu identificador (ID).
2. **```GET /Tarefa/ObterTodos:```** Retorna a lista completa de tarefas cadastradas.
3. **```GET /Tarefa/ObterPorTitulo:```** Filtra tarefas que contenham um termo específico no título.
4. **```GET /Tarefa/ObterPorData:```** Busca tarefas realizadas em uma data específica (comparação por data, ignorando horário).
5. **```GET /Tarefa/ObterPorStatus:```** Filtra tarefas pelo status atual (ex: Pendente, Finalizado).

### Endpoints de Manipulação (POST, PUT e DELETE)

1. **```POST /Tarefa:```** Cadastra uma nova tarefa. Possui validação para impedir datas vazias (```DateTime.MinValue```).
2.  **```PUT /Tarefa/{id}:```** Atualiza os dados de uma tarefa existente.
3. **```DELETE /Tarefa/{id}:```** Exclui permanentemente uma tarefa do sistema.

## 🚀 Tecnologias Utilizadas

* **C# / .NET 6** (Framework principal)
* **ASP.NET Core Web API** (Construção dos Endpoints)
* **Entity Framework Core** (ORM para persistência de dados)
* **SQL Server (LocalDB)** (Banco de dados relacional)
* **Swagger / OpenAPI** (Documentação e testes da API)

## 🛠️ Como Executar o Projeto

1. **Clonar o repositório: (bash)**
   ```bash
   git clone https://github.com/larissaribeiro-dev/trilha-net-api-desafio.git
   ```
   ```bash
   cd trilha-net-api-desafio/
   ```
2. **Restaurar dependências: (bash)**
    ```bash 
    dotnet restore
    ```
3. **Atualizar o Banco de Dados (Migrations): 
* Certifique-se de que a Connection String no appsettings.Development.json está correta e execute:
**(bash)** 
    ```Bash
    dotnet ef database update
    ```
4. **Executar a API: (bash)**
    ```Bash
    dotnet run
    ```
5. **Acessar a documentação:**  
* Com a API rodando, acesse: `https://localhost:7295/swagger`  
 
