namespace Loja.Api.Models;

public class Variacao
{
    public int Id { get; private set; }
    public int Estoque { get; private set; }
    public decimal Preco { get; init; }
    public Tamanho Tamanho { get; init; }
    public Cor Cor { get; init; }
    public string CodigoSku { get; private set; }
    public int ProdutoId { get; private set; }

    public Variacao(int estoque, decimal preco, Tamanho tamanho, Cor cor, string codigoSku)
    {
        Preco = preco;
        Tamanho = tamanho;
        Cor = cor;
        CodigoSku = codigoSku;
        Estoque = estoque;
    }

    public void ReporEstoque(int quantidade)
    {
        if (quantidade <= 0) throw new ArgumentException("A quantidade deve ser maior que zero.");

        Estoque += quantidade;
    }

    public void BaixarEstoque(int quantidade)
    {
        if (quantidade <= 0) throw new ArgumentException("A quantidade deve ser maior que zero.");
        if (quantidade > Estoque) throw new InvalidOperationException("Não existe estoque para a quantidade selecionada.");

        Estoque -= quantidade;
    }
}