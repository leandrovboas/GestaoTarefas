using Domain;
using System;

namespace Tests.Builders;

public class TarefaBuilder
{
    private string _titulo = "Tarefa Teste";
    private DateTime _prazo = DateTime.Today.AddDays(7);

    public static TarefaBuilder UmaTarefa() => new();

    public TarefaBuilder ComTitulo(string titulo)
    {
        _titulo = titulo;
        return this;
    }

    public TarefaBuilder ComPrazo(DateTime prazo)
    {
        _prazo = prazo;
        return this;
    }

    public Tarefa Build() => new(_titulo, _prazo);
}
