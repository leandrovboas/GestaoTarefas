using Domain;

namespace Application.UseCases.CriarProjeto;

public class CriarProjetoHandler
{
    public Projeto Handle(CriarProjetoCommand command)
    {
        return new Projeto(command.Nome);
    }
}
