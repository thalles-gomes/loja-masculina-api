using Loja.Api.Enums;

namespace Loja.Api.Models;

public class Tamanho
{
    public int Id { get; private set; }
    public string Codigo { get; init; }
    public GrupoTamanho Grupo { get; init; }

    public Tamanho(string codigo, GrupoTamanho grupo)
    {
        Codigo = codigo.ToUpperInvariant();
        Grupo = grupo;
    }
}
