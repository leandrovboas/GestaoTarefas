using System;

namespace Domain;

public class Tarefa
{
    public Guid Id { get; private set; }
    public string Titulo { get; private set; }
    public DateTime Prazo { get; private set; }

    public Tarefa(string titulo, DateTime prazo)
    {
        Id = Guid.NewGuid();
        Titulo = titulo;
        Prazo = prazo;
    }
}
