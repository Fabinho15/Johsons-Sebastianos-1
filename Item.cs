using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Item 
  {
    public string Nome;
    public string Descricao;
    public int Florim;
    public int Qnt;
    public string Categ;

    public Item(string nome, string descricao, int florim, int qnt, string categ)
    {
      this.Nome = nome;
      this.Descricao = descricao;
      this.Florim = florim;
      this.Qnt = qnt;
      this.Categ = categ;
    }
    
    public void ImprimirItem()
    {
      Console.WriteLine("\r\nNome:\t\t{0}", this.Nome);
      Console.WriteLine("Descrição:\t{0}", this.Descricao);
      Console.WriteLine("Moedas:\t\t{0}", this.Florim);
      Console.WriteLine("Quantidade:\t{0}", this.Qnt);
      Console.WriteLine("Categoria:\t{0}\r\n", this.Categ);
    }
  }
