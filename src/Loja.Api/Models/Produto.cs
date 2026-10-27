namespace Loja.Api.Models;

public class Produto
{
    public int Id { get; private set; }
    public string Nome { get; init; }
    public string Descricao { get; init; }
    public string Codigo { get; init; }
    public Categoria Categoria { get; init; }

    private readonly List<Variacao> _variacoes = new();
    public IReadOnlyCollection<Variacao> Variacoes => _variacoes;

    public Produto(string nome, string descricao, string codigo, Categoria categoria)
    {
        Nome = nome;
        Descricao = descricao;
        Codigo = codigo.ToUpperInvariant();
        Categoria = categoria;
    }

    public void AdicionarVariacao(int estoque, decimal preco, Tamanho tamanho, Cor cor)
    {
        if (preco <= 0) throw new ArgumentException("O valor da variação é inválido");
        if (estoque < 0) throw new ArgumentException("O valor de estoque é inválido");
        if (tamanho.Grupo != Categoria.GrupoTamanho) throw new InvalidOperationException($"O tamanho {tamanho.Codigo} não pertence ao grupo {Categoria.GrupoTamanho}.");
        if (_variacoes.Any(v => v.Cor.Codigo == cor.Codigo && v.Tamanho.Codigo == tamanho.Codigo))
        {
            throw new InvalidOperationException($"O Produto já possui a {cor.Nome} e o tamanho {tamanho.Codigo} registrado");
        } 

        string codigoSku = $"{Codigo}-{cor.Codigo}-{tamanho.Codigo}";
        
        var variacao = new Variacao(estoque, preco, tamanho, cor, codigoSku);
        _variacoes.Add(variacao);
    }

}