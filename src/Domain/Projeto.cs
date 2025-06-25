using System;
using System.Collections.Generic;

namespace Domain;

public class Projeto
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public bool Ativo { get; private set; }
    private readonly List<Tarefa> _tarefas = new();
    public IReadOnlyCollection<Tarefa> Tarefas => _tarefas;

    public Projeto(string nome)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Ativo = true;
    }

    public Resultado AdicionarTarefa(Tarefa tarefa)
    {
        if (!Ativo)
            return Resultado.Falha("Projeto está inativo.");

        if (_tarefas.Count >= 10)
            return Resultado.Falha("Projeto atingiu o limite de tarefas.");

        _tarefas.Add(tarefa);
        return Resultado.Sucesso();
    }
}
