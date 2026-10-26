namespace Loja.Api.Models;

public class Produto
{
    public int Id { get; init; }
    public string Nome { get; init; }
    public string Descricao { get; init; }
    public Categoria Categoria { get; init; }
    public List<Variacao> Variacoes { get; init; }

    public Produto(int id, string nome, string descricao, Categoria categoria, List<Variacao> variacoes)
    {
        Id = id;
        Nome = nome;
        Descricao = descricao;
        Categoria = categoria;
        Variacoes = variacoes;
    }

}