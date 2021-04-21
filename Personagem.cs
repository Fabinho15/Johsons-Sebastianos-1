using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Personagem 
  {
    public string Nome; 
    public int Florim;
    public List<Item> Inventario;

    public Personagem (string nome, int florim)
    {
      this.Nome = nome;
      this.Florim = florim;
      this.Inventario = new List<Item>();
    }

    public void ImprimirPersonagem()
    {
      Console.WriteLine("\r\nNome:\t\t{0}", this.Nome);
      Console.WriteLine("Moedas:\t\t{0}", this.Florim);
      Console.Write("Inventário:\t{");
      foreach (var item in Inventario)
      {
        Console.Write("{0}, ", item.Nome);
      }
      Console.Write("}\r\n");
    }

    public void ComprarItem(string compra,List<Item> Estoque)
    {
      foreach (var p in Estoque)
      {
        if(p.Nome == compra)
        {
          if (this.Florim > p.Florim)
          {
            this.Florim = this.Florim - p.Florim;
            this.Inventario.Add(p);
          }
          else
          {
            Console.WriteLine("\r\nMoedas Florim insuficientes! Tente novamente!");
          }     
        }
      }
    }

    public string compra()
    {
      string compra;
      Console.Write("\r\nQuero comprar: ");
      compra = Console.ReadLine();
      return compra;
    }

  }