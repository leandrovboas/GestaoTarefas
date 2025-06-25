# Sistema de Gestão de Tarefas

Este projeto demonstra o uso de TDD com Clean Architecture e DDD em .NET 8, com suporte a xUnit, Moq, FluentAssertions e Builders.

## 📦 Estrutura

- `Domain`: entidades ricas com lógica de negócio
- `Application`: camada de casos de uso (a ser expandida)
- `Infrastructure`: camada de persistência (mockada por enquanto)
- `Tests`: testes organizados por domínio e casos de uso

## 🧪 Stack

- [.NET 8](https://dotnet.microsoft.com)
- xUnit
- Moq
- FluentAssertions

## ✅ Regras Implementadas

- Adicionar tarefa em projeto ativo
- Bloquear tarefa se projeto estiver inativo
- Limite de 10 tarefas por projeto

## ▶️ Rodando os testes

```bash
dotnet test
```

## ✨ Próximos passos

- Adicionar casos de uso em Application
- Expandir validações no domínio
- Adicionar persistência real
