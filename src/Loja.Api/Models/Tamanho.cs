using Loja.Api.Enums;

namespace Loja.Api.Models;

public class Tamanho
{
    public int Id { get; init; }
    public string Codigo { get; init; }
    public GrupoTamanho Grupo { get; init; }

    public Tamanho(int id, string codigo, GrupoTamanho grupo)
    {
        Id = id;
        Codigo = codigo;
        Grupo = grupo;
    }
}
