namespace Domain;

public class Resultado
{
    public bool IsSucesso { get; private set; }
    public string? Erro { get; private set; }

    private Resultado(bool sucesso, string? erro = null)
    {
        IsSucesso = sucesso;
        Erro = erro;
    }

    public static Resultado Sucesso() => new(true);
    public static Resultado Falha(string erro) => new(false, erro);
}
