# DIO - Trilha .NET - API e Entity Framework (Sistema Gerenciador de Tarefas)

Este projeto foi desenvolvido como parte de um desafio da trilha .NET da DIO. O objetivo é criar um sistema gerenciador de tarefas que permite realizar todas as operações de CRUD (Create, Read, Update, Delete) através de uma Web API.

## 🚀 Desvio Técnico e Solução (Oracle XE)

Originalmente, o projeto sugere o uso do SQL Server. No entanto, devido a limitações técnicas e problemas de compatibilidade com as ferramentas da Microsoft no ambiente local, optei por utilizar o **Oracle Database Express Edition (XE)**.

Para viabilizar essa integração, realizei as seguintes adaptações:
- **Provider:** Utilizei o pacote `Oracle.EntityFrameworkCore`.
- **Mapeamento de Schema:** Como o Oracle é sensível a letras maiúsculas/minúsculas e nomes de objetos, utilizei as Data Annotations `[Table]` e `[Column]` nas Models para garantir que o Entity Framework se comunicasse corretamente com as tabelas do Oracle.
- **Configuração de Enums:** Configurei a API para tratar Enums como strings, facilitando a legibilidade no Swagger e no banco de dados.

## 🛠️ Tecnologias Utilizadas
- .NET 6.0 (Web API)
- Entity Framework Core
- Oracle Database XE
- Swagger (OpenAPI) para documentação e testes

## 📋 Métodos da API

A API segue o padrão REST e possui os seguintes endpoints:

| Verbo | Endpoint | Descrição |
|-------|----------|-----------|
| GET | `/Tarefa/{id}` | Obtém uma tarefa específica pelo ID |
| GET | `/Tarefa/ObterTodos` | Lista todas as tarefas cadastradas |
| GET | `/Tarefa/ObterPorTitulo` | Filtra tarefas por título |
| GET | `/Tarefa/ObterPorData` | Filtra tarefas por data específica |
| GET | `/Tarefa/ObterPorStatus` | Filtra tarefas por status (Pendente/Finalizado) |
| POST | `/Tarefa` | Cria uma nova tarefa |
| PUT | `/Tarefa/{id}` | Atualiza uma tarefa existente |
| DELETE| `/Tarefa/{id}` | Remove uma tarefa do sistema |

## ✅ Conclusão
Todos os métodos (GET, POST, PUT, DELETE) e filtros (Por Título, Data e Status) solicitados no arquivo `README.md` principal foram implementados com sucesso seguindo os comentários `TODO` no código.