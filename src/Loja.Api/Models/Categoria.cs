using Loja.Api.Enums;

namespace Loja.Api.Models;

public class Categoria
{
    public int Id { get; private set; }
    public string Codigo { get; init; }
    public string Nome { get; init; }
    public GrupoTamanho GrupoTamanho { get; init; }

    public Categoria(string codigo, string nome, GrupoTamanho grupoTamanho)
    {
        Codigo = codigo.ToUpperInvariant();
        Nome = nome;
        GrupoTamanho = grupoTamanho;
    }
}
