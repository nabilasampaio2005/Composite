using System;
using System.Collections.Generic;

public abstract class ItemEstoque
{
    public string Nome { get; set; }

    public ItemEstoque(string nome)
    {
        Nome = nome;
    }

    public abstract int ObterQuantidadeTotal();
    public virtual void Adicionar(ItemEstoque item) { }
    public virtual void Remover(ItemEstoque item) { }
}
