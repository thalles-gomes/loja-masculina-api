using Loja.Api.Enums;

namespace Loja.Api.Models;

public class Categoria
{
    public int Id { get; init; }
    public string Codigo { get; init; }
    public string Nome { get; init; }
    public GrupoTamanho GrupoTamanho { get; init; }

    public Categoria(int id, string codigo, string nome, GrupoTamanho grupoTamanho)
    {
        Id = id;
        Codigo = codigo;
        Nome = nome;
        GrupoTamanho = grupoTamanho;
    }
}
