using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Loja
{
  public List<Item> Estoque = new List<Item> ();

  public void Carrinho(Item item)
  {
    this.Estoque.Add(item);
  }
  public void ImprimirCarrinho()
    {
      foreach (var item in Estoque)
      {
        item.ImprimirItem();
      }
    }
}