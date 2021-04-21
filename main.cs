using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class MainClass {
  
  public static void Main (string[] args) 
  {
    Loja carrinho = new Loja ();

    Console.Write ("Hello World");
    Console.WriteLine ("! Este é nosso lema.\r\nSeja bem-vinde a Johnsons & Sebastianos, a melhor loja de itens mágicos de todo o Vale das Fraldas.\r\n");

    Console.Write("Entre com seu nome e depois entre com a quantidade de moedas.\n");
    Personagem Cliente = new Personagem(nome: Console.ReadLine(), florim: Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("\r\nAbaixo segue nosso catálogo:");
    
    Item espada = new Item(nome:"Espada de madeira", descricao:"Espada frágil. Recomendada para iniciantes",florim: 8, qnt: 10);
    carrinho.Estoque.Add(espada);
    
    Item espadaf = new Item(nome:"Espada de ferro", descricao:"Espada mais resistente e afiada do que a de madeira. Recomendada para jogadores intermediários",florim: 15, qnt: 10);
    carrinho.Estoque.Add(espadaf);

    Item espadad = new Item(nome:"Espada de diamante", descricao:"A mais poderosa e suprema espada do Vale das Fraldas",florim: 50, qnt: 10);
    carrinho.Estoque.Add(espadad);

    Item escudo = new Item(nome:"Escudo de madeira", descricao:"Escudo frágil. Recomendado para iniciantes",florim: 10, qnt: 10);
    carrinho.Estoque.Add(escudo);

    Item escudof = new Item(nome:"Escudo de ferro", descricao:"Muito pesado, porém resistente",florim: 46, qnt: 10);
    carrinho.Estoque.Add(escudof);

    Item escudom = new Item(nome:"Escudo mágico", descricao:"Forjado nas profundezas de Noryuiem, este é o melhor escudo do Vale das Fraldas. Leve e resistente, o ideal para um verdadeiro guerreire.",florim: 130, qnt: 10);
    carrinho.Estoque.Add(escudom);

    Item botas = new Item(nome:"Bota simples", descricao:"Bota de couro normal. Recomendada para quem não quer molhar os pés",florim: 1, qnt: 10);
    carrinho.Estoque.Add(botas);

    Item botae = new Item(nome:"Botas encantadas", descricao:"Fornecem 5% de velocidade.",florim: 35, qnt: 10);
    carrinho.Estoque.Add(botae);

    Item botap = new Item(nome:"Botas de Pegasus", descricao:"Confeccionadas a parte das asas de um verdadeiro Pesasus",florim: 310, qnt: 10);
    carrinho.Estoque.Add(botap);

    Item pocaov = new Item(nome:"Pocao de vida", descricao:"Recupera 100% do seu HP",florim: 80, qnt: 10);
    carrinho.Estoque.Add(pocaov);

    Item pocaom = new Item(nome:"Pocao de mana", descricao:"Recupera 100% da sua mana",florim: 70, qnt: 10);
    carrinho.Estoque.Add(pocaom);

    Item pergaminho = new Item(nome:"Pergaminho portátil", descricao:"Ideal para mágias rápidas durante a jornada",florim: 590, qnt: 10);
    carrinho.Estoque.Add(pergaminho);

    Item pergaminhos = new Item(nome:"Super pergaminho", descricao:"O livro com todos os feitiços, poções e mágias descobertas e não descobertas. O desejo de qualquer um !",florim: 1000, qnt: 10);
    carrinho.Estoque.Add(pergaminhos);


    carrinho.ImprimirCarrinho();
    
    //espada.ImprimirItem();
    
    string alternativa;

    do{
      Cliente.ComprarItem(Cliente.compra(), carrinho.Estoque);
      Console.Clear();
      Cliente.ImprimirPersonagem();
      Console.Write("\r\nDigite 'comprar' para comprar novamente ou qualquer outra coisa para fechar: ");
      alternativa = Console.ReadLine();
      carrinho.ImprimirCarrinho();
    }
    while(alternativa == "comprar");
    if(alternativa != "comprar")
    {
      Console.WriteLine("\r\nOkay, " + Cliente.Nome + "!" + " Feche a porta ao sair e volte sempre!");
    }
  }
}