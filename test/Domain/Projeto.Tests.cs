using FluentAssertions;
using Tests.Builders;
using Xunit;

namespace Tests.Domain;

public class ProjetoTests
{
    [Fact]
    public void DeveAdicionarTarefaEmProjetoAtivo()
    {
        var projeto = ProjetoBuilder.UmProjeto().Build();
        var tarefa = TarefaBuilder.UmaTarefa().Build();

        var resultado = projeto.AdicionarTarefa(tarefa);

        resultado.IsSucesso.Should().BeTrue();
        projeto.Tarefas.Should().Contain(tarefa);
    }

    [Fact]
    public void NaoDeveAdicionarTarefaEmProjetoInativo()
    {
        var projeto = ProjetoBuilder.UmProjeto().Inativo().Build();
        var tarefa = TarefaBuilder.UmaTarefa().Build();

        var resultado = projeto.AdicionarTarefa(tarefa);

        resultado.IsSucesso.Should().BeFalse();
        resultado.Erro.Should().Be("Projeto está inativo.");
    }
}
