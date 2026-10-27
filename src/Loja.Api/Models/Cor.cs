namespace Loja.Api.Models;

public class Cor
{
    public int Id { get; private set; }
    public string Nome { get; init; }
    public string Codigo {get; init;}

    public Cor(string nome, string codigo)
    {
        Nome = nome;
        Codigo = codigo.ToUpperInvariant();
    }
}