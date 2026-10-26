namespace Loja.Api.Models;

public class Cor
{
    public int Id { get; init; }
    public string Nome { get; init; }

    public Cor(int id, string nome)
    {
        Id = id;
        Nome = nome;
    }
}