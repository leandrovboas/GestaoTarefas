using Domain;

namespace Application.UseCases.AdicionarTarefa;

public class AdicionarTarefaHandler
{
    public Resultado Handle(AdicionarTarefaCommand command)
    {
        var tarefa = new Tarefa(command.Titulo, command.Prazo);
        return command.Projeto.AdicionarTarefa(tarefa);
    }
}
