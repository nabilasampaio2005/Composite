public class Program
{
    public static void Main()
    {
        // Matérias-Primas
        MateriaPrima aco = new MateriaPrima("Aço", 100, "Fornecedor A");
        MateriaPrima plastico = new MateriaPrima("Plástico", 200, "Fornecedor B");

        // Componentes intermediários
        ProdutoComposto carcaça = new ProdutoComposto("Carcaça", 50);
        carcaça.Adicionar(aco);
        carcaça.Adicionar(plastico);

        // Produto final
        ProdutoComposto automovel = new ProdutoComposto("Automóvel", 100);
        automovel.Adicionar(carcaça);

        // Relatório
        automovel.GerarRelatorio();

        Console.WriteLine($"Quantidade disponível do produto final: {automovel.QuantidadeDisponivel} unidades.");
    }
}
