# 📝 Sistema Gerenciador de Tarefas - API & Entity Framework

Este projeto foi desenvolvido como um desafio técnico para a trilha .NET da **DIO (Digital Innovation One)**. O objetivo principal foi construir uma Web API robusta para gerenciamento de tarefas, aplicando conceitos de CRUD e persistência de dados.

## 🚀 Desafio e Adaptação Técnica (Diferencial)
Embora o desafio original sugerisse o uso do SQL Server, optei por utilizar o **Oracle Database Express Edition (XE)** como solução para o banco de dados. 

Essa escolha exigiu adaptações estratégicas na camada de persistência:
- **Configuração do Provider:** Implementação do pacote `Oracle.EntityFrameworkCore`.
- **Mapeamento de Dados:** Uso de Data Annotations (`[Table]`, `[Column]`) para compatibilidade com o schema do Oracle.
- **Tratamento de Enums:** Configuração da API para persistir Enums como strings, otimizando a leitura no banco e no Swagger.



## 🛠️ Tecnologias Utilizadas
* **Plataforma:** .NET 6.0 (Web API)
* **ORM:** Entity Framework Core (EF Core)
* **Banco de Dados:** Oracle Database XE
* **Documentação:** Swagger (OpenAPI)

## 🧠 Funcionalidades Implementadas
A API gerencia um ciclo completo de tarefas, contendo:
* **CRUD Completo:** Criação, leitura, atualização e deleção de registros.
* **Filtros Avançados:** Busca de tarefas por Título, Data específica e Status (Pendente/Finalizado).
* **Migrações:** Gestão do esquema do banco de dados via EF Migrations.

## 📋 Endpoints da API
Abaixo, os principais métodos expostos pela aplicação:

| Verbo | Endpoint | Parâmetro | Descrição |
|-------|----------|-----------|-----------|
| **GET** | `/Tarefa/{id}` | `id` | Busca tarefa por ID |
| **GET** | `/Tarefa/ObterTodos` | N/A | Lista todas as tarefas |
| **GET** | `/Tarefa/ObterPorStatus`| `status` | Filtra por Pendente/Finalizado |
| **POST** | `/Tarefa` | `Body` | Cria uma nova tarefa |
| **PUT** | `/Tarefa/{id}` | `id`, `Body` | Atualiza dados da tarefa |
| **DELETE**| `/Tarefa/{id}` | `id` | Remove a tarefa |

## ⚙️ Como Executar
1. Clone o repositório.
2. Certifique-se de ter o Oracle XE configurado ou ajuste a ConnectionString no `appsettings.json`.
3. Execute o comando `dotnet ef database update` para criar as tabelas.
4. Rode a aplicação com `dotnet run` e acesse o Swagger.

---
⭐ Projeto desenvolvido por [Larissa Ribeiro](https://github.com/larissaribeiro-dev) para consolidação de conhecimentos em Back-end com C#.