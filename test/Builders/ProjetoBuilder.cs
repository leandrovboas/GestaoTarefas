using Domain;

namespace Tests.Builders;

public class ProjetoBuilder
{
    private string _nome = "Projeto Teste";
    private bool _ativo = true;

    public static ProjetoBuilder UmProjeto() => new();

    public ProjetoBuilder Inativo()
    {
        _ativo = false;
        return this;
    }

    public ProjetoBuilder ComNome(string nome)
    {
        _nome = nome;
        return this;
    }

    public Projeto Build()
    {
        var projeto = new Projeto(_nome);
        if (!_ativo)
        {
            typeof(Projeto).GetProperty("Ativo")!.SetValue(projeto, false);
        }
        return projeto;
    }
}
