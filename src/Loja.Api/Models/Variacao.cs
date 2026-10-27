namespace Loja.Api.Models;

public class Variacao
{
    public int Id { get; private set; }
    public int Estoque { get; init; }
    public decimal Preco { get; init; }
    public Tamanho Tamanho { get; init; }
    public Cor Cor { get; init; }
    public string CodigoSku { get; private set; }
    public int ProdutoId { get; private set; }

    public Variacao(int estoque, decimal preco, Tamanho tamanho, Cor cor, string codigoSku)
    {
        Estoque = estoque;
        Preco = preco;
        Tamanho = tamanho;
        Cor = cor;
        CodigoSku = codigoSku;
    }
}