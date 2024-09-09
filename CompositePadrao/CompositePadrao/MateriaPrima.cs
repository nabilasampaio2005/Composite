
public class MateriaPrima : ItemEstoque
{
    public int QuantidadeEstoque { get; set; }
    public string Fornecedor { get; set; }

    public MateriaPrima(string nome, int quantidade, string fornecedor)
        : base(nome)
    {
        QuantidadeEstoque = quantidade;
        Fornecedor = fornecedor;
    }

    public override int ObterQuantidadeTotal()
    {
        return QuantidadeEstoque;
    }
}
