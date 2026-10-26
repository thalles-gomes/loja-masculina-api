namespace Loja.Api.Models;

public class Variacao
{
    public int Id { get; init; }
    public int Estoque { get; private set; }
    public decimal Preco { get; init; }
    public Tamanho Tamanho { get; init; }
    public Cor Cor { get; init; }
    public string CodigoSku { get; init; }


    public Variacao(int produtoId, int estoque, decimal preco, Tamanho tamanho, Cor cor, string codigoSku)
    {
        Estoque = estoque;
        Preco = preco;
        Tamanho = tamanho;
        Cor = cor;
        CodigoSku = codigoSku;
    }
}