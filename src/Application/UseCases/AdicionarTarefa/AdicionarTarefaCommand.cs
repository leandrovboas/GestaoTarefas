using System;

namespace Application.UseCases.AdicionarTarefa;

public class AdicionarTarefaCommand
{
    public Domain.Projeto Projeto { get; set; } = null!;
    public string Titulo { get; set; } = string.Empty;
    public DateTime Prazo { get; set; }
}
