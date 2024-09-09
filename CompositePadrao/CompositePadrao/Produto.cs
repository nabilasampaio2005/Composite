public class ProdutoComposto : ItemEstoque
{
    private List<ItemEstoque> componentes = new List<ItemEstoque>();
    public int QuantidadeDisponivel { get; set; }

    public ProdutoComposto(string nome, int quantidade)
        : base(nome)
    {
        QuantidadeDisponivel = quantidade;
    }

    public override void Adicionar(ItemEstoque item)
    {
        componentes.Add(item);
    }

    public override void Remover(ItemEstoque item)
    {
        componentes.Remove(item);
    }

    public override int ObterQuantidadeTotal()
    {
        int total = QuantidadeDisponivel;

        foreach (var componente in componentes)
        {
            total += componente.ObterQuantidadeTotal();
        }

        return total;
    }

    // Gera o relatório
    public void GerarRelatorio()
    {
        Console.WriteLine($"Produto Composto: {Nome}");
        foreach (var componente in componentes)
        {
            if (componente is ProdutoComposto)
            {
                ((ProdutoComposto)componente).GerarRelatorio();
            }
            else
            {
                Console.WriteLine($"{componente.Nome} - Quantidade: {componente.ObterQuantidadeTotal()}");
            }
        }
    }
}
